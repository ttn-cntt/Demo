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
namespace QuanLyDiem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(tb==DialogResult.OK)
            Application.Exit();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            SqlConnection conn =new SqlConnection(@"Data Source=DESKTOP-M4FC1D7\SQLEXPRESS;Initial Catalog=QuanLyDiem;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtUser.Text;
                string mk = txtpass.Text;
                string sql = "select * from DangNhap where username='"+tk+"' and password= '"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    this.Hide();
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }
    }
}
