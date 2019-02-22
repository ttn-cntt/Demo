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

        private void btnExport_Click(object sender, EventArgs e)
        {
            //Khởi tạo exel
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            //khởi tạo workbook
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //khởi tạo worksheet
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            //đỗ dữ liệu vào sheet
            worksheet.Cells[1, 1] = "BẢNG TỔNG HỢP ĐIỂM CHI TIẾT SINH VIÊN";
            worksheet.Cells[3, 2] = "Mã sinh viên: " + lblMaSv.Text;
            worksheet.Cells[4, 2] = "Họ tên: " + lblTensv.Text;
            worksheet.Cells[5, 2] = "Ngày sinh: " + lblNgaysinh.Text;
            worksheet.Cells[6, 2] = "Giới tinh: " + lblGioitinh.Text;
            worksheet.Cells[7, 2] = "Dân tộc: " + lbldantoc.Text;
            worksheet.Cells[8, 2] = "Quê quán: " + lblNoisinh.Text;
            worksheet.Cells[9, 1] = "STT";
            worksheet.Cells[9, 2] = "Mã môn";
            worksheet.Cells[9, 3] = "Tên môn";
            worksheet.Cells[9, 4] = "Số TC";
            worksheet.Cells[9, 5] = "Điểm HP";
            worksheet.Cells[9, 6] = "Điểm Chữ";
            worksheet.Cells[9, 7] = "Điểm số";
            for(int i=0;i<dtgBangdiem.RowCount-1;i++)
            {
                for(int j=1;j<7;j++)
                {
                    worksheet.Cells[i + 10, 1] = i + 1;
                    worksheet.Cells[i + 10, j+1] = dtgBangdiem.Rows[i].Cells[j+2].Value;
                }
            }
            int mon = dtgBangdiem.RowCount;
            worksheet.Cells[mon + 10, 1] ="Trung bình toàn khóa: " +lblTB.Text;
            worksheet.Cells[mon + 11, 1] ="Xếp loại toàn khóa: " +lblXL.Text;
            //Định dạng trang
            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
            worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            worksheet.PageSetup.LeftMargin = 0;
            worksheet.PageSetup.RightMargin = 0;
            worksheet.PageSetup.TopMargin = 0;
            worksheet.PageSetup.BottomMargin = 0;
            
            //Định dạng cột
            worksheet.Range["A1"].ColumnWidth=5.86;
            worksheet.Range["B1"].ColumnWidth = 9.14;
            worksheet.Range["C1"].ColumnWidth=31.57;
            worksheet.Range["D1"].ColumnWidth = 7.57;
            worksheet.Range["E1"].ColumnWidth = 10.57;
            worksheet.Range["F1"].ColumnWidth = 11.57;
            worksheet.Range["G1"].ColumnWidth = 9.29;
            //Định dàng font chữ
            worksheet.Range["A1", "G100"].Font.Name = "TimeNewRoman";
            worksheet.Range["A1", "G100"].Font.Size = 13;
            worksheet.Range["A1", "G1"].MergeCells = true;
            worksheet.Range["A1", "G1"].Font.Bold = true;
            worksheet.Range["A9", "G9"].Font.Bold = true;
            //Ke bảng điểm
            worksheet.Range["A9", "G" + (mon + 8)].Borders.LineStyle = 1;
            //định dạng các dòng text;
            worksheet.Range["A1", "G1"].HorizontalAlignment = 3;
            worksheet.Range["A9", "G9"].HorizontalAlignment = 3;
            worksheet.Range["A10", "A" + (mon + 8)].HorizontalAlignment = 3;
            worksheet.Range["D10", "D" + (mon + 8)].HorizontalAlignment = 3;
            worksheet.Range["E10", "E" + (mon + 8)].HorizontalAlignment = 3;
            worksheet.Range["F10", "F" + (mon + 8)].HorizontalAlignment = 3;
            worksheet.Range["G10", "G" + (mon + 8)].HorizontalAlignment = 3;
        }
    }
}
