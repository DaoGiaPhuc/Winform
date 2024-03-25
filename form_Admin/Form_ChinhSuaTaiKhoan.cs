using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Test_Desktop
{
    public partial class Form_ChinhSuaTaiKhoan : Form
    {
        public Form_ChinhSuaTaiKhoan()
        {
            InitializeComponent();
            AddDataSourceComboBox();
            LoadData();
            panel_ChinhSuaTaiKhoan.Height = 0;
        }

        //Search function
        #region Search function
        private void textBox_SearchName_TextChanged(object sender, EventArgs e)
        {
            if (textBox_SearchName.Text.Length != 0)
            {
                label_SearchName.Text = ""; //Nếu text trong ô textBox được nhập thì xóa label Search 
                using (NhanVienEntities db = new NhanVienEntities())
                {
                    var result = db.TaiKhoan.Where(c => c.HoTen.Contains(textBox_SearchName.Text));
                    if (result != null)
                        dataGridView_ChinhSuaTaiKhoan.DataSource = result.ToList();
                }
            }
            else
            {
                label_SearchName.Text = "Search by name"; //Nếu text rỗng thì hiện lại label Search
                LoadData();
            }
        }

        private void textBox_SearchName_Click(object sender, EventArgs e)
        {
            if (textBox_SearchName.Text.Length == 0) label_SearchName.Text = ""; //TextBox được click thì xóa label Search
        }

        private void label_SearchName_Click(object sender, EventArgs e)
        {
            textBox_SearchName.Focus(); //Nếu click vào label Search thì chuyển Focus vào textBox
            label_SearchName.Text = ""; //Xóa label Search
        }
        #endregion

        private void AddDataSourceComboBox()
        {
            string[] GioiTinhs = { "Nam", "Nữ" };
            comboBox_GioiTinhUpdateInput.DataSource = GioiTinhs;
            comboBox_GioiTinhUpdateInput.SelectedIndex = -1;

            string[] ChucVus = { "Manager", "Staff" };
            comboBox_ChucVuUpdateInput.DataSource = ChucVus;
            comboBox_ChucVuUpdateInput.SelectedIndex = -1;
        }

        static int pageNumber = 1;
        static int numberRecord = 5;
        static int totalRecord = 0;
        static int lastPageNumber = 0;

        void LoadData()
        {
            using (NhanVienEntities db = new NhanVienEntities())
            {
                totalRecord = db.TaiKhoan.Count();
            }
            lastPageNumber = (int)Math.Ceiling((double)totalRecord / numberRecord);
            dataGridView_ChinhSuaTaiKhoan.DataSource = LoadRecord(pageNumber, numberRecord);
            AdjustRowHeight();
            AdjustColumnWidth();
            ChangeHeader();

        }

        List<object> LoadRecord(int page, int recordNum)
        {
            List<object> result = new List<object>();
            using (NhanVienEntities db = new NhanVienEntities())
            {
                result = db.TaiKhoan.OrderBy(e => e.IDTaiKhoan)
                    .Skip((page - 1) * recordNum)
                    .Take(recordNum)
                    .Select(e => new
                    {
                        IDTaiKhoan = e.IDTaiKhoan,
                        HoTen = e.HoTen,
                        GioiTinh = e.GioiTinh,
                        ChucVu = e.ChucVu,
                        Email = e.Email,
                        SoDienThoai = e.SoDienThoai,
                        MatKhau = e.MatKhau,
                    }).ToList<object>();
            }
            return result;
        }

        public void AdjustRowHeight()
        {
            int desiredHeight = dataGridView_ChinhSuaTaiKhoan.Height / (dataGridView_ChinhSuaTaiKhoan.Rows.Count + 1);

            // Thiết lập chiều cao cho mỗi dòng
            foreach (DataGridViewRow row in dataGridView_ChinhSuaTaiKhoan.Rows)
            {
                row.Height = desiredHeight;
            }
        }

        private void AdjustColumnWidth()
        {
            dataGridView_ChinhSuaTaiKhoan.Columns[0].Width = dataGridView_ChinhSuaTaiKhoan.Width * 5 / 100;
            dataGridView_ChinhSuaTaiKhoan.Columns[1].Width = dataGridView_ChinhSuaTaiKhoan.Width * 20 / 100;
            dataGridView_ChinhSuaTaiKhoan.Columns[2].Width = dataGridView_ChinhSuaTaiKhoan.Width * 10 / 100;
            dataGridView_ChinhSuaTaiKhoan.Columns[3].Width = dataGridView_ChinhSuaTaiKhoan.Width * 10 / 100;
            dataGridView_ChinhSuaTaiKhoan.Columns[4].Width = dataGridView_ChinhSuaTaiKhoan.Width * 30 / 100;
            dataGridView_ChinhSuaTaiKhoan.Columns[5].Width = dataGridView_ChinhSuaTaiKhoan.Width * 12 / 100;
            dataGridView_ChinhSuaTaiKhoan.Columns[6].Width = dataGridView_ChinhSuaTaiKhoan.Width * 13 / 100;
        }

        private void ChangeHeader()
        {
            dataGridView_ChinhSuaTaiKhoan.Columns[0].HeaderText = "ID";
            dataGridView_ChinhSuaTaiKhoan.Columns[1].HeaderText = "Tên";
            dataGridView_ChinhSuaTaiKhoan.Columns[2].HeaderText = "Giới tính";
            dataGridView_ChinhSuaTaiKhoan.Columns[3].HeaderText = "Chức vụ";
            dataGridView_ChinhSuaTaiKhoan.Columns[4].HeaderText = "Email";
            dataGridView_ChinhSuaTaiKhoan.Columns[5].HeaderText = "Sđt";
            dataGridView_ChinhSuaTaiKhoan.Columns[6].HeaderText = "Mật khẩu";
        }

        List<Button> buttonChangePageList = new List<Button>();
        private void AddButtonChangePageList()
        {
            buttonChangePageList.Add(button_ChangePage1);
            buttonChangePageList.Add(button_ChangePage2);
            buttonChangePageList.Add(button_ChangePage3);
            buttonChangePageList.Add(button_ReturnFirstPage);
            buttonChangePageList.Add(button_ReturnLastPage);
        }

        private void ResetColorButton()
        {
            AddButtonChangePageList();
            foreach (Button button in buttonChangePageList)
            {
                button.BackColor = Color.White;
                button.ForeColor = Color.Black;
            }
        }

        private void HighlightButtonCurrentPage(object obj)
        {
            Button sender = obj as Button;
            sender.BackColor = Color.FromArgb(0, 95, 105);
        }

        bool checkInputForInsertTaiKhoan = true;
        bool checkInputForDeleteTaiKhoan = true;

        private void CheckInputForInsertTaiKhoan(ref bool check)
        {
            if (!string.IsNullOrWhiteSpace(textBox_EmailInput.Text)
                && !string.IsNullOrWhiteSpace(textBox_MatKhauInput.Text)) check = true;
            else
            {
                MessageBox.Show($"Email hoặc Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }
        }

        private void AddTaiKhoan()
        {
            DialogResult result = MessageBox.Show($"Bạn có chắc muốn tạo tài khoản có email {textBox_EmailInput.Text} không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (NhanVienEntities db = new NhanVienEntities())
                {
                    TaiKhoan taiKhoan = new TaiKhoan()
                    {
                        Email = textBox_EmailInput.Text,
                        MatKhau = textBox_MatKhauInput.Text,
                    };
                    db.TaiKhoan.AddObject(taiKhoan);
                    db.SaveChanges();
                    MessageBox.Show("Tạo tài khoản thành công");
                }
            }
            else { MessageBox.Show("Tạo tài khoản thất bại"); }
        }

        private void CheckInputForDeleteTaiKhoan(ref bool check)
        {
            if (!string.IsNullOrWhiteSpace(textBox_IDDeleteInput.Text)) check = true;
            else
            {
                MessageBox.Show($"Trường ID không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
        }

        private void DeleteTaiKhoan()
        {
            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa nhân viên có {textBox_IDDeleteInput.Text} không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (NhanVienEntities db = new NhanVienEntities())
                {
                    int idDelete = Convert.ToInt32(textBox_IDDeleteInput.Text);
                    TaiKhoan taiKhoan = db.TaiKhoan.Where(p => p.IDTaiKhoan == idDelete).SingleOrDefault();
                    db.TaiKhoan.DeleteObject(taiKhoan);
                    db.SaveChanges();
                    MessageBox.Show("Xóa nhân viên thành công");
                }
            }
            else MessageBox.Show("Xóa nhân viên thất bại");
        }

        bool menuExpand = false; //Biến hiển thị độ mở rộng của button con
        private void Sidebar_Transition(ref bool menuExpand, Panel panel, Timer timer) //Func để mở rộng và thu nhỏ các button con
        {
            if (menuExpand == false)
            {
                panel.Height += 5;
                if (panel.Height >= 195)
                {
                    timer.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                panel.Height -= 5;
                if (panel.Height <= 0)
                {
                    timer.Stop();
                    menuExpand = false;
                }
            }
        }

        private void StartTimer(Timer timer) //Func để Start Timer
        {
            timer.Start();
        }

        private void StopTimer(Timer timer)
        {
            timer.Stop();
        }

        private void timer_ChinhSuaTaiKhoanTransition_Tick(object sender, EventArgs e)
        {
            Sidebar_Transition(ref menuExpand, panel_ChinhSuaTaiKhoan, timer_ChinhSuaTaiKhoanTransition);
        }

        private void Form_ChinhSuaTaiKhoan_Resize(object sender, EventArgs e)
        {
            AdjustRowHeight();
            AdjustColumnWidth();
        }

        private void button_ChangePage1_Click(object sender, EventArgs e)
        {
            pageNumber = Convert.ToInt32(button_ChangePage1.Text);

            if (button_ChangePage1.Text != "1")
            {
                LoadData();
                int currentPage = Convert.ToInt32(button_ChangePage1.Text);
                button_ChangePage1.Text = (currentPage - 1).ToString();
                button_ChangePage2.Text = currentPage.ToString();
                button_ChangePage3.Text = (currentPage + 1).ToString();
                ResetColorButton();
                HighlightButtonCurrentPage(button_ChangePage2);
            }
            else
            {
                LoadData();
                ResetColorButton();
                HighlightButtonCurrentPage(button_ChangePage1);
            }
        }

        private void button_ChangePage2_Click(object sender, EventArgs e)
        {
            pageNumber = Convert.ToInt32(button_ChangePage2.Text);
            LoadData();
            ResetColorButton();
            HighlightButtonCurrentPage(sender);
        }

        private void button_ChangePage3_Click(object sender, EventArgs e)
        {
            pageNumber = Convert.ToInt32(button_ChangePage3.Text);
            if (lastPageNumber > pageNumber)
            {
                LoadData();
                int currentPage = Convert.ToInt32(button_ChangePage3.Text);
                button_ChangePage1.Text = (currentPage - 1).ToString();
                button_ChangePage2.Text = currentPage.ToString();
                button_ChangePage3.Text = (currentPage + 1).ToString();
                ResetColorButton();
                HighlightButtonCurrentPage(button_ChangePage2);
            }
            else
            {
                LoadData();
                ResetColorButton();
                HighlightButtonCurrentPage(button_ChangePage3);
            }
        }

        private void button_ReturnFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            LoadData();
            ResetColorButton();
            HighlightButtonCurrentPage(sender);
            button_ChangePage1.Text = "1";
            button_ChangePage2.Text = "2";
            button_ChangePage3.Text = "3";
        }

        private void button_ReturnLastPage_Click(object sender, EventArgs e)
        {
            pageNumber = lastPageNumber;
            LoadData();
            ResetColorButton();
            HighlightButtonCurrentPage(sender);
            button_ChangePage1.Text = (lastPageNumber - 2).ToString();
            button_ChangePage2.Text = (lastPageNumber - 1).ToString();
            button_ChangePage3.Text = lastPageNumber.ToString();
        }

        private void button_SaveInsert_Click(object sender, EventArgs e)
        {
            CheckInputForInsertTaiKhoan(ref checkInputForInsertTaiKhoan);
            if (checkInputForInsertTaiKhoan == true) AddTaiKhoan();
        }

        private void button_ResetInsert_Click(object sender, EventArgs e)
        {
            textBox_EmailInput.Text = "";
            textBox_MatKhauInput.Text = "";
        }

        private void button_SaveDelete_Click(object sender, EventArgs e)
        {
            CheckInputForDeleteTaiKhoan(ref checkInputForDeleteTaiKhoan);
            if (checkInputForDeleteTaiKhoan == true) DeleteTaiKhoan();
        }

        private void button_ResetDelete_Click(object sender, EventArgs e)
        {
            textBox_IDDeleteInput.Text = null;
        }

        private void dataGridView_ChinhSuaTaiKhoan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            menuExpand = false;
            StartTimer(timer_ChinhSuaTaiKhoanTransition); //Start Timer của CSTK
            if (panel_ChinhSuaTaiKhoan.Height == 195) StopTimer(timer_ChinhSuaTaiKhoanTransition);
        }

        private void dataGridView_ChinhSuaTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int selectedID = Convert.ToInt32(dataGridView_ChinhSuaTaiKhoan.SelectedCells[0].OwningRow.Cells["IDTaiKhoan"].Value.ToString());
            //using (NhanVienEntities db = new NhanVienEntities())
            //{
            //    TaiKhoan tk = db.TaiKhoan.Find(selectedID);
            //    textBox_IDUpdateInput.Text = tk.IDTaiKhoan.ToString();
            //    textBox_HoVaTenUpdateInput.Text = tk.HoTen;
            //    comboBox_ChucVuUpdateInput.Text = tk.ChucVu;
            //    comboBox_GioiTinhUpdateInput.Text = tk.GioiTinh;
            //    textBox_SoDienThoaiUpdateInput.Text = tk.SoDienThoai;
            //    textBox_EmailUpdateInput.Text = tk.Email;
            //    textBox_MatKhauUpdateInput.Text = tk.MatKhau;
            //}
        }

        private void button_SaveUpdate_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(dataGridView_ChinhSuaTaiKhoan.SelectedCells[0].OwningRow.Cells["IDTaiKhoan"].Value.ToString());
            using (NhanVienEntities db = new NhanVienEntities())
            {
                /*TaiKhoan tk = db.TaiKhoan.Find(selectedID);
                List<string> updateFields = new List<string>();

                if (textBox_HoVaTenUpdateInput.Text != tk.HoTen)
                    updateFields.Add("Họ và tên");
                if (comboBox_ChucVuUpdateInput.Text != tk.ChucVu)
                    updateFields.Add("Chức vụ");
                if (comboBox_GioiTinhUpdateInput.Text != tk.GioiTinh)
                    updateFields.Add("Giới tính");
                if (textBox_SoDienThoaiUpdateInput.Text != tk.SoDienThoai)
                    updateFields.Add("Số điện thoại");
                if (textBox_EmailUpdateInput.Text != tk.Email)
                    updateFields.Add("Email");
                if (textBox_MatKhauUpdateInput.Text != tk.MatKhau)
                    updateFields.Add("MatKhau");


                string updateFieldMessage = "Bạn muốn thay đổi \n";
                foreach (string field in updateFields)
                {
                    updateFieldMessage += field + "\n";
                }
                updateFieldMessage += $"của tài khoản {tk.HoTen}";

                DialogResult result = MessageBox.Show(updateFieldMessage, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    tk.IDTaiKhoan = Convert.ToInt32(textBox_IDUpdateInput.Text);
                    tk.HoTen = textBox_HoVaTenUpdateInput.Text;
                    tk.ChucVu = comboBox_ChucVuUpdateInput.Text;
                    tk.GioiTinh = comboBox_GioiTinhUpdateInput.Text;
                    tk.SoDienThoai = textBox_SoDienThoaiUpdateInput.Text;
                    tk.Email = textBox_EmailUpdateInput.Text;
                    tk.MatKhau = textBox_MatKhauUpdateInput.Text;
                    db.SaveChanges();
                    MessageBox.Show("Chỉnh sửa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa thông tin thất bại");
                } */ 
            }
        }

        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            menuExpand = true;
            StartTimer(timer_ChinhSuaTaiKhoanTransition); //Start Timer của CSTK
        }
    }
}
