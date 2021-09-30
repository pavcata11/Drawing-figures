using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawinShapes
{
    public partial class Form3 : Form
    { 
        Form2 FormEdit;
        Form1 FormScene;
       
        public Form3()
        {
            InitializeComponent();
        }
        public string colorSelected()
        {
          if (listColor.SelectedItem!=null)
                return listColor.SelectedItem.ToString();
            return null;
            
        }
        public string newSide1
        {
            get
            {
                return txtA.Text;
            }
        }
        public string newSide2
        {
            get
            {
                return txtB.Text;
            }
        }
        public string newSide3
        {
            get
            {
                return txtC.Text;
            }
        }

        private void displayOrHideOptions()// use from form1 to check who shape selected and fro form2 to set fields
        {
            FormScene = new Form1();
            FormEdit = new Form2();
            if (FormScene.typeofShapeSelected() == typeof(Rectangle).Name.ToString()) 
            {
                FormEdit.ShowAndHideFieldsRectangle(txtA, txtB, txtC, label2, label3, label4);
            }
            if (FormScene.typeofShapeSelected() == typeof(Circle).Name.ToString())
            {
                FormEdit.ShowAndHideFieldsCircle(txtA, txtB, txtC, label2, label3, label4);
            }
            if (FormScene.typeofShapeSelected() == typeof(Triangle).Name.ToString())
            {
                FormEdit.ShowAndHideFieldsTriangle(txtA, txtB, txtC, label2, label3, label4);
            }
        }
        private void checkedSideIsCorectlyInput()// if ok input, close form 
        {
            FormEdit = new Form2();
            FormScene = new Form1();
            if (FormScene.typeofShapeSelected() == typeof(Circle).Name.ToString() && FormEdit.isValidateSidesViewMessageWhenNoValidateCorectly(txtA.Text))
            {
                this.Close();
               
            }
            else if ( FormScene.typeofShapeSelected() == typeof(Rectangle).Name.ToString()&& FormEdit.isValidateSidesViewMessageWhenNoValidateCorectly(txtA.Text) && FormEdit.isValidateSidesViewMessageWhenNoValidateCorectly(txtB.Text))
            {
               this.Close();
            }
            else  if (FormScene.typeofShapeSelected() == typeof(Triangle).Name.ToString() && FormEdit.isValidateSidesViewMessageWhenNoValidateCorectly(txtA.Text) && FormEdit.isValidateSidesViewMessageWhenNoValidateCorectly(txtB.Text) && FormEdit.isValidateSidesViewMessageWhenNoValidateCorectly(txtC.Text))
            {
                if (FormEdit.isValidityTriangleIfNovalidateViewMessageError(int.Parse(txtA.Text), int.Parse(txtB.Text), int.Parse(txtC.Text)))
                {
                    this.Close();
                }
                else
                {
                    FormEdit.clearFields(txtA, txtB, txtC);
                }
            }
            else
            {
                FormEdit.clearFields(txtA, txtB, txtC);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            displayOrHideOptions();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            checkedSideIsCorectlyInput();  
        }
    }
}
