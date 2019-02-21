using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiem.Entity;

namespace QuanLyDiem
{
    public partial class frmBangDiemCT : Form
    {
        public frmBangDiemCT()
        {
            InitializeComponent();
        }
        QLDDataContext dt = new QLDDataContext();
        XuLy xl = new XuLy();
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

        private void treeViewSV_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            foreach (var r in dt.SinhvienSelectID(e.Node.Name))
            {
                lblMaSv.Text = e.Node.Name;
                lblTensv.Text = r.TenSV;
                lblNgaysinh.Text = r.NgaySinh.ToString();
                lblNoisinh.Text = r.Diachi;
                if (r.GioiTinh.ToString() == "1")
                {
                    lblGioitinh.Text = "Nữ";
                }
                else
                    lblGioitinh.Text = "Nam";
                lbldantoc.Text = r.DanToc;
            }
            var table = new DataTable();
            DataColumnCollection col = table.Columns;
            if (!col.Contains("MaMon"))
                table.Columns.Add("MaMon", typeof(String));
            if (!col.Contains("TenMon"))
                table.Columns.Add("TenMon", typeof(String));
            if (!col.Contains("SoTC"))
                table.Columns.Add("SoTC", typeof(String));
            if (!col.Contains("Diem"))
                table.Columns.Add("Diem", typeof(String));
            if (!col.Contains("DiemChu"))
                table.Columns.Add("DiemChu", typeof(String));
            if (!col.Contains("DiemSo"))
                table.Columns.Add("DiemSo", typeof(String));
            double tong = 0;
            int sotinchi = 0;
            foreach (var m in dt.GetMonHoc())
            {
                DataRow r = table.NewRow();
                r["MaMon"] = m.MaMon;
                r["TenMon"] = m.TenMon;
                r["SoTC"] = m.SoTC;
                sotinchi += Convert.ToInt32(m.SoTC);
                foreach (var d in dt.DiemHPSearch(m.MaMon, e.Node.Name))
                {
                    if (d.DiemHS2 == null)
                    {
                        r["Diem"] = d.DiemHS1;
                        r["DiemChu"] = xl.diemchu(Convert.ToDouble(d.DiemHS1));
                        r["DiemSo"] = xl.diemso(Convert.ToDouble(d.DiemHS1));
                        tong += xl.diemso(Convert.ToDouble(d.DiemHS1))
                            * Convert.ToDouble(m.SoTC);
                    }
                    else
                    {
                        r["Diem"] = d.DiemHS2;
                        r["DiemChu"] = xl.diemchu(Convert.ToDouble(d.DiemHS2));
                        r["DiemSo"] = xl.diemso(Convert.ToDouble(d.DiemHS2));
                        tong += xl.diemso(Convert.ToDouble(d.DiemHS2))
                            * Convert.ToDouble(m.SoTC);
                    }
                }
                table.Rows.Add(r);
            }//mon hp
            double t = Math.Round(tong / sotinchi, 2);
            lblTB.Text = t.ToString();
            lblXL.Text = xl.XL(t);
            dtgBangdiem.DataSource = table;
        }
    
        //

    }
}
