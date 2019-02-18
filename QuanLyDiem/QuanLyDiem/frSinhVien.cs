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
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyDiemDataSet2.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter2.Fill(this.quanLyDiemDataSet2.Lop);
            //// TODO: This line of code loads data into the 'quanLyDiemDataSet1.Lop' table. You can move, or remove it, as needed.
            //this.lopTableAdapter1.Fill(this.quanLyDiemDataSet1.Lop);
            //// TODO: This line of code loads data into the 'quanLyDiemDataSet.Lop' table. You can move, or remove it, as needed.
            //this.lopTableAdapter.Fill(this.quanLyDiemDataSet.Lop);

            LoadData();
        }
        private void LoadData()
        {
            Connection connection = new Connection();
            dataGridViewSinhVien.DataSource = connection.GetStudentInfo();
            dataGridViewSinhVien.Columns[0].Visible = false;
            lbStatus.Text = string.Format("Có {0} sinh viên", dataGridViewSinhVien.Rows.Count - 1);
        }
        int id;

        private void dataGridViewSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if ((e.RowIndex < 0) || (e.RowIndex >= dataGridViewSinhVien.RowCount - 1))
            {
                return;
            }
            id = int.Parse(dataGridViewSinhVien.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtTensv.Text = dataGridViewSinhVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtNgaySinh.Text = dataGridViewSinhVien.Rows[e.RowIndex].Cells[2].Value.ToString();
            rdNam.Checked = bool.Parse(dataGridViewSinhVien.Rows[e.RowIndex].Cells[3].Value.ToString());
            rdNu.Checked = !rdNam.Checked;
            rdDiachi.Text = dataGridViewSinhVien.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtdantoc.Text = dataGridViewSinhVien.Rows[e.RowIndex].Cells[5].Value.ToString();
            cblop.Text = dataGridViewSinhVien.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void Clear()
        {
            txtTensv.Text = "";
            txtdantoc.Text = "";
            txtTK.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTensv.Text == "")
            {
                errorProvider1.SetError(txtTensv, "Tên sinh viên không được để trống");
                return;
            }
            if (txtdantoc.Text == "")
            {
                errorProvider1.SetError(txtdantoc, "Dân tộc không được đê trống");
                return;
            }
            if (rdDiachi.Text == "")
            {
                errorProvider1.SetError(rdDiachi, "Quê quán không được để trống");
                return;
            }

            SinhVien sv = new SinhVien();
            sv.TenSV = txtTensv.Text;
            sv.GioiTinh = rdNam.Checked;
            sv.Ngaysinh = dtNgaySinh.Text;
            sv.lop = cblop.SelectedValue.ToString();
            sv.Dantoc = txtdantoc.Text;
            sv.Diachi = rdDiachi.Text;

            Connection con = new Connection();
            bool IsInserted = con.InsertStudent(sv);
            if (IsInserted == true)
            {
                Clear();
                LoadData();
                MessageBox.Show("Thêm sinh viên thành công");
            }
            else
            {
                MessageBox.Show("Không thêm sinh viên được");
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.ShowDialog();
        }

        private void txtTensv_TextChanged(object sender, EventArgs e)
        {
            if (txtTensv.Text == "")
            {
                errorProvider1.SetError(txtTensv, "Tên sinh viên không được để trống");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtdantoc_TextChanged(object sender, EventArgs e)
        {
            if (txtTensv.Text == "")
            {
                errorProvider1.SetError(txtdantoc, "Tên sinh viên không được để trống");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void rdDiachi_TextChanged(object sender, EventArgs e)
        {
            if (txtTensv.Text == "")
            {
                errorProvider1.SetError(rdDiachi, "Tên sinh viên không được để trống");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTensv.Text == "")
            {
                errorProvider1.SetError(txtTensv, "Tên sinh viên không được để trống");
                return;
            }
            if (txtdantoc.Text == "")
            {
                errorProvider1.SetError(txtdantoc, "Dân tộc không được để trống");
                return;
            }
            if (rdDiachi.Text == "")
            {
                errorProvider1.SetError(rdDiachi, "Địa chỉ không được để trống");
                return;
            }


            SinhVien sv = new SinhVien();
            sv.TenSV = txtTensv.Text;
            sv.GioiTinh = rdNam.Checked;
            sv.Ngaysinh = dtNgaySinh.Text;
            sv.lop = cblop.SelectedValue.ToString();
            sv.Dantoc = txtdantoc.Text;
            sv.Diachi = rdDiachi.Text;

            Connection con = new Connection();
            bool isUpdate = con.UpdateStudent(sv, id);
            if (isUpdate == true)
            {
                Clear();
                LoadData();
                MessageBox.Show("Sửa sinh viên thành công");
            }
            else
            {
                MessageBox.Show("Không sửa được sinh viên");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (id < 0)
            {
                return;
            }
            if (MessageBox.Show("Bạn chắc chắn muốn xóa ?", "Nhắc nhở", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question) == DialogResult.OK)
            {
                Connection con = new Connection();
                bool IsDelete = con.DeleteStudent(id);
                if (IsDelete == true)
                {
                    Clear();
                    LoadData();
                    MessageBox.Show("Xóa sinh viên thành công");
                }
                else
                {
                    MessageBox.Show("Không xóa được");
                }
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            dataGridViewSinhVien.DataSource = cn.Search(txtTK.Text.Trim());
        }
    }
}
