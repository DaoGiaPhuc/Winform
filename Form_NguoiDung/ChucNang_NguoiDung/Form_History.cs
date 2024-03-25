using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace Test_Desktop
{
    public partial class Form_History : Form
    {
        public int IDNguoiDung2 { get; private set; }
        public Form_History(int IDNguoiDung1)
        {
            InitializeComponent();
            IDNguoiDung2 = IDNguoiDung1;

            LoadData();
            
        }

        static int pageNumber = 1;
        static int numberRecord = 5;
        static int totalRecord = 0;
        static int lastPageNumber = 0;

        void LoadData()
        {
            
            using (NhanVienEntities db = new NhanVienEntities())
            {
                totalRecord = db.MuonTraSach.Count();
            }
            lastPageNumber = (int)Math.Ceiling((double)totalRecord / numberRecord);

            var records = LoadRecord(pageNumber, numberRecord);
            if (records.Count == 0)
            {
                MessageBox.Show("Đã hết kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataGridView_History.DataSource = LoadRecord(pageNumber, numberRecord);

            AdjustRowHeight();
            AdjustColumnWidth();
            ChangeHeader();

        }

        public List<object> LoadRecord(int page, int recordNum)
        {
            List<object> result = new List<object>();
            using (NhanVienEntities db = new NhanVienEntities())
            {
                result = db.MuonTraSach.OrderBy(e => e.IDNguoiDung == IDNguoiDung2)
                    .Where(e => e.IDNguoiDung == IDNguoiDung2)

                    /*Khúc này phải check IDNguoiDung bằng form đăng nhập nhen, 
                    này t cho nó bằng 1 luôn để dễ truy vấn trong db */

                    .Skip((page - 1) * recordNum)
                    .Take(recordNum)
                    .Select(e => new
                    {
                        IDMuonTra = e.IDMuonTra,
                        TenSach = e.TenSach,
                        IDSach = e.IDSach,
                        NgayMuon = e.NgayMuon,
                        NgayTra = e.NgayTraThucTe,
                        TinhTrang = e.TinhTrang,

                    }).ToList<object>();
            }
            return result;
        }

        public void AdjustRowHeight()
        {
            int desiredHeight = dataGridView_History.Height / (dataGridView_History.Rows.Count + 1);

            // Thiết lập chiều cao cho mỗi dòng
            foreach (DataGridViewRow row in dataGridView_History.Rows)
            {
                row.Height = desiredHeight;
            }
        }

        private void AdjustColumnWidth()
        {
            dataGridView_History.Columns[0].Width = dataGridView_History.Width * 15 / 100;
            dataGridView_History.Columns[1].Width = dataGridView_History.Width * 15 / 100;
            dataGridView_History.Columns[2].Width = dataGridView_History.Width * 15 / 100;
            dataGridView_History.Columns[3].Width = dataGridView_History.Width * 20 / 100;
            dataGridView_History.Columns[4].Width = dataGridView_History.Width * 20 / 100;
            dataGridView_History.Columns[5].Width = dataGridView_History.Width * 15 / 100;
            //dataGridView_History.Columns[6].Width = dataGridView_History.Width * 10 / 100;
        }

        private void ChangeHeader()
        {
            
            dataGridView_History.Columns[0].HeaderText = "ID Mượn trả";
            dataGridView_History.Columns[1].HeaderText = "Tên Sách";
            dataGridView_History.Columns[2].HeaderText = "ID Sách";
            dataGridView_History.Columns[3].HeaderText = "Ngày mượn";
            dataGridView_History.Columns[4].HeaderText = "Ngày trả";
            dataGridView_History.Columns[5].HeaderText = "Tình Trạng";
            //dataGridView_History.Columns[6].HeaderText = "Đánh giá";

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

        private void FormHistory_Resize(object sender, EventArgs e)
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

        private void button_Search_Click(object sender, EventArgs e)
        {
            //using (NhanVienEntities db = new NhanVienEntities())
            //{
            //    dataGridView_History.DataSource = db.MuonTraSach.ToList();
            //}
            //LoadData();
        }

        private void dataGridView_History_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy giá trị của ô cần lấy ID Sách
                var selectedCell = dataGridView_History.Rows[e.RowIndex].Cells["IDSach"];

                // Kiểm tra xem giá trị có tồn tại không
                if (selectedCell.Value != null)
                {
                    // Lấy ID Sách từ giá trị ô được chọn
                    int idSach = Convert.ToInt32(selectedCell.Value);
                    

                    // Chuyển ID Sách qua Form_DanhGia
                    Form_DanhGia danhgia = new Form_DanhGia(idSach, IDNguoiDung2);
                    danhgia.Show();
                }
            }

        }

       
    }
}
