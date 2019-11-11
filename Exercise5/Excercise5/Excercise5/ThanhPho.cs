using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
//using System.Data;
namespace Excercise5
{
    public partial class frmThanhPho : Form
    {
        //Chuỗi kết nối
        string strConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=SSPI";

        //Đối tượng kết nối
        SqlConnection conn = null;
        //Đối tượng đưa dữ liệu vào DataTable dtThanhPho = null;
        SqlDataAdapter daThanhPho = null;
        //Đối tượng hiển thị dữ liệu lên Form
        DataTable dtThanhPho = null;
        
        public frmThanhPho()
        {
            InitializeComponent();
        }

        private void frmThanhPho_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtThanhPho.Dispose();
            dtThanhPho = null;
            //huy ket noi
            conn = null;
        }

        private void frmThanhPho_Load(object sender, EventArgs e)
        {
            try
            {
                // Khoi dong ket noi
                conn = new SqlConnection(strConnectionString);
                // mở kết nối
                //Vận chuyển dữ liệu lên DataTable dtThanhPho
                daThanhPho = new SqlDataAdapter("SELECT * FROM ThanhPho", conn);
                dtThanhPho = new DataTable();
                dtThanhPho.Clear();
                daThanhPho.Fill(dtThanhPho);
                //Đưa dữ liệu lên ListBox
                this.lstThanhPho.DataSource = dtThanhPho;
                this.lstThanhPho.DisplayMember = "TenThanhPho";
                this.lstThanhPho.ValueMember = "ThanhPho";
            }
            catch (SqlException)
            {
                MessageBox.Show("Khong lay duoc noi dung trong table ThanhPho, Loi roi !!!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Khai báo biến traloi
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
