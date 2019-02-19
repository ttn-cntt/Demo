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
            cbLop.DataSource = dt.LopAll();
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";
            cbhocky.DataSource = dt.HocKyAll();
            cbhocky.ValueMember = "MaHK";
            cbhocky.DisplayMember = "TenHK";
            txtmahk.DataBindings.Clear();
            txtmahk.DataBindings.Add("Text", cbhocky.DataSource, "MaHK");
            txttenhk.DataBindings.Clear();
            txttenhk.DataBindings.Add("Text", cbhocky.DataSource, "TenHK");
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
                dt.InsertHK1(txtmahk.Text,txttenhk.Text);
                txtmahk.Enabled = false;
                adhk = false;
                frmdiem_Load(sender,e);
                
            }
            else
            {
                dt.UpdateHK(txtmahk.Text,txttenhk.Text);
                frmdiem_Load(sender, e);
            }
        }

        private void btnxoahk_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa ?", "Nhắc nhở", MessageBoxButtons.OKCancel,
           MessageBoxIcon.Question) == DialogResult.OK)
            {
                dt.DeleteHK(txtmahk.Text);
                frmdiem_Load(sender, e);
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Không xóa được");
            }
        }
    }
}
