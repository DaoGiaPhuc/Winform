using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Desktop.Form_NhanVien
{
    public partial class Form_QuanLiDocGia : Form
    {
        public Form_QuanLiDocGia()
        {
            InitializeComponent();
            LoadData();
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
                    var result = db.NhanVien.Where(c => c.HoTen.Contains(textBox_SearchName.Text));
                    if (result != null)
                        dataGridView_ThongTinNhanVien.DataSource = result.ToList();
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

        static int pageNumber = 1;
        static int numberRecord = 10;
        static int totalRecord = 0;
        static int lastPageNumber = 0;

        void LoadData()
        {
            using (NhanVienEntities db = new NhanVienEntities())
            {
                totalRecord = db.NhanVien.Count();
            }
            lastPageNumber = (int)Math.Ceiling((double)totalRecord / numberRecord);
            dataGridView_ThongTinNhanVien.DataSource = LoadRecord(pageNumber, numberRecord);
            AdjustRowHeight();
            AdjustColumnWidth();
            ChangeHeader();

        }

        List<object> LoadRecord(int page, int recordNum)
        {
            List<object> result = new List<object>();
            using (NhanVienEntities db = new NhanVienEntities())
            {
                result = db.NhanVien.OrderBy(e => e.IDNhanVien)
                    .Skip((page - 1) * recordNum)
                    .Take(recordNum)
                    .Select(e => new
                    {
                        IDNhanVien = e.IDNhanVien,
                        HoTen = e.HoTen,
                        GioiTinh = e.GioiTinh,
                        ChucVu = e.ChucVu,
                        NgaySinh = e.NgaySinh,
                        Email = e.Email,
                        SoDienThoai = e.SoDienThoai
                    }).ToList<object>();
            }
            return result;
        }
        public void AdjustRowHeight()
        {
            int desiredHeight = dataGridView_ThongTinNhanVien.Height / (dataGridView_ThongTinNhanVien.Rows.Count + 1);

            // Thiết lập chiều cao cho mỗi dòng
            foreach (DataGridViewRow row in dataGridView_ThongTinNhanVien.Rows)
            {
                row.Height = desiredHeight;
            }
        }

        private void AdjustColumnWidth()
        {
            dataGridView_ThongTinNhanVien.Columns[0].Width = dataGridView_ThongTinNhanVien.Width * 5 / 100;
            dataGridView_ThongTinNhanVien.Columns[1].Width = dataGridView_ThongTinNhanVien.Width * 20 / 100;
            dataGridView_ThongTinNhanVien.Columns[2].Width = dataGridView_ThongTinNhanVien.Width * 10 / 100;
            dataGridView_ThongTinNhanVien.Columns[3].Width = dataGridView_ThongTinNhanVien.Width * 10 / 100;
            dataGridView_ThongTinNhanVien.Columns[4].Width = dataGridView_ThongTinNhanVien.Width * 10 / 100;
            dataGridView_ThongTinNhanVien.Columns[5].Width = dataGridView_ThongTinNhanVien.Width * 30 / 100;
            dataGridView_ThongTinNhanVien.Columns[6].Width = dataGridView_ThongTinNhanVien.Width * 15 / 100;
        }

        private void ChangeHeader()
        {
            dataGridView_ThongTinNhanVien.Columns[0].HeaderText = "ID";
            dataGridView_ThongTinNhanVien.Columns[1].HeaderText = "Tên";
            dataGridView_ThongTinNhanVien.Columns[2].HeaderText = "Giới tính";
            dataGridView_ThongTinNhanVien.Columns[3].HeaderText = "Chức vụ";
            dataGridView_ThongTinNhanVien.Columns[4].HeaderText = "Ngày sinh";
            dataGridView_ThongTinNhanVien.Columns[5].HeaderText = "Email";
            dataGridView_ThongTinNhanVien.Columns[6].HeaderText = "Số điện thoại";
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

        private void FormThongTinNhanVien_Resize(object sender, EventArgs e)
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

        private void button_Add_Click(object sender, EventArgs e)
        {
            Form_ThemXoaNhanVien formThemXoaNhanVien = new Form_ThemXoaNhanVien();
            formThemXoaNhanVien.Show();
        }

        private void dataGridView_ThongTinNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedID = Convert.ToInt32(dataGridView_ThongTinNhanVien.Rows[e.RowIndex].Cells["IDNhanVien"].Value);
            XemThongTinNhanVienChiTiet(selectedID);
        }

        private void XemThongTinNhanVienChiTiet(int ID)
        {
            Form_ThongTinNhanVienChiTiet formThongTinNhanVienChiTiet = new Form_ThongTinNhanVienChiTiet(ID);
            formThongTinNhanVienChiTiet.Show();
        }
    }
}
