using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhDiem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double toan = Convert.ToDouble(txtToan.Text);
            double van = Convert.ToDouble(txtNV.Text);
            double av = Convert.ToDouble(txtNN.Text);
            double DTN;
            
            
            DTN = toan;
            if (van < DTN) DTN = van;
            else if (av < DTN) DTN = av;
            this.txtDTN.Text = DTN.ToString();

            double DTB;
            DTB = van * 2 + toan * 2 + av;
            if (this.chkMale.Checked == true) DTB += 0.5;
            this.txtDKQ.Text = DTB.ToString();

            String rank = "";
            if ((DTB > 40) && (DTN >= 7)) rank += "Gioi";
            else if ((DTB > 40) && (DTN >= 7)) rank += "Kha";
            else if ((DTB > 40) && (DTN >= 7)) rank += "TB";
            else rank += "Yeu";
            this.txtXL.Text = rank;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            this.txtName.ResetText();
            this.txtNN.ResetText();
            this.txtNV.ResetText();
            this.txtToan.ResetText();
            this.chkFeMale.Checked = false;
            this.chkMale.Checked = false;
            this.txtName.Focus();
        }
    }
}
