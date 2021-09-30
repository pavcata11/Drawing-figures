using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawinShapes
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            
        }
      
        public void ShowAndHideFieldsRectangle(TextBox sidea, TextBox sideb, TextBox sidec,Label lbla,Label lblb, Label lblc )
        {
            sidea.Visible = true;
            sideb.Visible = true;
            sidec.Visible = false;
            lbla.Text = "A:";
            lbla.Visible = true;
            lblb.Visible = true;
            lblc.Visible = false;
        }
        public void ShowAndHideFieldsCircle(TextBox sidea, TextBox sideb, TextBox sidec, Label lbla, Label lblb, Label lblc)
        {
            sidea.Enabled = true;
            sideb.Visible = false;
            sidec.Visible = false;
            lbla.Text = "D:";
            lbla.Visible = true;
            lblb.Visible = false;
            lblc.Visible = false;
        }
        public void ShowAndHideFieldsTriangle(TextBox sidea, TextBox sideb, TextBox sidec, Label lbla, Label lblb, Label lblc)
        {
            sidea.Visible = true;
            sideb.Visible = true;
            sidec.Visible = true;
            lbla.Text = "A:";
            lbla.Visible = true;
            lblb.Visible = true;
            lblc.Visible = true;
        }

        private void radiobtnRectangle_CheckedChanged(object sender, EventArgs e)
        {
            ShowAndHideFieldsRectangle(txtSideA,txtSideB,txtSideC,lblA,lblB,lblC);
        }
        private void radioBtnCircle_CheckedChanged(object sender, EventArgs e)
        {
            ShowAndHideFieldsCircle(txtSideA, txtSideB, txtSideC, lblA, lblB, lblC);
        }

        private void radioBtnTriangle_CheckedChanged(object sender, EventArgs e)
        {
            ShowAndHideFieldsTriangle(txtSideA, txtSideB, txtSideC, lblA, lblB, lblC);
        }
        public string sideA
        {
            get
            {
                return txtSideA.Text;
            }
        }

        public string sideB
        {
            get
            {
                return txtSideB.Text;
            }
        }
        public string sideC
        {
            get
            {
                return txtSideC.Text;
            }
        }
        public bool ISSelectToDrawRectangle
        {
            get
            {
                return radiobtnRectangle.Checked;
            }

        }
        public bool IsSelectToDrawCircle
        {
            get
            {
                return radioBtnCircle.Checked;
            }
        }

        public bool IsSelectToDrawTriangle
        {
            get
            {
                return radioBtnTriangle.Checked;
            }
        }
        public string colorSelected
        {
            get
            {
                return listColor.SelectedItem.ToString();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbljustNumber.Visible = true ;
        }
      
        private void btnDraw_Click(object sender, EventArgs e)
        {
          
            if (radioBtnCircle.Checked && isValidateSidesViewMessageWhenNoValidateCorectly(txtSideA.Text) && listColor.SelectedItem != null)
            {
                this.Close();
            }
            else if (radiobtnRectangle.Checked && isValidateSidesViewMessageWhenNoValidateCorectly(txtSideA.Text) && isValidateSidesViewMessageWhenNoValidateCorectly(txtSideB.Text) && listColor.SelectedItem != null)
            {
                this.Close();
            }
            else if (radioBtnTriangle.Checked && isValidateSidesViewMessageWhenNoValidateCorectly(txtSideA.Text) && isValidateSidesViewMessageWhenNoValidateCorectly(txtSideB.Text) && isValidateSidesViewMessageWhenNoValidateCorectly(txtSideC.Text) && listColor.SelectedItem != null)
            {

                if (isValidityTriangleIfNovalidateViewMessageError(int.Parse(txtSideA.Text), int.Parse(txtSideB.Text), int.Parse(txtSideC.Text)))
                {
                    this.Close();
                }
                else
                {
                  
                    clearFields(txtSideA, txtSideB, txtSideC);
                }
            }
            else
            {
                clearFields(txtSideA, txtSideB, txtSideC);
            }
        }

        public void messageTriangleError()
        {
            MessageBox.Show("There is no triangle with such sides", "Error");
        }
        public void messageInvalidInput()
        {
            MessageBox.Show("Invalid input", "Error");
        }
        public void clearFields(TextBox sidea, TextBox sideb, TextBox sidec)
        {
            sidea.Text = "";
            sideb.Text = "";
            sidec.Text = "";
        }
        public bool isValidityTriangleIfNovalidateViewMessageError(int a, int b, int c)
        {
            if (a + b > c && a + c > b && b + c > a)
                return true;
            messageTriangleError();
            return false;
        }
        public  bool isValidateSidesViewMessageWhenNoValidateCorectly(string checkSide)
        {
            int i; char checkFirstNumberIsDifferentZero = checkSide.FirstOrDefault();
            if (int.TryParse(checkSide, out i) && checkFirstNumberIsDifferentZero != '0')
            {
                if (i > 0 && i <= 500)
                    return true;
            }
            messageInvalidInput();
            return false;
        }

        
    }
}
