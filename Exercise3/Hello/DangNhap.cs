using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string thongbao = "";
            thongbao += "Ten dang nhap la: ";
            thongbao += this.textUser.Text;
            thongbao += "\n\rMat khau la: ";
            thongbao += this.textPass.Text;
            if (this.chkRemem.Checked == true)
                thongbao += "\n\rBan co ghi nho tai khoan";
            MessageBox.Show(thongbao, "Tiêu đề", MessageBoxButtons.OKCancel, MessageBoxIcon.Information); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textPass.ResetText();
            this.textUser.ResetText();
            this.textUser.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Using dialog for ending process
            DialogResult answer;
            answer = MessageBox.Show("Are you sure ?? ", "Answer",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(answer == DialogResult.OK) 
                Application.Exit();
        }
    }
}
