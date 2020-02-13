using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool addButton = false;
        bool subtractButton = false;
        bool multiplyButton = false;
        bool divideButton = false;

        double total1 = 0;
        double total2 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            txtBox.Text += btn1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox.Clear();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtBox.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtBox.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtBox.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtBox.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtBox.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtBox.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtBox.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtBox.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtBox.Text += btn0.Text;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtBox.Text += btnDot.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtBox.Text);
            txtBox.Clear();

            addButton = true;
            subtractButton = false;
            multiplyButton = false;
            divideButton = false;
  
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            total1 = double.Parse(txtBox.Text) - total1;
            txtBox.Clear();

            addButton = false;
            subtractButton = true;
            multiplyButton = false;
            divideButton = false;

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            total1 =  double.Parse(txtBox.Text);
            txtBox.Clear();

            addButton = false;
            subtractButton = false;
            multiplyButton = true;
            divideButton = false;
         
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            total1 = double.Parse(txtBox.Text) ;
            txtBox.Clear();

            addButton = false;
            subtractButton = false;
            multiplyButton = false;
            divideButton = true;
   
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            if (addButton)
            {
                total2 = total1 + double.Parse(txtBox.Text);
            }
            else if (subtractButton)
            {
                total2 = total1 - double.Parse(txtBox.Text);
            }
            else if (multiplyButton)
            {
                total2 = (total1 * double.Parse(txtBox.Text));
            }
            else if (divideButton)
            {
                total2 = total1 / double.Parse(txtBox.Text);
            }

            txtBox.Text = total2.ToString();
            total1 = 0;

        }
    }
}
