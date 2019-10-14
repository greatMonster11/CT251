using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giai_PTB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
                    }

        private void btnRelv_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double c = Convert.ToDouble(txtC.Text);

            String result = "";
            if (a == 0) result += "Phuong trinh bac nhat";
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0) result += "PTVN";
                else if (delta == 0 ) result += "x1 = x2 = " + (-b/(2*a)).ToString() ;
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                    double x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                    result += "x1= " + x1.ToString() + ", x2= " + x2.ToString();
                }
            }

            this.result.Text = result;
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            this.txtA.ResetText();
            this.txtB.ResetText();
            this.txtC.ResetText();
            this.txtA.Focus();
        }
    }
}
