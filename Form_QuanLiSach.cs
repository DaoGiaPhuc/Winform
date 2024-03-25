//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Test_Desktop.Form_Admin
//{
//    public partial class Form_QuanLiSach : Form
//    {
//        public Form_QuanLiSach()
//        {
//            InitializeComponent();
//            LoadData();
//            panel_XoaSach.Height = 0;
//        }
//        //Search function
//        #region Search function
//        private void textBox_SearchName_TextChanged(object sender, EventArgs e)
//        {
//            if (textBox_SearchName.Text.Length != 0)
//            {
//                label_SearchName.Text = ""; //Nếu text trong ô textBox được nhập thì xóa label Search 
//                using (NhanVienEntities db = new NhanVienEntities())
//                {
//                    var result = db.TaiKhoan.Where(c => c.HoTen == textBox_SearchName.Text);
//                    if (result != null)
//                        dataGridView_ChinhSuaSach.DataSource = result.ToList();
//                }
//            }
//            else
//            {
//                label_SearchName.Text = "Search by name"; //Nếu text rỗng thì hiện lại label Search
//                LoadData();
//            }
//        }

//        private void textBox_SearchName_Click(object sender, EventArgs e)
//        {
//            if (textBox_SearchName.Text.Length == 0) label_SearchName.Text = ""; //TextBox được click thì xóa label Search
//        }

//        private void label_SearchName_Click(object sender, EventArgs e)
//        {
//            textBox_SearchName.Focus(); //Nếu click vào label Search thì chuyển Focus vào textBox
//            label_SearchName.Text = ""; //Xóa label Search
//        }
//        #endregion

//        static int pageNumber = 1;
//        static int numberRecord = 5;
//        static int totalRecord = 0;
//        static int lastPageNumber = 0;

//        void LoadData()
//        {
//            using (NhanVienEntities db = new NhanVienEntities())
//            {
//                totalRecord = db.Sach.Count();
//            }
//            lastPageNumber = (int)Math.Ceiling((double)totalRecord / numberRecord);
//            dataGridView_ChinhSuaSach.DataSource = LoadRecord(pageNumber, numberRecord);
//            AdjustRowHeight();
//            AdjustColumnWidth();
//            ChangeHeader();

//        }

//        List<object> LoadRecord(int page, int recordNum)
//        {
//            List<object> result = new List<object>();
//            using (NhanVienEntities db = new NhanVienEntities())
//            {
//                result = db.Sach.OrderBy(e => e.IDSach)
//                    .Skip((page - 1) * recordNum)
//                    .Take(recordNum)
//                    .Select(e => new
//                    {
//                        e.IDSach,
//                        e.TenSach,
//                        e.TacGia,
//                        e.TheLoai,
//                        e.SoLuong,
//                        e.NhaXuatBan,
//                        e.NamXuatBan
//                    }).ToList<object>();
//            }
//            return result;
//        }

//        public void AdjustRowHeight()
//        {
//            int desiredHeight = dataGridView_ChinhSuaSach.Height / (dataGridView_ChinhSuaSach.Rows.Count + 1);

//            // Thiết lập chiều cao cho mỗi dòng
//            foreach (DataGridViewRow row in dataGridView_ChinhSuaSach.Rows)
//            {
//                row.Height = desiredHeight;
//            }
//        }

//        private void AdjustColumnWidth()
//        {
//            dataGridView_ChinhSuaSach.Columns[0].Width = dataGridView_ChinhSuaSach.Width * 5 / 100;
//            dataGridView_ChinhSuaSach.Columns[1].Width = dataGridView_ChinhSuaSach.Width * 20 / 100;
//            dataGridView_ChinhSuaSach.Columns[2].Width = dataGridView_ChinhSuaSach.Width * 20 / 100;
//            dataGridView_ChinhSuaSach.Columns[3].Width = dataGridView_ChinhSuaSach.Width * 10 / 100;
//            dataGridView_ChinhSuaSach.Columns[4].Width = dataGridView_ChinhSuaSach.Width * 10 / 100;
//            dataGridView_ChinhSuaSach.Columns[5].Width = dataGridView_ChinhSuaSach.Width * 20 / 100;
//            dataGridView_ChinhSuaSach.Columns[6].Width = dataGridView_ChinhSuaSach.Width * 15 / 100;
//        }

