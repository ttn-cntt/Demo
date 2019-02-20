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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void xửLíDữLiệuSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSinhVien sv = new frmSinhVien();
            sv.ShowDialog();
        }

        private void xửLíDữLiệuLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLop l = new frmLop();
            l.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void xửLýDữLiệuHọcKỳMônHọcĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdiem d = new frmdiem();
            d.ShowDialog();
        }

        private void bảngĐiểmChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBangDiemCT d = new frmBangDiemCT();
            d.ShowDialog();
        }
    }
}
