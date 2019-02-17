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
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            Connection connection = new Connection();
            dataLop.DataSource = connection.GetLop();
            dataLop.Columns[0].Visible = false;


        }
        int id;
        private void dataLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex < 0) || (e.RowIndex >= dataLop.RowCount - 1))
            {
                return;
            }
            id = int.Parse(dataLop.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtTenLop.Text = dataLop.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void Clear()
        {
            txtTenLop.Text = "";

        }
    }
}
