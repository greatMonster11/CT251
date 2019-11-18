using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTienDien
{
    public partial class frmTinhTien : Form
    {
        public frmTinhTien()
        {
            InitializeComponent();
            this.labelNote.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double soCu = Convert.ToDouble(this.txtSoCu.Text);
            double soMoi = Convert.ToDouble(this.txtSoMoi.Text);
            double ketqua = 0, dinhmuc = 50;
            double tieudung = soMoi - soCu;

            if (soCu > soMoi) {
                DialogResult traloi;
                traloi = MessageBox.Show("Nhập tào lao ?", "Trả lời", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (traloi == DialogResult.OK)
                {
                    this.txtGiaTien.Clear();
                    this.txtSoMoi.Clear();
                    this.txtSoCu.Clear();
                    this.txtSoCu.Focus();
                }
            }
            else { 
                ketqua = tieudung * 450 + 1;
                this.txtMuc1.Text = (tieudung * 450).ToString();
                this.txtMuc2.Text = "0";
                this.txtMuc3.Text = "0";
                this.txtMuc4.Text = "0";

                if (tieudung >= 50 && tieudung < 100)
                {
                    ketqua = 50 * 450 + (tieudung - dinhmuc) * 700 + 1;
                    this.txtMuc1.Text = (dinhmuc * 450).ToString();
                    this.txtMuc2.Text = ((tieudung - dinhmuc) * 700).ToString();
                    this.txtMuc3.Text = "0";
                    this.txtMuc4.Text = "0";
                }
                if (tieudung >= 100 && tieudung < 150)
                {
                    ketqua = 50 * 450 + 50 * 700 + (tieudung - 100) * 910 + 1;
                    this.txtMuc1.Text = (dinhmuc * 450).ToString(); 
                    this.txtMuc2.Text = (dinhmuc * 700).ToString();
                    this.txtMuc3.Text = (((tieudung - 100) * 910)).ToString();
                    this.txtMuc4.Text = "0";
                }
                if (tieudung >= 150)
                {
                    ketqua = 50 * 450 + 50 * 700 + 50 * 910 + (tieudung - 150) * 1200+ 1;
                    this.txtMuc1.Text = (dinhmuc * 450).ToString();
                    this.txtMuc2.Text = (dinhmuc * 700).ToString();
                    this.txtMuc3.Text = (dinhmuc * 910).ToString();
                    this.txtMuc4.Text = (((tieudung - 150) * 1200)).ToString();
                }

                this.txtGiaTien.Text = ketqua.ToString();
                this.labelNote.Show();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtGiaTien.Clear();
            this.txtSoMoi.Clear();
            this.txtSoCu.Clear();
            this.txtSoCu.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
