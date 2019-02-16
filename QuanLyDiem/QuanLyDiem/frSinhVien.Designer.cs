namespace QuanLyDiem
{
    partial class frmSinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTensv = new System.Windows.Forms.TextBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.quanLyDiemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtdantoc = new System.Windows.Forms.TextBox();
            this.rdDiachi = new System.Windows.Forms.RichTextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.dataGridViewSinhVien = new System.Windows.Forms.DataGridView();
            this.lbStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cblop = new System.Windows.Forms.ComboBox();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyDiemDataSet = new QuanLyDiem.QuanLyDiemDataSet();
            this.lopTableAdapter = new QuanLyDiem.QuanLyDiemDataSetTableAdapters.LopTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).BeginInit();
            this.lbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dân tộc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa chỉ";
            // 
            // txtTensv
            // 
            this.txtTensv.Location = new System.Drawing.Point(72, 18);
            this.txtTensv.Name = "txtTensv";
            this.txtTensv.Size = new System.Drawing.Size(118, 20);
            this.txtTensv.TabIndex = 6;
            this.txtTensv.TextChanged += new System.EventHandler(this.txtTensv_TextChanged);
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(72, 54);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 7;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(125, 54);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 8;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinh.Location = new System.Drawing.Point(67, 88);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(123, 20);
            this.dtNgaySinh.TabIndex = 9;
            // 
            // txtdantoc
            // 
            this.txtdantoc.Location = new System.Drawing.Point(281, 49);
            this.txtdantoc.Name = "txtdantoc";
            this.txtdantoc.Size = new System.Drawing.Size(121, 20);
            this.txtdantoc.TabIndex = 12;
            this.txtdantoc.TextChanged += new System.EventHandler(this.txtdantoc_TextChanged);
            // 
            // rdDiachi
            // 
            this.rdDiachi.Location = new System.Drawing.Point(281, 88);
            this.rdDiachi.Name = "rdDiachi";
            this.rdDiachi.Size = new System.Drawing.Size(121, 50);
            this.rdDiachi.TabIndex = 13;
            this.rdDiachi.Text = "";
            this.rdDiachi.TextChanged += new System.EventHandler(this.rdDiachi_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(428, 34);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(521, 34);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(428, 83);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(521, 78);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(115, 141);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(75, 23);
            this.btnTK.TabIndex = 18;
            this.btnTK.Text = "Tìm Kiếm";
            this.btnTK.UseVisualStyleBackColor = true;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(228, 144);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(225, 20);
            this.txtTK.TabIndex = 19;
            // 
            // dataGridViewSinhVien
            // 
            this.dataGridViewSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSinhVien.Location = new System.Drawing.Point(-1, 170);
            this.dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            this.dataGridViewSinhVien.Size = new System.Drawing.Size(611, 164);
            this.dataGridViewSinhVien.TabIndex = 20;
            this.dataGridViewSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSinhVien_CellContentClick);
            // 
            // lbStatus
            // 
            this.lbStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.lbStatus.Location = new System.Drawing.Point(0, 337);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(608, 22);
            this.lbStatus.TabIndex = 21;
            this.lbStatus.Text = "có 20 sinh viên";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(85, 17);
            this.toolStripStatusLabel1.Text = "có 20 sinh viên";
            // 
            // cblop
            // 
            this.cblop.DataSource = this.lopBindingSource;
            this.cblop.DisplayMember = "TenLop";
            this.cblop.FormattingEnabled = true;
            this.cblop.Location = new System.Drawing.Point(281, 21);
            this.cblop.Name = "cblop";
            this.cblop.Size = new System.Drawing.Size(121, 21);
            this.cblop.TabIndex = 23;
            this.cblop.ValueMember = "MaLop";
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.quanLyDiemDataSet;
            // 
            // quanLyDiemDataSet
            // 
            this.quanLyDiemDataSet.DataSetName = "QuanLyDiemDataSet";
            this.quanLyDiemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 359);
            this.Controls.Add(this.cblop);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.dataGridViewSinhVien);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.rdDiachi);
            this.Controls.Add(this.txtdantoc);
            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.txtTensv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSinhVien";
            this.Text = "frSinhVien";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).EndInit();
            this.lbStatus.ResumeLayout(false);
            this.lbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTensv;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.TextBox txtdantoc;
        private System.Windows.Forms.RichTextBox rdDiachi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.DataGridView dataGridViewSinhVien;
        private System.Windows.Forms.BindingSource quanLyDiemDataSetBindingSource;
        //private QuanLyDiemDataSet quanLyDiemDataSet;
        //private System.Windows.Forms.BindingSource lopBindingSource;
        //private QuanLyDiemDataSetTableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.StatusStrip lbStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox cblop;
        private QuanLyDiemDataSet quanLyDiemDataSet;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private QuanLyDiemDataSetTableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}