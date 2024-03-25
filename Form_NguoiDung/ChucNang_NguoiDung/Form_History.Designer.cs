namespace Test_Desktop
{
    partial class Form_History
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Search = new System.Windows.Forms.Panel();
            this.label_SearchName = new System.Windows.Forms.Label();
            this.textBox_SearchName = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.label_ThongTinNhanVien = new System.Windows.Forms.Label();
            this.dataGridView_History = new System.Windows.Forms.DataGridView();
            this.button_ReturnLastPage = new System.Windows.Forms.Button();
            this.button_ReturnFirstPage = new System.Windows.Forms.Button();
            this.label_Previous = new System.Windows.Forms.Label();
            this.button_ChangePage3 = new System.Windows.Forms.Button();
            this.button_ChangePage1 = new System.Windows.Forms.Button();
            this.label_Next = new System.Windows.Forms.Label();
            this.button_ChangePage2 = new System.Windows.Forms.Button();
            this.panel_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_History)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Search
            // 
            this.panel_Search.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Search.Controls.Add(this.label_SearchName);
            this.panel_Search.Controls.Add(this.textBox_SearchName);
            this.panel_Search.Location = new System.Drawing.Point(40, 68);
            this.panel_Search.Name = "panel_Search";
            this.panel_Search.Size = new System.Drawing.Size(295, 39);
            this.panel_Search.TabIndex = 10;
            // 
            // label_SearchName
            // 
            this.label_SearchName.AutoSize = true;
            this.label_SearchName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SearchName.ForeColor = System.Drawing.Color.DimGray;
            this.label_SearchName.Location = new System.Drawing.Point(12, 8);
            this.label_SearchName.Name = "label_SearchName";
            this.label_SearchName.Size = new System.Drawing.Size(130, 21);
            this.label_SearchName.TabIndex = 10;
            this.label_SearchName.Text = "Search by name...";
            // 
            // textBox_SearchName
            // 
            this.textBox_SearchName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_SearchName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_SearchName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SearchName.Location = new System.Drawing.Point(2, 8);
            this.textBox_SearchName.Name = "textBox_SearchName";
            this.textBox_SearchName.Size = new System.Drawing.Size(275, 22);
            this.textBox_SearchName.TabIndex = 7;
            // 
            // button_Search
            // 
            this.button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.button_Search.FlatAppearance.BorderSize = 0;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.ForeColor = System.Drawing.Color.White;
            this.button_Search.Location = new System.Drawing.Point(652, 68);
            this.button_Search.Margin = new System.Windows.Forms.Padding(2);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(155, 39);
            this.button_Search.TabIndex = 11;
            this.button_Search.Text = "SEARCH";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // label_ThongTinNhanVien
            // 
            this.label_ThongTinNhanVien.AutoSize = true;
            this.label_ThongTinNhanVien.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ThongTinNhanVien.Location = new System.Drawing.Point(35, 26);
            this.label_ThongTinNhanVien.Name = "label_ThongTinNhanVien";
            this.label_ThongTinNhanVien.Size = new System.Drawing.Size(216, 30);
            this.label_ThongTinNhanVien.TabIndex = 12;
            this.label_ThongTinNhanVien.Text = "LỊCH SỬ MƯỢN TRẢ";
            this.label_ThongTinNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView_History
            // 
            this.dataGridView_History.AllowUserToAddRows = false;
            this.dataGridView_History.AllowUserToDeleteRows = false;
            this.dataGridView_History.AllowUserToResizeColumns = false;
            this.dataGridView_History.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_History.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_History.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_History.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_History.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_History.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_History.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_History.ColumnHeadersHeight = 40;
            this.dataGridView_History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_History.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView_History.EnableHeadersVisualStyles = false;
            this.dataGridView_History.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_History.Location = new System.Drawing.Point(40, 131);
            this.dataGridView_History.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_History.Name = "dataGridView_History";
            this.dataGridView_History.ReadOnly = true;
            this.dataGridView_History.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_History.RowHeadersVisible = false;
            this.dataGridView_History.RowHeadersWidth = 100;
            this.dataGridView_History.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.dataGridView_History.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_History.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_History.Size = new System.Drawing.Size(784, 391);
            this.dataGridView_History.TabIndex = 0;
            this.dataGridView_History.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_History_CellDoubleClick);
            // 
            // button_ReturnLastPage
            // 
            this.button_ReturnLastPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ReturnLastPage.BackColor = System.Drawing.Color.White;
            this.button_ReturnLastPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.button_ReturnLastPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.button_ReturnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ReturnLastPage.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ReturnLastPage.ForeColor = System.Drawing.Color.Black;
            this.button_ReturnLastPage.Location = new System.Drawing.Point(711, 542);
            this.button_ReturnLastPage.Name = "button_ReturnLastPage";
            this.button_ReturnLastPage.Size = new System.Drawing.Size(40, 40);
            this.button_ReturnLastPage.TabIndex = 26;
            this.button_ReturnLastPage.Text = ">>";
            this.button_ReturnLastPage.UseVisualStyleBackColor = false;
            this.button_ReturnLastPage.Click += new System.EventHandler(this.button_ReturnLastPage_Click);
            // 
            // button_ReturnFirstPage
            // 
            this.button_ReturnFirstPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ReturnFirstPage.BackColor = System.Drawing.Color.White;
            this.button_ReturnFirstPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.button_ReturnFirstPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.button_ReturnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ReturnFirstPage.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ReturnFirstPage.ForeColor = System.Drawing.Color.Black;
            this.button_ReturnFirstPage.Location = new System.Drawing.Point(476, 542);
            this.button_ReturnFirstPage.Name = "button_ReturnFirstPage";
            this.button_ReturnFirstPage.Size = new System.Drawing.Size(40, 40);
            this.button_ReturnFirstPage.TabIndex = 25;
            this.button_ReturnFirstPage.Text = "<<";
            this.button_ReturnFirstPage.UseVisualStyleBackColor = false;
            this.button_ReturnFirstPage.Click += new System.EventHandler(this.button_ReturnFirstPage_Click);
            // 
            // label_Previous
            // 
            this.label_Previous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Previous.AutoSize = true;
            this.label_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Previous.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Previous.Location = new System.Drawing.Point(387, 550);
            this.label_Previous.Name = "label_Previous";
            this.label_Previous.Size = new System.Drawing.Size(84, 25);
            this.label_Previous.TabIndex = 20;
            this.label_Previous.Text = "Previous";
            // 
            // button_ChangePage3
            // 
            this.button_ChangePage3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ChangePage3.BackColor = System.Drawing.Color.White;
            this.button_ChangePage3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.button_ChangePage3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.button_ChangePage3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ChangePage3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChangePage3.ForeColor = System.Drawing.Color.Black;
            this.button_ChangePage3.Location = new System.Drawing.Point(653, 542);
            this.button_ChangePage3.Name = "button_ChangePage3";
            this.button_ChangePage3.Size = new System.Drawing.Size(40, 40);
            this.button_ChangePage3.TabIndex = 24;
            this.button_ChangePage3.Text = "3";
            this.button_ChangePage3.UseVisualStyleBackColor = false;
            this.button_ChangePage3.Click += new System.EventHandler(this.button_ChangePage3_Click);
            // 
            // button_ChangePage1
            // 
            this.button_ChangePage1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ChangePage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.button_ChangePage1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.button_ChangePage1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.button_ChangePage1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ChangePage1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChangePage1.ForeColor = System.Drawing.Color.White;
            this.button_ChangePage1.Location = new System.Drawing.Point(536, 542);
            this.button_ChangePage1.Name = "button_ChangePage1";
            this.button_ChangePage1.Size = new System.Drawing.Size(40, 40);
            this.button_ChangePage1.TabIndex = 21;
            this.button_ChangePage1.Text = "1";
            this.button_ChangePage1.UseVisualStyleBackColor = false;
            this.button_ChangePage1.Click += new System.EventHandler(this.button_ChangePage1_Click);
            // 
            // label_Next
            // 
            this.label_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Next.AutoSize = true;
            this.label_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Next.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Next.Location = new System.Drawing.Point(756, 550);
            this.label_Next.Name = "label_Next";
            this.label_Next.Size = new System.Drawing.Size(51, 25);
            this.label_Next.TabIndex = 23;
            this.label_Next.Text = "Next";
            // 
            // button_ChangePage2
            // 
            this.button_ChangePage2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ChangePage2.BackColor = System.Drawing.Color.White;
            this.button_ChangePage2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.button_ChangePage2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.button_ChangePage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ChangePage2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChangePage2.ForeColor = System.Drawing.Color.Black;
            this.button_ChangePage2.Location = new System.Drawing.Point(595, 542);
            this.button_ChangePage2.Name = "button_ChangePage2";
            this.button_ChangePage2.Size = new System.Drawing.Size(40, 40);
            this.button_ChangePage2.TabIndex = 22;
            this.button_ChangePage2.Text = "2";
            this.button_ChangePage2.UseVisualStyleBackColor = false;
            this.button_ChangePage2.Click += new System.EventHandler(this.button_ChangePage2_Click);
            // 
            // Form_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 594);
            this.Controls.Add(this.button_ReturnLastPage);
            this.Controls.Add(this.button_ReturnFirstPage);
            this.Controls.Add(this.label_Previous);
            this.Controls.Add(this.button_ChangePage3);
            this.Controls.Add(this.button_ChangePage1);
            this.Controls.Add(this.label_Next);
            this.Controls.Add(this.button_ChangePage2);
            this.Controls.Add(this.dataGridView_History);
            this.Controls.Add(this.label_ThongTinNhanVien);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.panel_Search);
            this.Name = "Form_History";
            this.Text = "Form_History";
            this.Resize += new System.EventHandler(this.FormHistory_Resize);
            this.panel_Search.ResumeLayout(false);
            this.panel_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_History)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Search;
        private System.Windows.Forms.Label label_SearchName;
        private System.Windows.Forms.TextBox textBox_SearchName;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label_ThongTinNhanVien;
        private System.Windows.Forms.DataGridView dataGridView_History;
        private System.Windows.Forms.Button button_ReturnLastPage;
        private System.Windows.Forms.Button button_ReturnFirstPage;
        private System.Windows.Forms.Label label_Previous;
        private System.Windows.Forms.Button button_ChangePage3;
        private System.Windows.Forms.Button button_ChangePage1;
        private System.Windows.Forms.Label label_Next;
        private System.Windows.Forms.Button button_ChangePage2;
    }
}