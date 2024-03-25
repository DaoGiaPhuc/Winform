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
    public partial class Form_ThemXoaSach : Form
    {
        public Form_ThemXoaSach()
        {
            InitializeComponent();
        }

        bool checkInputInsert = true;
        bool checkInputDelete = true;

        private void CheckInputForInsertSach(ref bool check)
        {
            List<string> missingFields = new List<string>();

            if (string.IsNullOrWhiteSpace(textBox_TenSachInsertInput.Text))
                missingFields.Add("Tên sách");
            if (string.IsNullOrWhiteSpace(textBox_TacGiaInsertInput.Text))
                missingFields.Add("Tác giả");
            if (string.IsNullOrWhiteSpace(textBox_TheLoaiInsertInput.Text))
                missingFields.Add("Thể loại");
            if (string.IsNullOrWhiteSpace(textBox_SoLuongInsertInput.Text))
                missingFields.Add("Số lượng");
            if (string.IsNullOrWhiteSpace(textBox_NhaXuatBanInsertInput.Text))
                missingFields.Add("Nhà xuất bản");
            if (dateTimePicker_NamXuatBanInsertInput.Value == null)
                missingFields.Add("Năm xuất bản");

            if (missingFields.Count == 0) check = true;
            else
            {
                check = false;
                string missingFieldsMessage = "Các trường sau không được để trống:\n";
                foreach (string field in missingFields)
                {
                    missingFieldsMessage += field + "\n";
                }
                MessageBox.Show(missingFieldsMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddSach()
        {
            DialogResult result = MessageBox.Show($"Bạn có chắc muốn thêm sách {textBox_TenSachInsertInput.Text} không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (NhanVienEntities db = new NhanVienEntities())
                {
                    Sach sach = new Sach()
                    {
                        TenSach = textBox_TenSachInsertInput.Text,
                        TacGia = textBox_TacGiaInsertInput.Text,
                        TheLoai = textBox_TheLoaiInsertInput.Text,
                        SoLuong = Convert.ToInt32(textBox_SoLuongInsertInput.Text),
                        NhaXuatBan = textBox_NhaXuatBanInsertInput.Text,
                        NamXuatBan = dateTimePicker_NamXuatBanInsertInput.Value
                    };
                    db.Sach.AddObject(sach);
                    db.SaveChanges();
                    MessageBox.Show("Thêm sách thành công");
                }
            }
            else { MessageBox.Show("Thêm sách chưa thành công"); }
        }

        private void ResetControl()
        {
            textBox_TenSachInsertInput.Text = null;
            textBox_TacGiaInsertInput.Text = null;
            textBox_TheLoaiInsertInput.Text = null;
            textBox_SoLuongInsertInput.Text = null;
            textBox_NhaXuatBanInsertInput.Text = null;
            dateTimePicker_NamXuatBanInsertInput.Value = DateTime.Now;
        }

        private void CheckInputForDeleteSach(ref bool check)
        {
            if (!string.IsNullOrWhiteSpace(textBox_IDSachDeleteInput.Text)) check = true;
            else
            {
                MessageBox.Show($"Trường {textBox_IDSachDeleteInput.Text} không được để trống");
                check = false;
            }
        }

        private void DeleteSach()
        {
            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa sách có ID: {textBox_IDSachDeleteInput.Text} không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (NhanVienEntities db = new NhanVienEntities())
                {
                    int idDelete = Convert.ToInt32(textBox_IDSachDeleteInput.Text);
                    Sach sach = db.Sach.Where(p => p.IDSach == idDelete).SingleOrDefault();
                    db.Sach.DeleteObject(sach);
                    db.SaveChanges();
                    MessageBox.Show("Xóa sách thành công");
                }
            }
            else MessageBox.Show("Xóa sách thất bại");
        }

        private void ResetIdDelete()
        {
            textBox_IDSachDeleteInput.Text = null;
        }

        private void button_SaveInsert_Click(object sender, EventArgs e)
        {
            CheckInputForInsertSach(ref checkInputInsert);
            if (checkInputInsert == true) AddSach();
        }

        private void button_ResetInsert_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        private void button_SaveDelete_Click(object sender, EventArgs e)
        {
            CheckInputForDeleteSach(ref checkInputDelete);
            if (checkInputDelete == true) DeleteSach();
        }

        private void button_ResetDelete_Click(object sender, EventArgs e)
        {
            ResetIdDelete();
        }

        private void button_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select file";
            op.InitialDirectory = @"C:\";
            op.Filter = "Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            op.FilterIndex = 3;

            if (op.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của tập tin hình ảnh được chọn
                string imagePath = op.FileName;

                // Gọi phương thức để tải và hiển thị ảnh trong PictureBox
                LoadImage(imagePath);
            }
        }

        private void LoadImage(string imagePath)
        {
            try
            {
                // Tạo đối tượng hình ảnh từ đường dẫn
                Image image = Image.FromFile(imagePath);

                // Gán hình ảnh vào PictureBox
                pictureBox_Avatar.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