//        private void ChangeHeader()
//        {
//            dataGridView_ChinhSuaSach.Columns[0].HeaderText = "ID";
//            dataGridView_ChinhSuaSach.Columns[1].HeaderText = "Tên sách";
//            dataGridView_ChinhSuaSach.Columns[2].HeaderText = "Tác giả";
//            dataGridView_ChinhSuaSach.Columns[3].HeaderText = "Thể loại";
//            dataGridView_ChinhSuaSach.Columns[4].HeaderText = "Số lượng";
//            dataGridView_ChinhSuaSach.Columns[5].HeaderText = "Nhà xuất bản";
//            dataGridView_ChinhSuaSach.Columns[6].HeaderText = "Năm xuất bản";
//        }

//        List<Button> buttonChangePageList = new List<Button>();
//        private void AddButtonChangePageList()
//        {
//            buttonChangePageList.Add(button_ChangePage1);
//            buttonChangePageList.Add(button_ChangePage2);
//            buttonChangePageList.Add(button_ChangePage3);
//            buttonChangePageList.Add(button_ReturnFirstPage);
//            buttonChangePageList.Add(button_ReturnLastPage);
//        }

//        private void ResetColorButton()
//        {
//            AddButtonChangePageList();
//            foreach (Button button in buttonChangePageList)
//            {
//                button.BackColor = Color.White;
//                button.ForeColor = Color.Black;
//            }
//        }

//        private void HighlightButtonCurrentPage(object obj)
//        {
//            Button sender = obj as Button;
//            sender.BackColor = Color.FromArgb(0, 95, 105);
//        }


//        bool menuExpand = false; //Biến hiển thị độ mở rộng của button con
//        private void Sidebar_Transition(ref bool menuExpand, Panel panel, Timer timer) //Func để mở rộng và thu nhỏ các button con
//        {
//            if (menuExpand == false)
//            {
//                panel.Height += 5;
//                if (panel.Height >= 195)
//                {
//                    timer.Stop();
//                    menuExpand = true;
//                }
//            }
//            else
//            {
//                panel.Height -= 5;
//                if (panel.Height <= 0)
//                {
//                    timer.Stop();
//                    menuExpand = false;
//                }
//            }
//        }

//        private void StartTimer(Timer timer) //Func để Start Timer
//        {
//            timer.Start();
//        }

//        private void StopTimer(Timer timer)
//        {
//            timer.Stop();
//        }

//        private void timer_ChinhSuaSachTransition_Tick(object sender, EventArgs e)
//        {
//            Sidebar_Transition(ref menuExpand, panel_XoaSach, timer_ChinhSuaTaiKhoanTransition);
//        }

//        private void Form_ChinhSuaSach_Resize(object sender, EventArgs e)
//        {
//            AdjustRowHeight();
//            AdjustColumnWidth();
//        }

//        private void button_ChangePage1_Click(object sender, EventArgs e)
//        {
//            pageNumber = Convert.ToInt32(button_ChangePage1.Text);

//            if (button_ChangePage1.Text != "1")
//            {
//                LoadData();
//                int currentPage = Convert.ToInt32(button_ChangePage1.Text);
//                button_ChangePage1.Text = (currentPage - 1).ToString();
//                button_ChangePage2.Text = currentPage.ToString();
//                button_ChangePage3.Text = (currentPage + 1).ToString();
//                ResetColorButton();
//                HighlightButtonCurrentPage(button_ChangePage2);
//            }
//            else
//            {
//                LoadData();
//                ResetColorButton();
//                HighlightButtonCurrentPage(button_ChangePage1);
//            }
//        }

//        private void button_ChangePage2_Click(object sender, EventArgs e)
//        {
//            pageNumber = Convert.ToInt32(button_ChangePage2.Text);
//            LoadData();
//            ResetColorButton();
//            HighlightButtonCurrentPage(sender);
//        }

//        private void button_ChangePage3_Click(object sender, EventArgs e)
//        {
//            pageNumber = Convert.ToInt32(button_ChangePage3.Text);
//            if (lastPageNumber > pageNumber)
//            {
//                LoadData();
//                int currentPage = Convert.ToInt32(button_ChangePage3.Text);
//                button_ChangePage1.Text = (currentPage - 1).ToString();
//                button_ChangePage2.Text = currentPage.ToString();
//                button_ChangePage3.Text = (currentPage + 1).ToString();
//                ResetColorButton();
//                HighlightButtonCurrentPage(button_ChangePage2);
//            }
//            else
//            {
//                LoadData();
//                ResetColorButton();
//                HighlightButtonCurrentPage(button_ChangePage3);
//            }
//        }

//        private void button_ReturnFirstPage_Click(object sender, EventArgs e)
//        {
//            pageNumber = 1;
//            LoadData();
//            ResetColorButton();
//            HighlightButtonCurrentPage(sender);
//            button_ChangePage1.Text = "1";
//            button_ChangePage2.Text = "2";
//            button_ChangePage3.Text = "3";
//        }

