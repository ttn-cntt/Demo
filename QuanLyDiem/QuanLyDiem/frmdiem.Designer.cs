﻿namespace QuanLyDiem
{
    partial class frmdiem
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.cbmonhoc = new System.Windows.Forms.ComboBox();
            this.cbhocky = new System.Windows.Forms.ComboBox();
            this.txttenhk = new System.Windows.Forms.TextBox();
            this.txtmamon = new System.Windows.Forms.TextBox();
            this.txttenmon = new System.Windows.Forms.TextBox();
            this.txtsoTC = new System.Windows.Forms.TextBox();
            this.btnthemhk = new System.Windows.Forms.Button();
            this.btnluuhk = new System.Windows.Forms.Button();
            this.btnxoamon = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataDiem = new System.Windows.Forms.DataGridView();
            this.diemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyDiemDataSet = new QuanLyDiem.QuanLyDiemDataSet();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monHocTableAdapter = new QuanLyDiem.QuanLyDiemDataSetTableAdapters.MonHocTableAdapter();
            this.diemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diemTableAdapter = new QuanLyDiem.QuanLyDiemDataSetTableAdapters.DiemTableAdapter();
            this.btnxoahk = new System.Windows.Forms.Button();
            this.btnluumon = new System.Windows.Forms.Button();
            this.btnthemmon = new System.Windows.Forms.Button();
            this.txtmahk = new System.Windows.Forms.TextBox();
            this.lbmahk = new System.Windows.Forms.Label();
            this.quanLyDiemDataSet2 = new QuanLyDiem.QuanLyDiemDataSet2();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopTableAdapter = new QuanLyDiem.QuanLyDiemDataSet2TableAdapters.LopTableAdapter();
            this.txtMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDiem1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDiem2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(140, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập nhật học kỳ , môn học , điểm của sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Môn học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Học kỳ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên học kỳ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã môn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tên môn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Số TC";
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(53, 35);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(121, 21);
            this.cbLop.TabIndex = 9;
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // cbmonhoc
            // 
            this.cbmonhoc.FormattingEnabled = true;
            this.cbmonhoc.Location = new System.Drawing.Point(53, 71);
            this.cbmonhoc.Name = "cbmonhoc";
            this.cbmonhoc.Size = new System.Drawing.Size(121, 21);
            this.cbmonhoc.TabIndex = 10;
            this.cbmonhoc.SelectedIndexChanged += new System.EventHandler(this.cbmonhoc_SelectedIndexChanged);
            // 
            // cbhocky
            // 
            this.cbhocky.FormattingEnabled = true;
            this.cbhocky.Location = new System.Drawing.Point(236, 32);
            this.cbhocky.Name = "cbhocky";
            this.cbhocky.Size = new System.Drawing.Size(72, 21);
            this.cbhocky.TabIndex = 11;
            this.cbhocky.SelectedIndexChanged += new System.EventHandler(this.cbhocky_SelectedIndexChanged);
            // 
            // txttenhk
            // 
            this.txttenhk.Location = new System.Drawing.Point(537, 33);
            this.txttenhk.Name = "txttenhk";
            this.txttenhk.Size = new System.Drawing.Size(70, 20);
            this.txttenhk.TabIndex = 13;
            // 
            // txtmamon
            // 
            this.txtmamon.Location = new System.Drawing.Point(236, 71);
            this.txtmamon.Name = "txtmamon";
            this.txtmamon.Size = new System.Drawing.Size(72, 20);
            this.txtmamon.TabIndex = 14;
            // 
            // txttenmon
            // 
            this.txttenmon.Location = new System.Drawing.Point(373, 72);
            this.txttenmon.Name = "txttenmon";
            this.txttenmon.Size = new System.Drawing.Size(82, 20);
            this.txttenmon.TabIndex = 15;
            // 
            // txtsoTC
            // 
            this.txtsoTC.Location = new System.Drawing.Point(537, 71);
            this.txtsoTC.Name = "txtsoTC";
            this.txtsoTC.Size = new System.Drawing.Size(70, 20);
            this.txtsoTC.TabIndex = 16;
            // 
            // btnthemhk
            // 
            this.btnthemhk.Location = new System.Drawing.Point(632, 28);
            this.btnthemhk.Name = "btnthemhk";
            this.btnthemhk.Size = new System.Drawing.Size(75, 23);
            this.btnthemhk.TabIndex = 17;
            this.btnthemhk.Text = "Thêm ";
            this.btnthemhk.UseVisualStyleBackColor = true;
            this.btnthemhk.Click += new System.EventHandler(this.btnthemhk_Click);
            // 
            // btnluuhk
            // 
            this.btnluuhk.Location = new System.Drawing.Point(713, 28);
            this.btnluuhk.Name = "btnluuhk";
            this.btnluuhk.Size = new System.Drawing.Size(75, 23);
            this.btnluuhk.TabIndex = 18;
            this.btnluuhk.Text = "Lưu lại";
            this.btnluuhk.UseVisualStyleBackColor = true;
            this.btnluuhk.Click += new System.EventHandler(this.btnsuahk_Click);
            // 
            // btnxoamon
            // 
            this.btnxoamon.Location = new System.Drawing.Point(794, 64);
            this.btnxoamon.Name = "btnxoamon";
            this.btnxoamon.Size = new System.Drawing.Size(75, 23);
            this.btnxoamon.TabIndex = 19;
            this.btnxoamon.Text = "Xóa";
            this.btnxoamon.UseVisualStyleBackColor = true;
            this.btnxoamon.Click += new System.EventHandler(this.btnxoamon_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(713, 121);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(43, 121);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(121, 23);
            this.btncapnhat.TabIndex = 21;
            this.btncapnhat.Text = "Cập nhật dữ liệu";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataDiem);
            this.panel1.Location = new System.Drawing.Point(-1, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 199);
            this.panel1.TabIndex = 24;
            // 
            // dataDiem
            // 
            this.dataDiem.AutoGenerateColumns = false;
            this.dataDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtMaSV,
            this.txtTenSV,
            this.txtNgaySinh,
            this.txtDiem1,
            this.txtDiem2});
            this.dataDiem.DataSource = this.diemBindingSource1;
            this.dataDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDiem.Location = new System.Drawing.Point(0, 0);
            this.dataDiem.Name = "dataDiem";
            this.dataDiem.Size = new System.Drawing.Size(799, 199);
            this.dataDiem.TabIndex = 0;
            this.dataDiem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDiem_CellEndEdit);
            // 
            // diemBindingSource1
            // 
            this.diemBindingSource1.DataMember = "Diem";
            this.diemBindingSource1.DataSource = this.quanLyDiemDataSet;
            // 
            // quanLyDiemDataSet
            // 
            this.quanLyDiemDataSet.DataSetName = "QuanLyDiemDataSet";
            this.quanLyDiemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataMember = "MonHoc";
            this.monHocBindingSource.DataSource = this.quanLyDiemDataSet;
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // diemBindingSource
            // 
            this.diemBindingSource.DataMember = "Diem";
            this.diemBindingSource.DataSource = this.quanLyDiemDataSet;
            // 
            // diemTableAdapter
            // 
            this.diemTableAdapter.ClearBeforeFill = true;
            // 
            // btnxoahk
            // 
            this.btnxoahk.Location = new System.Drawing.Point(794, 30);
            this.btnxoahk.Name = "btnxoahk";
            this.btnxoahk.Size = new System.Drawing.Size(75, 23);
            this.btnxoahk.TabIndex = 25;
            this.btnxoahk.Text = "Xóa";
            this.btnxoahk.UseVisualStyleBackColor = true;
            this.btnxoahk.Click += new System.EventHandler(this.btnxoahk_Click);
            // 
            // btnluumon
            // 
            this.btnluumon.Location = new System.Drawing.Point(713, 65);
            this.btnluumon.Name = "btnluumon";
            this.btnluumon.Size = new System.Drawing.Size(75, 23);
            this.btnluumon.TabIndex = 26;
            this.btnluumon.Text = "Lưu lại";
            this.btnluumon.UseVisualStyleBackColor = true;
            this.btnluumon.Click += new System.EventHandler(this.btnluumon_Click);
            // 
            // btnthemmon
            // 
            this.btnthemmon.Location = new System.Drawing.Point(632, 65);
            this.btnthemmon.Name = "btnthemmon";
            this.btnthemmon.Size = new System.Drawing.Size(75, 23);
            this.btnthemmon.TabIndex = 27;
            this.btnthemmon.Text = "Thêm";
            this.btnthemmon.UseVisualStyleBackColor = true;
            this.btnthemmon.Click += new System.EventHandler(this.btnthemmon_Click);
            // 
            // txtmahk
            // 
            this.txtmahk.Location = new System.Drawing.Point(373, 33);
            this.txtmahk.Name = "txtmahk";
            this.txtmahk.Size = new System.Drawing.Size(82, 20);
            this.txtmahk.TabIndex = 28;
            // 
            // lbmahk
            // 
            this.lbmahk.AutoSize = true;
            this.lbmahk.Location = new System.Drawing.Point(315, 35);
            this.lbmahk.Name = "lbmahk";
            this.lbmahk.Size = new System.Drawing.Size(57, 13);
            this.lbmahk.TabIndex = 29;
            this.lbmahk.Text = "Mã học kỳ";
            // 
            // quanLyDiemDataSet2
            // 
            this.quanLyDiemDataSet2.DataSetName = "QuanLyDiemDataSet2";
            this.quanLyDiemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.quanLyDiemDataSet2;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // txtMaSV
            // 
            this.txtMaSV.DataPropertyName = "MaSV";
            this.txtMaSV.HeaderText = "Mã sinh viên";
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true;
            // 
            // txtTenSV
            // 
            this.txtTenSV.DataPropertyName = "TenSV";
            this.txtTenSV.HeaderText = "Họ tên";
            this.txtTenSV.Name = "txtTenSV";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.DataPropertyName = "NgaySinh";
            this.txtNgaySinh.HeaderText = "Ngày sinh";
            this.txtNgaySinh.Name = "txtNgaySinh";
            // 
            // txtDiem1
            // 
            this.txtDiem1.DataPropertyName = "DiemHS1";
            this.txtDiem1.HeaderText = "Điểm lần 1";
            this.txtDiem1.Name = "txtDiem1";
            // 
            // txtDiem2
            // 
            this.txtDiem2.DataPropertyName = "DiemHS2";
            this.txtDiem2.HeaderText = "Điểm lần 2";
            this.txtDiem2.Name = "txtDiem2";
            // 
            // frmdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 297);
            this.Controls.Add(this.lbmahk);
            this.Controls.Add(this.txtmahk);
            this.Controls.Add(this.btnthemmon);
            this.Controls.Add(this.btnluumon);
            this.Controls.Add(this.btnxoahk);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnxoamon);
            this.Controls.Add(this.btnluuhk);
            this.Controls.Add(this.btnthemhk);
            this.Controls.Add(this.txtsoTC);
            this.Controls.Add(this.txttenmon);
            this.Controls.Add(this.txtmamon);
            this.Controls.Add(this.txttenhk);
            this.Controls.Add(this.cbhocky);
            this.Controls.Add(this.cbmonhoc);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmdiem";
            this.Text = "frmdiem";
            this.Load += new System.EventHandler(this.frmdiem_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDiemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //private void frmdiem_Load(object sender, System.EventArgs e)
        //{
        //    throw new System.NotImplementedException();
        //}

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cbmonhoc;
        private System.Windows.Forms.ComboBox cbhocky;
        private System.Windows.Forms.TextBox txttenhk;
        private System.Windows.Forms.TextBox txtmamon;
        private System.Windows.Forms.TextBox txttenmon;
        private System.Windows.Forms.TextBox txtsoTC;
        private System.Windows.Forms.Button btnthemhk;
        private System.Windows.Forms.Button btnluuhk;
        private System.Windows.Forms.Button btnxoamon;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataDiem;
        private QuanLyDiemDataSet quanLyDiemDataSet;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private QuanLyDiemDataSetTableAdapters.MonHocTableAdapter monHocTableAdapter;
        private System.Windows.Forms.BindingSource diemBindingSource;
        private QuanLyDiemDataSetTableAdapters.DiemTableAdapter diemTableAdapter;
        private System.Windows.Forms.BindingSource diemBindingSource1;
        private System.Windows.Forms.Button btnxoahk;
        private System.Windows.Forms.Button btnluumon;
        private System.Windows.Forms.Button btnthemmon;
        private System.Windows.Forms.TextBox txtmahk;
        private System.Windows.Forms.Label lbmahk;
        private QuanLyDiemDataSet2 quanLyDiemDataSet2;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private QuanLyDiemDataSet2TableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDiem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDiem2;
    }
}