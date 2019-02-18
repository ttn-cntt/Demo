namespace QuanLyDiem
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xửLýDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xửLíDữLiệuSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xửLíDữLiệuLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.xửLýDữLiệuHọcKỳMônHọcĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.xửLýDữLiệuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(420, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // xửLýDữLiệuToolStripMenuItem
            // 
            this.xửLýDữLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xửLíDữLiệuSinhViênToolStripMenuItem,
            this.xửLíDữLiệuLớpToolStripMenuItem,
            this.xửLýDữLiệuHọcKỳMônHọcĐiểmToolStripMenuItem});
            this.xửLýDữLiệuToolStripMenuItem.Name = "xửLýDữLiệuToolStripMenuItem";
            this.xửLýDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.xửLýDữLiệuToolStripMenuItem.Text = "Xử lý dữ liệu";
            // 
            // xửLíDữLiệuSinhViênToolStripMenuItem
            // 
            this.xửLíDữLiệuSinhViênToolStripMenuItem.Name = "xửLíDữLiệuSinhViênToolStripMenuItem";
            this.xửLíDữLiệuSinhViênToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.xửLíDữLiệuSinhViênToolStripMenuItem.Text = "Xử lí dữ liệu sinh viên";
            this.xửLíDữLiệuSinhViênToolStripMenuItem.Click += new System.EventHandler(this.xửLíDữLiệuSinhViênToolStripMenuItem_Click);
            // 
            // xửLíDữLiệuLớpToolStripMenuItem
            // 
            this.xửLíDữLiệuLớpToolStripMenuItem.Name = "xửLíDữLiệuLớpToolStripMenuItem";
            this.xửLíDữLiệuLớpToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.xửLíDữLiệuLớpToolStripMenuItem.Text = "Xử lí dữ liệu Lớp";
            this.xửLíDữLiệuLớpToolStripMenuItem.Click += new System.EventHandler(this.xửLíDữLiệuLớpToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(74, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hệ Thống Quản Lý Điểm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyDiem.Properties.Resources._49124993_280920556111885_4415955966382571520_n;
            this.pictureBox1.Location = new System.Drawing.Point(12, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // xửLýDữLiệuHọcKỳMônHọcĐiểmToolStripMenuItem
            // 
            this.xửLýDữLiệuHọcKỳMônHọcĐiểmToolStripMenuItem.Name = "xửLýDữLiệuHọcKỳMônHọcĐiểmToolStripMenuItem";
            this.xửLýDữLiệuHọcKỳMônHọcĐiểmToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.xửLýDữLiệuHọcKỳMônHọcĐiểmToolStripMenuItem.Text = "Xử lý dữ liệu học kỳ , môn học , điểm";
            this.xửLýDữLiệuHọcKỳMônHọcĐiểmToolStripMenuItem.Click += new System.EventHandler(this.xửLýDữLiệuHọcKỳMônHọcĐiểmToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(420, 297);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý điểm theo tín chỉ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xửLýDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xửLíDữLiệuSinhViênToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem xửLíDữLiệuLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xửLýDữLiệuHọcKỳMônHọcĐiểmToolStripMenuItem;
    }
}

