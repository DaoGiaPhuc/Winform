namespace Test_Desktop
{
    partial class UserControlDay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Day = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Day
            // 
            this.label_Day.AutoSize = true;
            this.label_Day.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Day.Location = new System.Drawing.Point(12, 9);
            this.label_Day.Name = "label_Day";
            this.label_Day.Size = new System.Drawing.Size(28, 21);
            this.label_Day.TabIndex = 0;
            this.label_Day.Text = "00";
            this.label_Day.MouseLeave += new System.EventHandler(this.UserControlDay_MouseLeave);
            this.label_Day.MouseHover += new System.EventHandler(this.UserControlDay_MouseHover);
            // 
            // UserControlDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_Day);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UserControlDay";
            this.Size = new System.Drawing.Size(45, 45);
            this.Load += new System.EventHandler(this.UserControlDay_Load);
            this.MouseLeave += new System.EventHandler(this.UserControlDay_MouseLeave);
            this.MouseHover += new System.EventHandler(this.UserControlDay_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Day;
    }
}
