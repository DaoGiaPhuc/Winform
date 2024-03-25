namespace Test_Desktop
{
    partial class Form_DanhGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DanhGia));
            this.label_ThongTinNhanVien = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_TenSach = new System.Windows.Forms.Label();
            this.label_TacGia = new System.Windows.Forms.Label();
            this.RatingStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.label_ChatLuong = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Edit = new System.Windows.Forms.Button();
            this.label_NhanXet = new System.Windows.Forms.Label();
            this.textBox_NhanXet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_NhanXet = new System.Windows.Forms.Panel();
            this.button_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_NhanXet.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_ThongTinNhanVien
            // 
            this.label_ThongTinNhanVien.AutoSize = true;
            this.label_ThongTinNhanVien.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_ThongTinNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(15)))));
            this.label_ThongTinNhanVien.Location = new System.Drawing.Point(22, 21);
            this.label_ThongTinNhanVien.Name = "label_ThongTinNhanVien";
            this.label_ThongTinNhanVien.Size = new System.Drawing.Size(181, 30);
            this.label_ThongTinNhanVien.TabIndex = 13;
            this.label_ThongTinNhanVien.Text = "ĐÁNH GIÁ SÁCH";
            this.label_ThongTinNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label_TenSach
            // 
            this.label_TenSach.AutoSize = true;
            this.label_TenSach.BackColor = System.Drawing.Color.Transparent;
            this.label_TenSach.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_TenSach.Location = new System.Drawing.Point(191, 101);
            this.label_TenSach.Name = "label_TenSach";
            this.label_TenSach.Size = new System.Drawing.Size(0, 25);
            this.label_TenSach.TabIndex = 15;
            // 
            // label_TacGia
            // 
            this.label_TacGia.AutoSize = true;
            this.label_TacGia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TacGia.Location = new System.Drawing.Point(191, 128);
            this.label_TacGia.Name = "label_TacGia";
            this.label_TacGia.Size = new System.Drawing.Size(0, 20);
            this.label_TacGia.TabIndex = 16;
            // 
            // RatingStar
            // 
            this.RatingStar.BackColor = System.Drawing.Color.Transparent;
            this.RatingStar.BorderColor = System.Drawing.Color.Gold;
            this.RatingStar.FocusedColor = System.Drawing.Color.Gold;
            this.RatingStar.Location = new System.Drawing.Point(132, 193);
            this.RatingStar.Name = "RatingStar";
            this.RatingStar.RatingColor = System.Drawing.Color.Gold;
            this.RatingStar.ReadOnly = true;
            this.RatingStar.Size = new System.Drawing.Size(120, 28);
            this.RatingStar.TabIndex = 17;
            // 
            // label_ChatLuong
            // 
            this.label_ChatLuong.AutoSize = true;
            this.label_ChatLuong.BackColor = System.Drawing.Color.Transparent;
            this.label_ChatLuong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChatLuong.Location = new System.Drawing.Point(38, 199);
            this.label_ChatLuong.Name = "label_ChatLuong";
            this.label_ChatLuong.Size = new System.Drawing.Size(78, 17);
            this.label_ChatLuong.TabIndex = 18;
            this.label_ChatLuong.Text = "Chất lượng:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.panel2.Location = new System.Drawing.Point(27, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 3);
            this.panel2.TabIndex = 20;
            // 
            // button_Edit
            // 
            this.button_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.button_Edit.FlatAppearance.BorderSize = 0;
            this.button_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Edit.Location = new System.Drawing.Point(378, 414);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(200, 48);
            this.button_Edit.TabIndex = 22;
            this.button_Edit.Text = "Chỉnh sửa nhận xét";
            this.button_Edit.UseVisualStyleBackColor = false;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // label_NhanXet
            // 
            this.label_NhanXet.AutoSize = true;
            this.label_NhanXet.BackColor = System.Drawing.Color.Transparent;
            this.label_NhanXet.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NhanXet.Location = new System.Drawing.Point(38, 226);
            this.label_NhanXet.Name = "label_NhanXet";
            this.label_NhanXet.Size = new System.Drawing.Size(67, 17);
            this.label_NhanXet.TabIndex = 23;
            this.label_NhanXet.Text = "Nhận xét:";
            // 
            // textBox_NhanXet
            // 
            this.textBox_NhanXet.BackColor = System.Drawing.Color.White;
            this.textBox_NhanXet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_NhanXet.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox_NhanXet.Location = new System.Drawing.Point(13, 15);
            this.textBox_NhanXet.Multiline = true;
            this.textBox_NhanXet.Name = "textBox_NhanXet";
            this.textBox_NhanXet.ReadOnly = true;
            this.textBox_NhanXet.Size = new System.Drawing.Size(516, 111);
            this.textBox_NhanXet.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 0;
            // 
            // panel_NhanXet
            // 
            this.panel_NhanXet.BackColor = System.Drawing.Color.Transparent;
            this.panel_NhanXet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_NhanXet.Controls.Add(this.label2);
            this.panel_NhanXet.Controls.Add(this.textBox_NhanXet);
            this.panel_NhanXet.Location = new System.Drawing.Point(27, 257);
            this.panel_NhanXet.Name = "panel_NhanXet";
            this.panel_NhanXet.Size = new System.Drawing.Size(550, 141);
            this.panel_NhanXet.TabIndex = 19;
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Save.Location = new System.Drawing.Point(27, 414);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(96, 48);
            this.button_Save.TabIndex = 24;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // Form_DanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(606, 474);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label_NhanXet);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_ChatLuong);
            this.Controls.Add(this.RatingStar);
            this.Controls.Add(this.label_TacGia);
            this.Controls.Add(this.label_TenSach);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_ThongTinNhanVien);
            this.Controls.Add(this.panel_NhanXet);
            this.Name = "Form_DanhGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_DanhGia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_NhanXet.ResumeLayout(false);
            this.panel_NhanXet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ThongTinNhanVien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_TenSach;
        private System.Windows.Forms.Label label_TacGia;
        private Guna.UI2.WinForms.Guna2RatingStar RatingStar;
        private System.Windows.Forms.Label label_ChatLuong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Label label_NhanXet;
        private System.Windows.Forms.TextBox textBox_NhanXet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_NhanXet;
        private System.Windows.Forms.Button button_Save;
    }
}