using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathForDumies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textNo1.ResetText();
            this.textNo2.ResetText();
            this.textResult.ResetText();
            this.textNo1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.textNo2.Text == "0") {
                MessageBox.Show("Can not devide by zero", "Alert");
                this.textNo2.ResetText();
                this.textNo2.Focus();
            } 
            else
                this.textResult.Text = (Int32.Parse(this.textNo1.Text) / Int32.Parse(this.textNo2.Text)).ToString();    

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            this.textResult.Text = (Int32.Parse(this.textNo1.Text) + Int32.Parse(this.textNo2.Text)).ToString();    
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            this.textResult.Text = (Int32.Parse(this.textNo1.Text) - Int32.Parse(this.textNo2.Text)).ToString();    

        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            this.textResult.Text = (Int32.Parse(this.textNo1.Text) * Int32.Parse(this.textNo2.Text)).ToString();    

        }
    }
}
