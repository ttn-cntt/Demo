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
    public partial class frmBangDiemCT : Form
    {
        public frmBangDiemCT()
        {
            InitializeComponent();
        }
        QLDDataContext dt = new QLDDataContext();
        private void frmBangDiemCT_Load(object sender, EventArgs e)
        {
            cbLop.ValueMember = "MaLop";
            cbLop.DisplayMember = "TenLop";
            cbLop.DataSource = dt.LopAll();
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            treeViewSV.Nodes.Clear();
            TreeNode root = new TreeNode();
            root.Text = "Chọn sinh viên: ";
            treeViewSV.Nodes.Add(root);
            foreach(var r in dt.SinhvienSelectMaLop(cbLop.SelectedValue.ToString()))
                {
                TreeNode node = new TreeNode();
                node.Name = r.MaSV;
                node.Text = r.TenSV;
                treeViewSV.Nodes.Add(node);
            }
            treeViewSV.ExpandAll();
        }
    }
}
