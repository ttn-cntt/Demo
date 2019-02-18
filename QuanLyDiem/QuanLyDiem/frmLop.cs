using QuanLyDiem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            Connection connection = new Connection();
            dataLop.DataSource = connection.GetLop();
            dataLop.Columns[0].Visible = false;


        }
        int id;
        private void dataLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex < 0) || (e.RowIndex >= dataLop.RowCount - 1))
            {
                return;
            }
            id = int.Parse(dataLop.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtTenLop.Text = dataLop.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void Clear()
        {
            txtTenLop.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTenLop.Text == "")
            {
                //lỗi
                errorProvider1.SetError(txtTenLop, "tên lớp không được để trống");
                return;
            }
            Class l = new Class();
            l.tenLop = txtTenLop.Text;
            Connection con = new Connection();
            bool IsInserted = con.ThemLop(l);
            if (IsInserted == true)
            {
                //xóa dữ liệu ở các trường
                Clear();
                LoadData();
                MessageBox.Show("Thêm lớp thành công");
            }
            else
            {
                MessageBox.Show("Thêm lớp thất bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtTenLop.Text == "")
            {
                //lỗi
                errorProvider1.SetError(txtTenLop, "tên lớp không được để trống");
                return;
            }
            Class l = new Class();
            l.tenLop = txtTenLop.Text;
            Connection con = new Connection();
            bool isUpdate = con.SuaLop(l, id);
            if (isUpdate == true)
            {
                //xóa dữ liệu ở các trường
                Clear();
                LoadData();
                MessageBox.Show("Sửa lớp thành công");
            }
            else
            {
                MessageBox.Show("Sửa lớp thất bại");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
