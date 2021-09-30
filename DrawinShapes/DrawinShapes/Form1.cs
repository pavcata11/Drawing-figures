using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Channels;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;

namespace DrawinShapes
{
    public partial class Form1 : Form
    {
        private List<Shapes> _shapes = new List<Shapes>();
        public static Shapes _selectShape = null;
        private Form2 formDrawShape;
        private Form3 formEditShape;
        private Color previousColorOnSelectShape;
        private int countOrder = 1;
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var shape in _shapes.OrderByDescending(o => o.Order))
            {
                shape.Paint(e.Graphics);
            }
           drawEditShape(); 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblinformation.Text = "Choose an option!";
            hideOptionsWhenSelectShapeNotClicked();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDraw_Click(object sender, EventArgs e)
        {
            lblinformation.Text = "Click in the box to create the shape";
            btnDraw.IsAccessible = true ;
            btnMove.IsAccessible=false;
            btnSelect.IsAccessible = false;
            hideOptionsWhenSelectShapeNotClicked();
            backPreviousColorOnOneSelectShape();
            openDrawFormOption();
        }
        private void btnMove_Click(object sender, EventArgs e)
        {
            lblinformation.Text = "Move shape - Drag and drop";
            btnDraw.IsAccessible = false;
            btnMove.IsAccessible = true;
            btnSelect.IsAccessible = false;
            hideOptionsWhenSelectShapeNotClicked();
            backPreviousColorOnOneSelectShape();
        } 
        private void btnRemove_Click(object sender, EventArgs e)
        {
            btnDraw.IsAccessible = false;
            btnMove.IsAccessible = false;
            btnSelect.IsAccessible = true;
            removeSelectshapeFromList();
            pictureBox1.Invalidate();
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            lblinformation.Text = "Click on the shape to select";
            _selectShape = null;
            btnSelect.IsAccessible = true;
            btnMove.IsAccessible = false;
            btnDraw.IsAccessible = false;
            showOptionsWhenSelectShapeISClicked();
        } 
        private void btnSP_Click(object sender, EventArgs e)
        {
            btnSelect.IsAccessible = true;
            btnDraw.IsAccessible = false;
            btnMove.IsAccessible = false;
            dispayAreaAndPerimetar();
        } 
        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnDraw.IsAccessible = false;
            btnMove.IsAccessible = false;
            btnEdit.IsAccessible = true;
            openEditForm();
            
        }
        private void dispayAreaAndPerimetar()
        {
            if (_selectShape != null && _selectShape.color == Color.Red)
            {
                lblinformation.Text =  "S: " + String.Format("{0:0.##}", _selectShape.calculateArea())+ "mm  " + "P: " + String.Format("{0:0.##}", _selectShape.calculatePerimeter()) + "mm  ";
            }
        }
        private void openEditForm()
        {
            if (_selectShape != null && _selectShape.color == Color.Red)
            {
                formEditShape = new Form3();
                formEditShape.ShowDialog();
            }
        }
        private void openDrawFormOption()
        {
            formDrawShape = new Form2();
            formDrawShape.ShowDialog();
        }
        private void hideOptionsWhenSelectShapeNotClicked()
        {
            btnRemove.Visible = false;
            btnEdit.Visible = false;
            btnSP.Visible = false;
        }
        private void showOptionsWhenSelectShapeISClicked()
        {
            btnRemove.Visible = true;
            btnEdit.Visible = true;
            btnSP.Visible = true;
        }
        private void removeSelectshapeFromList()
        {
            if (_selectShape != null && _shapes.Contains(_selectShape))
            {
                _shapes.Remove(_selectShape);
            }
            _selectShape = null;
        } 
        private void backPreviousColorOnOneSelectShape()
        {
            foreach (var shape in _shapes)
            {
                if (shape.color == Color.Red)
                {
                    shape.color = previousColorOnSelectShape;
                }
            }
        }
        private void setRectanglePropertyPaintAndAddInCollection(object sender, MouseEventArgs e)//Set rectangle property, LINQ
        {
            if (formDrawShape.ISSelectToDrawRectangle == true && e.Button == MouseButtons.Left)  
            {
                try
                {
                    var rectangle = new Rectangle();
                    rectangle.Location = e.Location;
                    rectangle.Width = int.Parse(formDrawShape.sideA);
                    rectangle.Height = int.Parse(formDrawShape.sideB); ;
                    rectangle.color = Color.FromName(formDrawShape.colorSelected);
                    rectangle.Order = _shapes.Select(s => s.Order).OrderBy(o => o).LastOrDefault() + 1;
                    paintShapes(rectangle);
                    _shapes.Add(rectangle);
                    RectangleInsideFrameCorrection(rectangle);
                }
                catch
                {
                    return;
                }
            }
        }
        private void setCirclePropertyPaintAndAddInCollection(object sender, MouseEventArgs e)//Set circle property, order set with linq
        {
            if (formDrawShape.IsSelectToDrawCircle == true && e.Button == MouseButtons.Left)
            {
                try
                {
                    var circle = new Circle();
                    circle.Location = e.Location;
                    circle.diameter = int.Parse(formDrawShape.sideA);
                    circle.color = Color.FromName(formDrawShape.colorSelected);
                    circle.Order = _shapes.Select(s => s.Order).OrderBy(o => o).LastOrDefault() + 1;
                    paintShapes(circle);
                    _shapes.Add(circle);
                    CircleInsideFrameCorrection(circle);
                }
                catch
                {
                    return;
                }
            }
        }
        private void setTrianglePropertyPaintAndAddInCollection(object sender, MouseEventArgs e)
        {
            if (formDrawShape.IsSelectToDrawTriangle == true && e.Button == MouseButtons.Left) //Set triangle property
            {
                try
                {
                    var triangle = new Triangle();
                    triangle.Location = e.Location;
                    triangle.sideA = int.Parse(formDrawShape.sideA);
                    triangle.sideB = int.Parse(formDrawShape.sideB);
                    triangle.sideC = int.Parse(formDrawShape.sideC);
                    triangle.color = Color.FromName(formDrawShape.colorSelected);
                    triangle.Order = _shapes.Select(s => s.Order).OrderBy(o => o).LastOrDefault() + 1;
                    paintShapes(triangle);
                    _shapes.Add(triangle);
                    TrinagleInsideFrameCorrection(triangle);
                }
                catch
                {
                    return;
                }
            }
        }
        private void paintShapes(Shapes shape)
        {
            using (var graphics = pictureBox1.CreateGraphics())
            {
                shape.Paint(graphics);
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) // use linq for selsctshape
        {
            if (formDrawShape != null && btnDraw.IsAccessible == true )
            {
                
                
             
              setRectanglePropertyPaintAndAddInCollection(sender, e);
                setCirclePropertyPaintAndAddInCollection(sender, e);
                setTrianglePropertyPaintAndAddInCollection(sender, e);
            }
            _selectShape = _shapes.OrderByDescending(o => o.Order).Where(shape => shape.Conteins(e.Location)).LastOrDefault();

            if (_selectShape != null)
            {
                makeSelectShapeFront();
            }
        }
        private void RectangleInsideFrameCorrection(Shapes rectangle)
        {
            if (rectangle.GetType() == typeof(Rectangle))
            {
                if (rectangle.Location.X <= 0)
                {
                    rectangle.Location = new Point(0, rectangle.Location.Y);
                }
                if (rectangle.Location.Y <= 0)
                {
                    rectangle.Location = new Point(rectangle.Location.X, 0);
                }
                if (((Rectangle)rectangle).Width + ((Rectangle)rectangle).Location.X >= pictureBox1.Width)
                {
                    rectangle.Location = new Point(pictureBox1.Width - ((Rectangle)rectangle).Width, rectangle.Location.Y);
                }
                if (((Rectangle)rectangle).Height + rectangle.Location.Y >= pictureBox1.Height)
                {
                    rectangle.Location = new Point(rectangle.Location.X, pictureBox1.Height - ((Rectangle)rectangle).Height);
                }
            }
        }
        private void CircleInsideFrameCorrection(Shapes circle)
        {
            if (circle.GetType() == typeof(Circle))
            {
                if (circle.Location.X <= 0)
                {
                    circle.Location = new Point(0, circle.Location.Y);
                }
                if (circle.Location.Y <= 0)
                {
                    circle.Location = new Point(circle.Location.X, 0);
                }
                if (((Circle)circle).diameter + ((Circle)circle).Location.X >= pictureBox1.Width)
                {
                    circle.Location = new Point(pictureBox1.Width - ((Circle)circle).diameter, circle.Location.Y);
                }
                if (((Circle)circle).diameter + circle.Location.Y >= pictureBox1.Height)
                {
                    circle.Location = new Point(circle.Location.X, pictureBox1.Height - ((Circle)circle).diameter);
                }
            }  
        }
        private void TrinagleInsideFrameCorrection(Shapes triangle)
        {
            if (triangle.GetType() == typeof(Triangle))
            {
                if (((Triangle)triangle).sideA > ((Triangle)triangle).sideB && ((Triangle)triangle).sideA > ((Triangle)triangle).sideC)
                {
                    if (((Triangle)triangle).pointCcordination().X < 0)
                    {
                        triangle.Location = new Point(triangle.Location.X - ((Triangle)triangle).pointCcordination().X, triangle.Location.Y);
                    }
                }
                else if (((Triangle)triangle).sideB > ((Triangle)triangle).sideA && ((Triangle)triangle).sideB > ((Triangle)triangle).sideC)
                {
                    if (((Triangle)triangle).pointCcordination().X > pictureBox1.Width)
                    {
                        triangle.Location = new Point(pictureBox1.Width - (int)triangleCalculateAh(triangle), triangle.Location.Y);
                    }
                }
                if (triangle.Location.X <= 0)
                {
                    triangle.Location = new Point(0, triangle.Location.Y);
                }
                if (((Triangle)triangle).pointCcordination().Y < 0)
                {
                    triangle.Location = new Point(triangle.Location.X, triangle.Location.Y - ((Triangle)triangle).pointCcordination().Y);
                }
                if (((Triangle)triangle).sideC + ((Triangle)triangle).Location.X >= pictureBox1.Width)
                {
                    triangle.Location = new Point(pictureBox1.Width - ((Triangle)triangle).sideC, triangle.Location.Y);
                }
                if (triangle.Location.Y > pictureBox1.Height)
                {
                    triangle.Location = new Point(triangle.Location.X, pictureBox1.Height);
                }
            }
        }
        private double triangleCalculateAh(Shapes triangle)
        {
            double cosd = (Math.Pow(((Triangle)triangle).sideB, 2) + Math.Pow(((Triangle)triangle).sideC, 2) - Math.Pow(((Triangle)triangle).sideA, 2)) / (2 * ((Triangle)triangle).sideB * ((Triangle)triangle).sideC);
            double ah = cosd * ((Triangle)triangle).sideB;
            return ah;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
            {
            if (e.Button == MouseButtons.Left && _selectShape!=null && btnMove.IsAccessible )
            {
                using (var graphics = pictureBox1.CreateGraphics())
                 {
                        _selectShape.Location = e.Location;
                    _selectShape.Paint(graphics);
                 }
                    RectangleInsideFrameCorrection(_selectShape);
                    CircleInsideFrameCorrection(_selectShape);
                    TrinagleInsideFrameCorrection(_selectShape);
            }
            pictureBox1.Invalidate();
        }
        private void makeSelectShapeFront() // use max order linq
        {
            foreach (var shape in _shapes.OrderByDescending(o=>o.Order))
            {
                if (shape.Order == _selectShape.Order)
                {
                  _selectShape.Order = _shapes.Max(o=>o.Order)-countOrder;
                }
                else
                {
                    countOrder++;
                }   
            }
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)//selecting shapes//
        {
            if (e.Button == MouseButtons.Left && _selectShape != null && btnSelect.IsAccessible)
            {
                backPreviousColorOnOneSelectShape();
                previousColorOnSelectShape = _selectShape.color;
                using (var graphics = pictureBox1.CreateGraphics())
                {
                        _selectShape.color = Color.Red;
                        _selectShape.Paint(graphics);
                }
            }
            typeofShapeSelected();
        }
        private void setNewEditPropertyCircle()//diameter and color if user whant Paint
        {
            if (_selectShape.GetType() == typeof(Circle) )
            {
                try
                {
                    ((Circle)_selectShape).diameter = int.Parse(formEditShape.newSide1);
                    setNewColorIfUserWhantOrBackPreviusWhenEditShape(_selectShape);
                    paintShapes(_selectShape);
                }
                catch
                {
                    return;
                }
            } 
        }
        private void setNewEditPropertyRectangle()
        {
            if (_selectShape.GetType() == typeof(Rectangle))
            {
                try
                {
                    ((Rectangle)_selectShape).Width = int.Parse(formEditShape.newSide1);
                    ((Rectangle)_selectShape).Height = int.Parse(formEditShape.newSide2);
                    setNewColorIfUserWhantOrBackPreviusWhenEditShape(_selectShape);
                    paintShapes(_selectShape);
                }
                catch
                {
                    return;
                }
            }
        }
        private void setNewEditPropertyTriangle()
        {
            if (_selectShape.GetType() == typeof(Triangle))
            {
                try
                {
                    ((Triangle)_selectShape).sideA = int.Parse(formEditShape.newSide1);
                    ((Triangle)_selectShape).sideB = int.Parse(formEditShape.newSide2);
                    ((Triangle)_selectShape).sideC = int.Parse(formEditShape.newSide3);
                    setNewColorIfUserWhantOrBackPreviusWhenEditShape(_selectShape);
                    paintShapes(_selectShape);
                }
                catch
                {
                    return;
                }
            }
        }
        private void setNewColorIfUserWhantOrBackPreviusWhenEditShape(Shapes shape)
        {
            if (formEditShape.colorSelected() == null)
            {
                shape.color = _selectShape.color;
            }
            else
            {
                shape.color = Color.FromName(formEditShape.colorSelected());
            }
        }
        private void drawEditShape()
        {
            if (_selectShape != null && formEditShape != null && btnEdit.IsAccessible && btnSelect.IsAccessible)
            {
                setNewEditPropertyCircle();
                setNewEditPropertyRectangle();
                setNewEditPropertyTriangle();
                btnEdit.IsAccessible = false;
            }
        }
        public string typeofShapeSelected()
        {
            if (_selectShape != null)
            {
                return _selectShape.GetType().Name.ToString();
            }
            return null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var binFormatter = new BinaryFormatter();
                using (var filestream = new FileStream(Path.GetFullPath(saveFileDialog.FileName), FileMode.Create, FileAccess.Write))
                {
                    binFormatter.Serialize(filestream, _shapes);
                }
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var binFormatter = new BinaryFormatter();
                    using (var filestream = new FileStream(Path.GetFullPath(openFileDialog1.FileName), FileMode.Open, FileAccess.Read))
                    {
                        _shapes = (List<Shapes>)binFormatter.Deserialize(filestream);
                    }
                }
                catch
                {
                    MessageBox.Show("File error, please looad new file", "Error");
                }
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
 }
