namespace QuanLyDiem
{
    partial class frmBangDiemCT
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.treeViewSV = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMaSv = new System.Windows.Forms.Label();
            this.lblTensv = new System.Windows.Forms.Label();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblNoisinh = new System.Windows.Forms.Label();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.lbldantoc = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTB = new System.Windows.Forms.Label();
            this.lblXL = new System.Windows.Forms.Label();
            this.dtgBangdiem = new System.Windows.Forms.DataGridView();
            this.txtmamon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttenmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdiemhp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtchu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBangdiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(143, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG ĐIỂM TỔNG HỢP CHI TIẾT SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn lớp:";
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(52, 44);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(121, 21);
            this.cbLop.TabIndex = 2;
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // treeViewSV
            // 
            this.treeViewSV.Location = new System.Drawing.Point(6, 68);
            this.treeViewSV.Name = "treeViewSV";
            this.treeViewSV.Size = new System.Drawing.Size(167, 181);
            this.treeViewSV.TabIndex = 3;
            this.treeViewSV.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewSV_NodeMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã SV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Họ tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày sinh:";
            // 
            // lblMaSv
            // 
            this.lblMaSv.AutoSize = true;
            this.lblMaSv.Location = new System.Drawing.Point(256, 44);
            this.lblMaSv.Name = "lblMaSv";
            this.lblMaSv.Size = new System.Drawing.Size(25, 13);
            this.lblMaSv.TabIndex = 7;
            this.lblMaSv.Text = "Null";
            // 
            // lblTensv
            // 
            this.lblTensv.AutoSize = true;
            this.lblTensv.Location = new System.Drawing.Point(256, 64);
            this.lblTensv.Name = "lblTensv";
            this.lblTensv.Size = new System.Drawing.Size(25, 13);
            this.lblTensv.TabIndex = 8;
            this.lblTensv.Text = "Null";
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Location = new System.Drawing.Point(256, 85);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(25, 13);
            this.lblNgaysinh.TabIndex = 9;
            this.lblNgaysinh.Text = "Null";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(428, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Nơi sinh:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(428, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Giới tính:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(428, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Dân tộc:";
            // 
            // lblNoisinh
            // 
            this.lblNoisinh.AutoSize = true;
            this.lblNoisinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoisinh.Location = new System.Drawing.Point(498, 44);
            this.lblNoisinh.Name = "lblNoisinh";
            this.lblNoisinh.Size = new System.Drawing.Size(25, 13);
            this.lblNoisinh.TabIndex = 13;
            this.lblNoisinh.Text = "Null";
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioitinh.Location = new System.Drawing.Point(498, 64);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(25, 13);
            this.lblGioitinh.TabIndex = 14;
            this.lblGioitinh.Text = "Null";
            // 
            // lbldantoc
            // 
            this.lbldantoc.AutoSize = true;
            this.lbldantoc.Location = new System.Drawing.Point(498, 85);
            this.lbldantoc.Name = "lbldantoc";
            this.lbldantoc.Size = new System.Drawing.Size(25, 13);
            this.lbldantoc.TabIndex = 15;
            this.lbldantoc.Text = "Null";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(576, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "TB toàn khóa:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(577, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "XL toàn khóa:";
            // 
            // lblTB
            // 
            this.lblTB.AutoSize = true;
            this.lblTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTB.ForeColor = System.Drawing.Color.Red;
            this.lblTB.Location = new System.Drawing.Point(670, 68);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(29, 13);
            this.lblTB.TabIndex = 18;
            this.lblTB.Text = "Null";
            // 
            // lblXL
            // 
            this.lblXL.AutoSize = true;
            this.lblXL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXL.ForeColor = System.Drawing.Color.Red;
            this.lblXL.Location = new System.Drawing.Point(670, 85);
            this.lblXL.Name = "lblXL";
            this.lblXL.Size = new System.Drawing.Size(29, 13);
            this.lblXL.TabIndex = 19;
            this.lblXL.Text = "Null";
            // 
            // dtgBangdiem
            // 
            this.dtgBangdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBangdiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtmamon,
            this.txttenmon,
            this.txtTC,
            this.txtdiemhp,
            this.txtchu,
            this.txtso});
            this.dtgBangdiem.Location = new System.Drawing.Point(179, 101);
            this.dtgBangdiem.Name = "dtgBangdiem";
            this.dtgBangdiem.Size = new System.Drawing.Size(606, 160);
            this.dtgBangdiem.TabIndex = 20;
            // 
            // txtmamon
            // 
            this.txtmamon.DataPropertyName = "MaMon";
            this.txtmamon.HeaderText = "Mã môn";
            this.txtmamon.Name = "txtmamon";
            // 
            // txttenmon
            // 
            this.txttenmon.DataPropertyName = "TenMon";
            this.txttenmon.HeaderText = "Tên môn";
            this.txttenmon.Name = "txttenmon";
            // 
            // txtTC
            // 
            this.txtTC.DataPropertyName = "SoTC";
            this.txtTC.HeaderText = "Số TC";
            this.txtTC.Name = "txtTC";
            // 
            // txtdiemhp
            // 
            this.txtdiemhp.DataPropertyName = "DiemHP";
            this.txtdiemhp.HeaderText = "Điểm HP";
            this.txtdiemhp.Name = "txtdiemhp";
            // 
            // txtchu
            // 
            this.txtchu.DataPropertyName = "DienChu";
            this.txtchu.HeaderText = "Điền chữ";
            this.txtchu.Name = "txtchu";
            // 
            // txtso
            // 
            this.txtso.DataPropertyName = "DienSo";
            this.txtso.HeaderText = "Điền số";
            this.txtso.Name = "txtso";
            // 
            // frmBangDiemCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 261);
            this.Controls.Add(this.dtgBangdiem);
            this.Controls.Add(this.lblXL);
            this.Controls.Add(this.lblTB);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbldantoc);
            this.Controls.Add(this.lblGioitinh);
            this.Controls.Add(this.lblNoisinh);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblNgaysinh);
            this.Controls.Add(this.lblTensv);
            this.Controls.Add(this.lblMaSv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.treeViewSV);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBangDiemCT";
            this.Text = "frmBangDiemCT";
            this.Load += new System.EventHandler(this.frmBangDiemCT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBangdiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.TreeView treeViewSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMaSv;
        private System.Windows.Forms.Label lblTensv;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblNoisinh;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.Label lbldantoc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.Label lblXL;
        private System.Windows.Forms.DataGridView dtgBangdiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtmamon;
        private System.Windows.Forms.DataGridViewTextBoxColumn txttenmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtdiemhp;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtchu;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtso;
    }
}