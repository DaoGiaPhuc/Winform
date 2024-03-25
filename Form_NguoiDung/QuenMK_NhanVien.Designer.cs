namespace Test_Desktop
{
    partial class QuenMK_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuenMK_NhanVien));
            this.button_SignUp = new System.Windows.Forms.Button();
            this.pictureBox_UehLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_Username = new System.Windows.Forms.Label();
            this.panel_Username = new System.Windows.Forms.Panel();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UehLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_Username.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_SignUp
            // 
            this.button_SignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_SignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.button_SignUp.FlatAppearance.BorderSize = 0;
            this.button_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SignUp.ForeColor = System.Drawing.Color.White;
            this.button_SignUp.Location = new System.Drawing.Point(81, 390);
            this.button_SignUp.Name = "button_SignUp";
            this.button_SignUp.Size = new System.Drawing.Size(280, 38);
            this.button_SignUp.TabIndex = 15;
            this.button_SignUp.Text = "Lấy Mật khẩu mới";
            this.button_SignUp.UseVisualStyleBackColor = false;
            this.button_SignUp.Click += new System.EventHandler(this.button_SignUp_Click);
            // 
            // pictureBox_UehLogo
            // 
            this.pictureBox_UehLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_UehLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_UehLogo.Image")));
            this.pictureBox_UehLogo.Location = new System.Drawing.Point(164, 42);
            this.pictureBox_UehLogo.Name = "pictureBox_UehLogo";
            this.pictureBox_UehLogo.Size = new System.Drawing.Size(115, 85);
            this.pictureBox_UehLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_UehLogo.TabIndex = 14;
            this.pictureBox_UehLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Vui lòng nhập ID";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.textBox_ID);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(81, 277);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 43);
            this.panel1.TabIndex = 13;
            // 
            // textBox_ID
            // 
            this.textBox_ID.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID.Location = new System.Drawing.Point(3, 8);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(274, 26);
            this.textBox_ID.TabIndex = 4;
            this.textBox_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ID_KeyPress);
            // 
            // label_Username
            // 
            this.label_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(130, 167);
            this.label_Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(182, 21);
            this.label_Username.TabIndex = 10;
            this.label_Username.Text = "Vui lòng nhập Username";
            // 
            // panel_Username
            // 
            this.panel_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_Username.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_Username.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Username.Controls.Add(this.textBox_Username);
            this.panel_Username.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_Username.Location = new System.Drawing.Point(81, 190);
            this.panel_Username.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Username.Name = "panel_Username";
            this.panel_Username.Size = new System.Drawing.Size(280, 43);
            this.panel_Username.TabIndex = 11;
            // 
            // textBox_Username
            // 
            this.textBox_Username.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Username.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username.Location = new System.Drawing.Point(3, 8);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(274, 26);
            this.textBox_Username.TabIndex = 4;
            // 
            // QuenMK_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 518);
            this.Controls.Add(this.button_SignUp);
            this.Controls.Add(this.pictureBox_UehLogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.panel_Username);
            this.Name = "QuenMK_NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuenMK_NhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UehLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Username.ResumeLayout(false);
            this.panel_Username.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_SignUp;
        private System.Windows.Forms.PictureBox pictureBox_UehLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Panel panel_Username;
        private System.Windows.Forms.TextBox textBox_Username;
    }
}