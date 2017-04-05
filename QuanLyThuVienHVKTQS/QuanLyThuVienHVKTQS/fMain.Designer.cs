namespace QuanLyThuVienHVKTQS
{
    partial class fMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ImenuTK = new System.Windows.Forms.ToolStripMenuItem();
            this.ImenuThongTinTK = new System.Windows.Forms.ToolStripMenuItem();
            this.ImenuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.ImenuQuanLyNhanSu = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImenuThanhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.ImenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ImenuVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMuonTra = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.btnThe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImenuTK,
            this.ImenuQuanLyNhanSu,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(338, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ImenuTK
            // 
            this.ImenuTK.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImenuThongTinTK,
            this.ImenuDangXuat});
            this.ImenuTK.Name = "ImenuTK";
            this.ImenuTK.Size = new System.Drawing.Size(70, 20);
            this.ImenuTK.Text = "Tài khoản";
            // 
            // ImenuThongTinTK
            // 
            this.ImenuThongTinTK.Name = "ImenuThongTinTK";
            this.ImenuThongTinTK.Size = new System.Drawing.Size(165, 22);
            this.ImenuThongTinTK.Text = "Thông tin chi tiết";
            this.ImenuThongTinTK.Click += new System.EventHandler(this.ImenuThongTinTK_Click);
            // 
            // ImenuDangXuat
            // 
            this.ImenuDangXuat.Name = "ImenuDangXuat";
            this.ImenuDangXuat.Size = new System.Drawing.Size(165, 22);
            this.ImenuDangXuat.Text = "Đăng xuất";
            this.ImenuDangXuat.Click += new System.EventHandler(this.ImenuDangXuat_Click);
            // 
            // ImenuQuanLyNhanSu
            // 
            this.ImenuQuanLyNhanSu.Name = "ImenuQuanLyNhanSu";
            this.ImenuQuanLyNhanSu.Size = new System.Drawing.Size(105, 20);
            this.ImenuQuanLyNhanSu.Text = "Quản lý nhân sự";
            this.ImenuQuanLyNhanSu.Click += new System.EventHandler(this.ImenuQuanLyNhanSu_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImenuThanhVien,
            this.ImenuHelp,
            this.ImenuVersion});
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // ImenuThanhVien
            // 
            this.ImenuThanhVien.Name = "ImenuThanhVien";
            this.ImenuThanhVien.Size = new System.Drawing.Size(180, 22);
            this.ImenuThanhVien.Text = "Thành viên nhóm";
            this.ImenuThanhVien.Click += new System.EventHandler(this.ImenuThanhVien_Click);
            // 
            // ImenuHelp
            // 
            this.ImenuHelp.Name = "ImenuHelp";
            this.ImenuHelp.Size = new System.Drawing.Size(180, 22);
            this.ImenuHelp.Text = "Hướng dẫn sử dụng";
            this.ImenuHelp.Click += new System.EventHandler(this.ImenuHelp_Click);
            // 
            // ImenuVersion
            // 
            this.ImenuVersion.Name = "ImenuVersion";
            this.ImenuVersion.Size = new System.Drawing.Size(180, 22);
            this.ImenuVersion.Text = "Phiên bản";
            this.ImenuVersion.Click += new System.EventHandler(this.ImenuVersion_Click);
            // 
            // btnMuonTra
            // 
            this.btnMuonTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnMuonTra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMuonTra.FlatAppearance.BorderSize = 0;
            this.btnMuonTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuonTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuonTra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMuonTra.Image = global::QuanLyThuVienHVKTQS.Properties.Resources.exchange_icon128;
            this.btnMuonTra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMuonTra.Location = new System.Drawing.Point(377, 155);
            this.btnMuonTra.Name = "btnMuonTra";
            this.btnMuonTra.Size = new System.Drawing.Size(266, 139);
            this.btnMuonTra.TabIndex = 2;
            this.btnMuonTra.Text = "Mượn trả";
            this.btnMuonTra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMuonTra.UseVisualStyleBackColor = false;
            this.btnMuonTra.Click += new System.EventHandler(this.btnMuonTra_Click);
            // 
            // btnSach
            // 
            this.btnSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSach.FlatAppearance.BorderSize = 0;
            this.btnSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSach.Image = global::QuanLyThuVienHVKTQS.Properties.Resources.book1281;
            this.btnSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSach.Location = new System.Drawing.Point(69, 155);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(266, 139);
            this.btnSach.TabIndex = 2;
            this.btnSach.Text = "Sách";
            this.btnSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSach.UseVisualStyleBackColor = false;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // btnThe
            // 
            this.btnThe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnThe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThe.FlatAppearance.BorderSize = 0;
            this.btnThe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThe.Image = global::QuanLyThuVienHVKTQS.Properties.Resources.credict_card128;
            this.btnThe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThe.Location = new System.Drawing.Point(682, 155);
            this.btnThe.Name = "btnThe";
            this.btnThe.Size = new System.Drawing.Size(266, 139);
            this.btnThe.TabIndex = 2;
            this.btnThe.Text = "Thẻ";
            this.btnThe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThe.UseVisualStyleBackColor = false;
            this.btnThe.Click += new System.EventHandler(this.btnThe_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 30);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(916, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(32, 30);
            this.btnMin.TabIndex = 1;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(948, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 514);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMuonTra);
            this.Controls.Add(this.btnSach);
            this.Controls.Add(this.btnThe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.Load += new System.EventHandler(this.fMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fMain_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ImenuTK;
        private System.Windows.Forms.ToolStripMenuItem ImenuThongTinTK;
        private System.Windows.Forms.ToolStripMenuItem ImenuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImenuThanhVien;
        private System.Windows.Forms.ToolStripMenuItem ImenuHelp;
        private System.Windows.Forms.ToolStripMenuItem ImenuVersion;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Button btnThe;
        private System.Windows.Forms.ToolStripMenuItem ImenuQuanLyNhanSu;
        private System.Windows.Forms.Button btnMuonTra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnExit;
    }
}