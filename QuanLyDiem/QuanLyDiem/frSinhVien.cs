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
            // TODO: This line of code loads data into the 'quanLyDiemDataSet.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.quanLyDiemDataSet.Lop);
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
    }
}
