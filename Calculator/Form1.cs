using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        string CalTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn1.Text;//or we can use (txtTotal.Text = txtTotal.Text + "1";)
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn0.Text;
        }

        private void btnpls_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = Convert.ToInt32(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = Convert.ToInt32(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = Convert.ToInt32(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = Convert.ToInt32(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(txtTotal.Text);

            if(option == "+")
            {
                result = num1 + num2;
            }
            if (option == "-")
            {
                result = num1 - num2;
            }
            if (option == "*")
            {
                result = num1 * num2;
            }
            if (option == "/")
            {
                result = num1 / num2;
            }
            txtTotal.Text = result + "" ;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;
        }
    }
}
