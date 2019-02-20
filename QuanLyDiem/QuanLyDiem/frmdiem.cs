using QuanLyDiem.data;
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
    public partial class frmdiem : Form
    {
        public frmdiem()
        {
            InitializeComponent();
        }
        QLDDataContext dt = new QLDDataContext();
        private void frmdiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyDiemDataSet2.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.quanLyDiemDataSet2.Lop);
            cbLop.DataSource = dt.LopAll1();
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";
            cbhocky.DataSource = dt.HocKyAll1();
            cbhocky.ValueMember = "MaHK";
            cbhocky.DisplayMember = "TenHK";
            txtmahk.DataBindings.Clear();
            txtmahk.DataBindings.Add("Text", cbhocky.DataSource, "MaHK");
            txttenhk.DataBindings.Clear();
            txttenhk.DataBindings.Add("Text", cbhocky.DataSource, "TenHK");

            //môn học
            cbmonhoc.DataSource = dt.GetMonHoc();
            cbmonhoc.DisplayMember = "TenMon";
            cbmonhoc.ValueMember = "MaMon";
           
            txtmamon.DataBindings.Clear();
            txtmamon.DataBindings.Add("Text", cbmonhoc.DataSource, "MaMon");
            txttenmon.DataBindings.Clear();
            txttenmon.DataBindings.Add("Text", cbmonhoc.DataSource, "TenMon");
            txtsoTC.DataBindings.Clear();
            txtsoTC.DataBindings.Add("Text", cbmonhoc.DataSource, "SoTC");
        }
        Boolean adhk = false;

        private void btnthemhk_Click(object sender, EventArgs e)
        {
            txtmahk.Text = "";
            txttenhk.Text = "";
            txtmahk.Enabled = true;
            txtmahk.Focus();
            adhk = true;
           
        }

        private void btnsuahk_Click(object sender, EventArgs e)
        {
            if (adhk)
            {
                dt.InsertHK2(txtmahk.Text,txttenhk.Text);
                txtmahk.Enabled = false;
                adhk = false;
                frmdiem_Load(sender,e);
                
            }
            else
            {
                dt.UpdateHK1(txtmahk.Text,txttenhk.Text);
                frmdiem_Load(sender, e);
            }
        }

        private void btnxoahk_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa ?", "Nhắc nhở", MessageBoxButtons.OKCancel,
           MessageBoxIcon.Question) == DialogResult.OK)
            {
                dt.DeleteHK1(txtmahk.Text);
                frmdiem_Load(sender, e);
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Không xóa được");
            }
        }

        private void btnthemmon_Click(object sender, EventArgs e)
        {
            txtmamon.Text = "";
            txttenmon.Text = "";
            txtsoTC.Text = "";
            txtmamon.Enabled = true;
            txtmamon.Focus();
            adhk = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.ShowDialog();
        }

        private void btnxoamon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa ?", "Nhắc nhở", MessageBoxButtons.OKCancel,
          MessageBoxIcon.Question) == DialogResult.OK)
            {
                dt.XoaMonHoc(txtmamon.Text);
                frmdiem_Load(sender, e);
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Không xóa được");
            }
        }

        private void btnluumon_Click(object sender, EventArgs e)
        {

        }
    }
}
