using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace Test_Desktop.Form_NguoiDung.Login_NguoiDung
{
    public partial class Home_NguoiDung : Form
    {
        public int IDNguoiDung4 { get; private set; }
        private NhanVienEntities db;

        private List<Sach> bookRecommendations; // Danh sách sách đề cử
        private int currentIndex1 = 0;
        private int currentIndex2 = 0;

        List<int> randomBookIds = new List<int>();

        private const int itemsPerPage = 10;

        public Home_NguoiDung(int IDNguoiDung1)
        {
            InitializeComponent();
            db = new NhanVienEntities();

            IDNguoiDung4 = IDNguoiDung1;
            DisplayBookRecommendations();
            DisplayRandomBook();
        }

        private void DisplayBookRecommendations()
        {
            // Lấy thông tin người dùng hiện tại
            var currentUser = db.NguoiDung.FirstOrDefault(u => u.IDNguoiDung == IDNguoiDung4); // Thay đổi tên biến từ context sang db

            if (currentUser != null)
            {
                string lop = currentUser.Lop;

                // Lấy sách đề cử dựa trên chuyên ngành của người dùng
                bookRecommendations = db.Sach
                    .Where(s => s.TheLoai ==
                        (lop.StartsWith("SE") ? "The Loai 1" :
                        (lop.StartsWith("IB") ? "The Loai 2" :
                        (lop.StartsWith("FN") ? "The Loai 3" :
                        (lop.StartsWith("BI") ? "The Loai 4" :
                        "The Loai 5"))))) // Sử dụng câu lệnh CASE tương ứng với ChuyenNganh để lấy TheLoai
                    .ToList();

                ShowBookAtIndex(currentIndex1);

            }
        }

        private void ShowBookAtIndex(int index)
        {
            if (index >= 0 && index < bookRecommendations.Count)
            {
                Sach book = bookRecommendations[index];
                label_TenSach.Text = book.TenSach;
                label_TacGia.Text = $"Tác giả: "+ book.TacGia;
                label_MoTa.Text = book.MoTa;
            }
        }

        private void button_ReturnPostPage_Click(object sender, EventArgs e)
        {
            currentIndex1++;
            if (currentIndex1 >= bookRecommendations.Count)
            {
                currentIndex1 = 0; // Quay lại sách đầu tiên nếu đã đến cuốn sách cuối cùng
            }
            ShowBookAtIndex(currentIndex1);
        }

        private void button_ReturnPrePage_Click(object sender, EventArgs e)
        {
            if (bookRecommendations != null && bookRecommendations.Count > 0)
            {
                currentIndex1--;
                if (currentIndex1 < 0)
                {
                    currentIndex1 = bookRecommendations.Count - 1;
                }
                ShowBookAtIndex(currentIndex1);
            }
        }

        private void DisplayRandomBook()
        {
            var allBookIDs = db.Sach.Select(s => s.IDSach).ToList();
            Random rand = new Random();

           
            var randomIndexes = Enumerable.Range(0, allBookIDs.Count).OrderBy(x => rand.Next()).Take(itemsPerPage);

            
            randomBookIds = randomIndexes.Select(i => allBookIDs[i]).ToList();

            
            DisplayBooksForCurrentPage();
        }


        private void button_PostPage2_Click(object sender, EventArgs e)
        {
            currentIndex2++; // Tăng số trang lên khi nhấn nút chuyển trang
            DisplayBooksForCurrentPage(); 
        }

        private void button_PrePage2_Click(object sender, EventArgs e)
        {
            currentIndex2--; // Giảm số trang xuống khi nhấn nút chuyển trang
            DisplayBooksForCurrentPage(); 
        }

        private void DisplayBooksForCurrentPage()
        {
            
            int startIndex = currentIndex2 * itemsPerPage;
            int endIndex = Math.Min(startIndex + itemsPerPage, randomBookIds.Count);

            

            for (int i = startIndex; i < endIndex; i++)
            {
                int randomBookId = randomBookIds[i];
                var book = db.Sach.FirstOrDefault(s => s.IDSach == randomBookId);
                if (book != null)
                {
                    label_TenSach2.Text = book.TenSach;
                    label_TacGia2.Text = book.TacGia;
                    label_MoTa2.Text = book.MoTa;
                }
            }
        }

       
    }
}
