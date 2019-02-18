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
            //txtmahk.DataBindings.Clear();
            //txtmahk.DataBindings.Add("Text",cbhocky.DataSource,"MaHK");
            txttenhk.DataBindings.Clear();
            txttenhk.DataBindings.Add("Text", cbhocky.DataSource, "TenHK");
        }
        Boolean adhk = false;

        private void btnthemhk_Click(object sender, EventArgs e)
        {
            txttenmon.Text = "";
            adhk = true;

            if (adhk)
            {
                dt.InsertHK(txttenhk.Text);
                adhk = false;
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Không thêm được");
            }
        }
    }
}