//        private void button_ReturnLastPage_Click(object sender, EventArgs e)
//        {
//            pageNumber = lastPageNumber;
//            LoadData();
//            ResetColorButton();
//            HighlightButtonCurrentPage(sender);
//            button_ChangePage1.Text = (lastPageNumber - 2).ToString();
//            button_ChangePage2.Text = (lastPageNumber - 1).ToString();
//            button_ChangePage3.Text = lastPageNumber.ToString();
//        }

//        private void dataGridView_ChinhSuaSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
//        {
//            menuExpand = false;
//            StartTimer(timer_ChinhSuaTaiKhoanTransition); //Start Timer của CSTK
//            if (panel_XoaSach.Height == 195) StopTimer(timer_ChinhSuaTaiKhoanTransition);
//        }

//        private void dataGridView_ChinhSuaSach_CellClick(object sender, DataGridViewCellEventArgs e)
//        {
//            int selectedID = Convert.ToInt32(dataGridView_ChinhSuaSach.SelectedCells[0].OwningRow.Cells["IDSach"].Value.ToString());
//            using (NhanVienEntities db = new NhanVienEntities())
//            {
//                Sach sach = db.Sach.Find(selectedID);
//                textBox_IDSachUpdateInput.Text = sach.IDSach.ToString();
//                textBox_TenSachUpdateInput.Text = sach.TenSach;
//                textBox_TacGiaUpdateInput.Text = sach.TacGia;
//                textBox_TheLoaiUpdateInput.Text = sach.TheLoai;
//                textBox_NhaXuatBanUpdateInput.Text = sach.NhaXuatBan;
//                dateTimePicker_NamXuatBanUpdateInput.Value = (DateTime)sach.NamXuatBan;
//            }
//        }

//        private void button_SaveUpdate_Click(object sender, EventArgs e)
//        {
//            int selectedID = Convert.ToInt32(dataGridView_ChinhSuaSach.SelectedCells[0].OwningRow.Cells["IDSach"].Value.ToString());
//            using (NhanVienEntities db = new NhanVienEntities())
//            {
//                Sach sach = db.Sach.Find(selectedID);
//                List<string> updateFields = new List<string>();

//                if (textBox_TenSachUpdateInput.Text != sach.TenSach)
//                    updateFields.Add("Tên sách");
//                if (textBox_TacGiaUpdateInput.Text != sach.TacGia)
//                    updateFields.Add("Tác giả");
//                if (textBox_TheLoaiUpdateInput.Text != sach.TheLoai)
//                    updateFields.Add("Thể loại");
//                if (textBox_SoLuongUpdateInput.Text != sach.SoLuong.ToString())
//                    updateFields.Add("Số lượng");
//                if (textBox_NhaXuatBanUpdateInput.Text != sach.NhaXuatBan)
//                    updateFields.Add("Nhà xuất bản");
//                if (dateTimePicker_NamXuatBanUpdateInput.Value != (DateTime)sach.NamXuatBan)
//                    updateFields.Add("Năm xuất bản");


//                string updateFieldMessage = "Bạn muốn thay đổi \n";
//                foreach (string field in updateFields)
//                {
//                    updateFieldMessage += field + "\n";
//                }
//                updateFieldMessage += $"của sách {sach.TenSach}";

//                DialogResult result = MessageBox.Show(updateFieldMessage, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
//                if (result == DialogResult.Yes)
//                {
//                    sach.TenSach = textBox_TenSachUpdateInput.Text;
//                    sach.TacGia = textBox_TacGiaUpdateInput.Text;
//                    sach.TheLoai = textBox_TheLoaiUpdateInput.Text;
//                    sach.SoLuong = Convert.ToInt32(textBox_SoLuongUpdateInput.Text);
//                    sach.NhaXuatBan = textBox_NhaXuatBanUpdateInput.Text;
//                    sach.NamXuatBan = dateTimePicker_NamXuatBanUpdateInput.Value;
//                    db.SaveChanges();
//                    MessageBox.Show("Chỉnh sửa thông tin sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    LoadData();
//                }
//                else
//                {
//                    MessageBox.Show("Chỉnh sửa thông tin sách thất bại");
//                }
//            }
//        }

//        private void pictureBox_Exit_Click(object sender, EventArgs e)
//        {
//            menuExpand = true;
//            StartTimer(timer_ChinhSuaTaiKhoanTransition); //Start Timer của panel_XoaSach
//        }
//    }
//}
