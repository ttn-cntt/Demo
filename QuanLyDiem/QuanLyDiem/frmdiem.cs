﻿using QuanLyDiem.data;
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
            //// TODO: This line of code loads data into the 'quanLyDiemDataSet2.Lop' table. You can move, or remove it, as needed.
            //this.lopTableAdapter.Fill(this.quanLyDiemDataSet2.Lop);
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
            txtmahk.Enabled = false;
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
                dt.InsertHK(txtmahk.Text, txttenhk.Text);
                txtmahk.Enabled = false;
                adhk = false;
                frmdiem_Load(sender, e);

            }
            else
            {
                dt.UpdateHK(txtmahk.Text, txttenhk.Text);
                frmdiem_Load(sender, e);
            }
        }

        private void btnxoahk_Click(object sender, EventArgs e)
        {
            dt.DeleteHK(txtmahk.Text);
            frmdiem_Load(sender, e);
        }
        private void cbhocky_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbmonhoc.ValueMember = "MaMon";
            cbmonhoc.DisplayMember = "TenMon";
            cbmonhoc.DataSource = dt.MonHPSelectMK(cbhocky.SelectedValue.ToString());

            txtmamon.DataBindings.Clear();
            txtmamon.DataBindings.Add("Text", cbmonhoc.DataSource, "MaMon");
            txttenmon.DataBindings.Clear();
            txttenmon.DataBindings.Add("Text", cbmonhoc.DataSource, "TenMon");
            txtsoTC.DataBindings.Clear();
            txtsoTC.DataBindings.Add("Text", cbmonhoc.DataSource, "SoTC");
            txtmamon.Enabled = false;
        }
        Boolean adMon = false;
        private void btnthemmon_Click(object sender, EventArgs e)
        {
            txtmamon.Text = "";
            txttenmon.Text = "";
            txtsoTC.Text = "";
            txtmamon.Enabled = true;
            txtmamon.Focus();
            adMon = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.ShowDialog();
        }

        private void btnxoamon_Click(object sender, EventArgs e)
        {
            dt.XoaMonHoc(txtmamon.Text);
            cbhocky_SelectedIndexChanged(sender, e);
        }

        private void btnluumon_Click(object sender, EventArgs e)
        {
            if (adMon)
            {
                dt.ThemMonHoc(txtmamon.Text, txttenmon.Text, Convert.ToInt16(txtsoTC.Text), txtmahk.Text);

                adMon = false;

            }
            else
            {
                dt.ThemMonHoc(txtmamon.Text, txttenmon.Text, Convert.ToInt16(txtsoTC.Text), txtmahk.Text);
                cbhocky_SelectedIndexChanged(sender, e);
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            foreach (var m in dt.GetMonHoc())
            {
                foreach (var s in dt.SinhVienSelectAll())
                {
                    if (dt.DiemHPSearch(m.MaMon, s.MaSV).Count() == 0)
                    {
                        dt.DiemHPInsert(m.MaMon, s.MaSV);
                    }
                }
            }
            MessageBox.Show("Cập nhật thành công cơ sở dữ liệu bảng điểm học phần!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cbmonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataDiem.DataSource = dt.BangDiemHP(cbLop.SelectedValue.ToString(), txtmamon.Text);
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbmonhoc_SelectedIndexChanged(sender, e);
        }

        private void dataDiem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataDiem.CurrentCell.RowIndex;
            if (!String.IsNullOrEmpty(dataDiem.Rows[i].Cells["DiemHS1"].Value.ToString()))
            {
                dt.DiemHP_Updatelan1(Convert.ToDouble(dataDiem.Rows[i].Cells["DiemHS1"].Value),
                  txtmamon.Text, dataDiem.Rows[i].Cells["MaSV"].Value.ToString());
            }
            if (!String.IsNullOrEmpty(dataDiem.Rows[i].Cells[4].Value.ToString()))
            {
                dt.DiemHP_Updatelan2(Convert.ToDouble(dataDiem.Rows[i].Cells["DiemHS2"].Value),
                  txtmamon.Text, dataDiem.Rows[i].Cells["MaSV"].Value.ToString());
            }
        }
    }
}
