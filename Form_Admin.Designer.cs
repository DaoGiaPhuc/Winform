namespace Test_Desktop
{
    partial class Form_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Admin));
            this.panel_Sidebar = new System.Windows.Forms.Panel();
            this.button_CaiDat = new System.Windows.Forms.Button();
            this.button_GuiThongBao = new System.Windows.Forms.Button();
            this.button_XepLichLamViec = new System.Windows.Forms.Button();
            this.panel_ChildTaiKhoanNhanVien = new System.Windows.Forms.Panel();
            this.button_ChinhSuaTaiKhoan = new System.Windows.Forms.Button();
            this.button_Thongtin = new System.Windows.Forms.Button();
            this.button_TaiKhoanNhanVien = new System.Windows.Forms.Button();
            this.panel_LogoUeh = new System.Windows.Forms.Panel();
            this.pictureBox_MenuIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox_LogoUeh = new System.Windows.Forms.PictureBox();
            this.panel_Search = new System.Windows.Forms.Panel();
            this.pictureBox_SearchIcon = new System.Windows.Forms.PictureBox();
            this.label_Search = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.panel_Info = new System.Windows.Forms.Panel();
            this.label_ThongTinNhanVien = new System.Windows.Forms.Label();
            this.label_DecorLine = new System.Windows.Forms.Label();
            this.label_Home_CurrentFunction = new System.Windows.Forms.Label();
            this.panel_ChildForm = new System.Windows.Forms.Panel();
            this.timer_TaiKhoanNhanVienTransition = new System.Windows.Forms.Timer(this.components);
            this.panel_Sidebar.SuspendLayout();
            this.panel_ChildTaiKhoanNhanVien.SuspendLayout();
            this.panel_LogoUeh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MenuIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LogoUeh)).BeginInit();
            this.panel_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SearchIcon)).BeginInit();
            this.panel_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Sidebar
            // 
            this.panel_Sidebar.Controls.Add(this.button_CaiDat);
            this.panel_Sidebar.Controls.Add(this.button_GuiThongBao);
            this.panel_Sidebar.Controls.Add(this.button_XepLichLamViec);
            this.panel_Sidebar.Controls.Add(this.panel_ChildTaiKhoanNhanVien);
            this.panel_Sidebar.Controls.Add(this.button_TaiKhoanNhanVien);
            this.panel_Sidebar.Controls.Add(this.panel_LogoUeh);
            this.panel_Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Sidebar.Location = new System.Drawing.Point(0, 0);
            this.panel_Sidebar.Name = "panel_Sidebar";
            this.panel_Sidebar.Size = new System.Drawing.Size(237, 711);
            this.panel_Sidebar.TabIndex = 0;
            // 
            // button_CaiDat
            // 
            this.button_CaiDat.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_CaiDat.FlatAppearance.BorderSize = 0;
            this.button_CaiDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CaiDat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CaiDat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.button_CaiDat.Image = ((System.Drawing.Image)(resources.GetObject("button_CaiDat.Image")));
            this.button_CaiDat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_CaiDat.Location = new System.Drawing.Point(0, 350);
            this.button_CaiDat.Name = "button_CaiDat";
            this.button_CaiDat.Size = new System.Drawing.Size(237, 50);
            this.button_CaiDat.TabIndex = 10;
            this.button_CaiDat.Text = "          Cài đặt";
            this.button_CaiDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_CaiDat.UseVisualStyleBackColor = true;
            // 
            // button_GuiThongBao
            // 
            this.button_GuiThongBao.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_GuiThongBao.FlatAppearance.BorderSize = 0;
            this.button_GuiThongBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GuiThongBao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GuiThongBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.button_GuiThongBao.Image = ((System.Drawing.Image)(resources.GetObject("button_GuiThongBao.Image")));
            this.button_GuiThongBao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_GuiThongBao.Location = new System.Drawing.Point(0, 300);
            this.button_GuiThongBao.Name = "button_GuiThongBao";
            this.button_GuiThongBao.Size = new System.Drawing.Size(237, 50);
            this.button_GuiThongBao.TabIndex = 8;
            this.button_GuiThongBao.Text = "          Gửi thông báo";
            this.button_GuiThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_GuiThongBao.UseVisualStyleBackColor = true;
            this.button_GuiThongBao.Click += new System.EventHandler(this.button_GuiThongBao_Click);
            // 
            // button_XepLichLamViec
            // 
            this.button_XepLichLamViec.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_XepLichLamViec.FlatAppearance.BorderSize = 0;
            this.button_XepLichLamViec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_XepLichLamViec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_XepLichLamViec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.button_XepLichLamViec.Image = ((System.Drawing.Image)(resources.GetObject("button_XepLichLamViec.Image")));
            this.button_XepLichLamViec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_XepLichLamViec.Location = new System.Drawing.Point(0, 250);
            this.button_XepLichLamViec.Name = "button_XepLichLamViec";
            this.button_XepLichLamViec.Size = new System.Drawing.Size(237, 50);
            this.button_XepLichLamViec.TabIndex = 7;
            this.button_XepLichLamViec.Text = "          Xếp lịch làm việc";
            this.button_XepLichLamViec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_XepLichLamViec.UseVisualStyleBackColor = true;
            this.button_XepLichLamViec.Click += new System.EventHandler(this.button_LichLamViec_Click);
            // 
            // panel_ChildTaiKhoanNhanVien
            // 
            this.panel_ChildTaiKhoanNhanVien.Controls.Add(this.button_ChinhSuaTaiKhoan);
            this.panel_ChildTaiKhoanNhanVien.Controls.Add(this.button_Thongtin);
            this.panel_ChildTaiKhoanNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ChildTaiKhoanNhanVien.Location = new System.Drawing.Point(0, 150);
            this.panel_ChildTaiKhoanNhanVien.Name = "panel_ChildTaiKhoanNhanVien";
            this.panel_ChildTaiKhoanNhanVien.Size = new System.Drawing.Size(237, 100);
            this.panel_ChildTaiKhoanNhanVien.TabIndex = 6;
            // 
            // button_ChinhSuaTaiKhoan
            // 
            this.button_ChinhSuaTaiKhoan.BackColor = System.Drawing.Color.Gainsboro;
            this.button_ChinhSuaTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_ChinhSuaTaiKhoan.FlatAppearance.BorderSize = 0;
            this.button_ChinhSuaTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ChinhSuaTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChinhSuaTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.button_ChinhSuaTaiKhoan.Location = new System.Drawing.Point(0, 50);
            this.button_ChinhSuaTaiKhoan.Name = "button_ChinhSuaTaiKhoan";
            this.button_ChinhSuaTaiKhoan.Size = new System.Drawing.Size(237, 50);
            this.button_ChinhSuaTaiKhoan.TabIndex = 1;
            this.button_ChinhSuaTaiKhoan.Text = "               > Chỉnh sửa tài khoản";
            this.button_ChinhSuaTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ChinhSuaTaiKhoan.UseVisualStyleBackColor = false;
            this.button_ChinhSuaTaiKhoan.Click += new System.EventHandler(this.buttonChinhSuaTaiKhoan_Click);
            // 
            // button_Thongtin
            // 
            this.button_Thongtin.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Thongtin.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Thongtin.FlatAppearance.BorderSize = 0;
            this.button_Thongtin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Thongtin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Thongtin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.button_Thongtin.Location = new System.Drawing.Point(0, 0);
            this.button_Thongtin.Name = "button_Thongtin";
            this.button_Thongtin.Size = new System.Drawing.Size(237, 50);
            this.button_Thongtin.TabIndex = 0;
            this.button_Thongtin.Text = "               > Thông tin";
            this.button_Thongtin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Thongtin.UseVisualStyleBackColor = false;
            this.button_Thongtin.Click += new System.EventHandler(this.buttonThongtin_Click);
            // 
            // button_TaiKhoanNhanVien
            // 
            this.button_TaiKhoanNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_TaiKhoanNhanVien.FlatAppearance.BorderSize = 0;
            this.button_TaiKhoanNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TaiKhoanNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TaiKhoanNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.button_TaiKhoanNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("button_TaiKhoanNhanVien.Image")));
            this.button_TaiKhoanNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_TaiKhoanNhanVien.Location = new System.Drawing.Point(0, 100);
            this.button_TaiKhoanNhanVien.Name = "button_TaiKhoanNhanVien";
            this.button_TaiKhoanNhanVien.Size = new System.Drawing.Size(237, 50);
            this.button_TaiKhoanNhanVien.TabIndex = 5;
            this.button_TaiKhoanNhanVien.Text = "          Tài khoản nhân viên";
            this.button_TaiKhoanNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_TaiKhoanNhanVien.UseVisualStyleBackColor = true;
            this.button_TaiKhoanNhanVien.Click += new System.EventHandler(this.button_TaiKhoanNhanVien_Click);
            // 
            // panel_LogoUeh
            // 
            this.panel_LogoUeh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.panel_LogoUeh.Controls.Add(this.pictureBox_MenuIcon);
            this.panel_LogoUeh.Controls.Add(this.pictureBox_LogoUeh);
            this.panel_LogoUeh.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_LogoUeh.Location = new System.Drawing.Point(0, 0);
            this.panel_LogoUeh.Name = "panel_LogoUeh";
            this.panel_LogoUeh.Size = new System.Drawing.Size(237, 100);
            this.panel_LogoUeh.TabIndex = 1;
            // 
            // pictureBox_MenuIcon
            // 
            this.pictureBox_MenuIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_MenuIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.pictureBox_MenuIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_MenuIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_MenuIcon.Image")));
            this.pictureBox_MenuIcon.Location = new System.Drawing.Point(179, 32);
            this.pictureBox_MenuIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_MenuIcon.Name = "pictureBox_MenuIcon";
            this.pictureBox_MenuIcon.Size = new System.Drawing.Size(41, 45);
            this.pictureBox_MenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_MenuIcon.TabIndex = 11;
            this.pictureBox_MenuIcon.TabStop = false;
            // 
            // pictureBox_LogoUeh
            // 
            this.pictureBox_LogoUeh.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_LogoUeh.Image")));
            this.pictureBox_LogoUeh.Location = new System.Drawing.Point(37, 22);
            this.pictureBox_LogoUeh.Name = "pictureBox_LogoUeh";
            this.pictureBox_LogoUeh.Size = new System.Drawing.Size(74, 60);
            this.pictureBox_LogoUeh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_LogoUeh.TabIndex = 2;
            this.pictureBox_LogoUeh.TabStop = false;
            // 
            // panel_Search
            // 
            this.panel_Search.Controls.Add(this.pictureBox_SearchIcon);
            this.panel_Search.Controls.Add(this.label_Search);
            this.panel_Search.Controls.Add(this.textBox_Search);
            this.panel_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Search.Location = new System.Drawing.Point(237, 0);
            this.panel_Search.Name = "panel_Search";
            this.panel_Search.Size = new System.Drawing.Size(1147, 50);
            this.panel_Search.TabIndex = 1;
            // 
            // pictureBox_SearchIcon
            // 
            this.pictureBox_SearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_SearchIcon.Image")));
            this.pictureBox_SearchIcon.Location = new System.Drawing.Point(27, 14);
            this.pictureBox_SearchIcon.Name = "pictureBox_SearchIcon";
            this.pictureBox_SearchIcon.Size = new System.Drawing.Size(30, 27);
            this.pictureBox_SearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_SearchIcon.TabIndex = 2;
            this.pictureBox_SearchIcon.TabStop = false;
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Search.ForeColor = System.Drawing.Color.Gray;
            this.label_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Search.Location = new System.Drawing.Point(62, 19);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(60, 20);
            this.label_Search.TabIndex = 1;
            this.label_Search.Text = "Search";
            this.label_Search.Click += new System.EventHandler(this.labelSearch_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Search.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Search.Location = new System.Drawing.Point(60, 15);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(338, 26);
            this.textBox_Search.TabIndex = 0;
            this.textBox_Search.Click += new System.EventHandler(this.textBox_Search_Click);
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // panel_Info
            // 
            this.panel_Info.Controls.Add(this.label_ThongTinNhanVien);
            this.panel_Info.Controls.Add(this.label_DecorLine);
            this.panel_Info.Controls.Add(this.label_Home_CurrentFunction);
            this.panel_Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Info.Location = new System.Drawing.Point(237, 50);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Size = new System.Drawing.Size(1147, 59);
            this.panel_Info.TabIndex = 2;
            // 
            // label_ThongTinNhanVien
            // 
            this.label_ThongTinNhanVien.AutoSize = true;
            this.label_ThongTinNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ThongTinNhanVien.Location = new System.Drawing.Point(19, 3);
            this.label_ThongTinNhanVien.Name = "label_ThongTinNhanVien";
            this.label_ThongTinNhanVien.Size = new System.Drawing.Size(164, 21);
            this.label_ThongTinNhanVien.TabIndex = 0;
            this.label_ThongTinNhanVien.Text = "Thông tin nhân viên";
            // 
            // label_DecorLine
            // 
            this.label_DecorLine.AutoSize = true;
            this.label_DecorLine.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DecorLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.label_DecorLine.Location = new System.Drawing.Point(18, 2);
            this.label_DecorLine.Name = "label_DecorLine";
            this.label_DecorLine.Size = new System.Drawing.Size(34, 29);
            this.label_DecorLine.TabIndex = 2;
            this.label_DecorLine.Text = "___";
            // 
            // label_Home_CurrentFunction
            // 
            this.label_Home_CurrentFunction.AutoSize = true;
            this.label_Home_CurrentFunction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Home_CurrentFunction.Location = new System.Drawing.Point(19, 29);
            this.label_Home_CurrentFunction.Name = "label_Home_CurrentFunction";
            this.label_Home_CurrentFunction.Size = new System.Drawing.Size(56, 21);
            this.label_Home_CurrentFunction.TabIndex = 1;
            this.label_Home_CurrentFunction.Text = "Home ";
            // 
            // panel_ChildForm
            // 
            this.panel_ChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ChildForm.Location = new System.Drawing.Point(237, 109);
            this.panel_ChildForm.Name = "panel_ChildForm";
            this.panel_ChildForm.Size = new System.Drawing.Size(1147, 602);
            this.panel_ChildForm.TabIndex = 3;
            // 
            // timer_TaiKhoanNhanVienTransition
            // 
            this.timer_TaiKhoanNhanVienTransition.Interval = 10;
            this.timer_TaiKhoanNhanVienTransition.Tick += new System.EventHandler(this.timer_TaiKhoanNhanVienTransition_Tick);
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1384, 711);
            this.Controls.Add(this.panel_ChildForm);
            this.Controls.Add(this.panel_Info);
            this.Controls.Add(this.panel_Search);
            this.Controls.Add(this.panel_Sidebar);
            this.Name = "Form_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Admin";
            this.Resize += new System.EventHandler(this.Form_Admin_Resize);
            this.panel_Sidebar.ResumeLayout(false);
            this.panel_ChildTaiKhoanNhanVien.ResumeLayout(false);
            this.panel_LogoUeh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MenuIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LogoUeh)).EndInit();
            this.panel_Search.ResumeLayout(false);
            this.panel_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SearchIcon)).EndInit();
            this.panel_Info.ResumeLayout(false);
            this.panel_Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Sidebar;
        private System.Windows.Forms.Panel panel_LogoUeh;
        private System.Windows.Forms.PictureBox pictureBox_LogoUeh;
        private System.Windows.Forms.Panel panel_ChildTaiKhoanNhanVien;
        private System.Windows.Forms.Button button_ChinhSuaTaiKhoan;
        private System.Windows.Forms.Button button_Thongtin;
        private System.Windows.Forms.Button button_TaiKhoanNhanVien;
        private System.Windows.Forms.Button button_XepLichLamViec;
        private System.Windows.Forms.Panel panel_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.Label label_Home_CurrentFunction;
        private System.Windows.Forms.Label label_ThongTinNhanVien;
        private System.Windows.Forms.Panel panel_ChildForm;
        private System.Windows.Forms.Label label_DecorLine;
        private System.Windows.Forms.Button button_GuiThongBao;
        private System.Windows.Forms.Timer timer_TaiKhoanNhanVienTransition;
        private System.Windows.Forms.Button button_CaiDat;
        private System.Windows.Forms.PictureBox pictureBox_MenuIcon;
        private System.Windows.Forms.PictureBox pictureBox_SearchIcon;
    }
}