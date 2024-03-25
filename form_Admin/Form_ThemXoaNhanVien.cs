using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Desktop
{
    public partial class Form_ThemXoaNhanVien : Form
    {
        public Form_ThemXoaNhanVien()
        {
            InitializeComponent();
            AddDataSourceComboBox();
        }

        bool checkInputInsert = true;
        bool checkInputDelete = true;

        private void AddDataSourceComboBox()
        {
            string[] GioiTinhs = { "Nam", "Nữ" };
            comboBox_GioiTinhInput.DataSource = GioiTinhs;
            comboBox_GioiTinhInput.SelectedIndex = -1;

            string[] ChucVus = { "Manager", "Staff" };
            comboBox_ChucVuInput.DataSource = ChucVus;
            comboBox_ChucVuInput.SelectedIndex = -1;
        }

        private void CheckInputForInsertNhanVien(ref bool check)
        {
            List<string> missingFields = new List<string>();

            if (string.IsNullOrWhiteSpace(textBox_HoVaTenInput.Text))
                missingFields.Add("Họ và tên");
            if (string.IsNullOrWhiteSpace(comboBox_ChucVuInput.Text))
                missingFields.Add("Chức vụ");
            if (string.IsNullOrWhiteSpace(comboBox_GioiTinhInput.Text))
                missingFields.Add("Giới tính");
            if (dateTimePicker_NgaySinhInput.Value == null)
                missingFields.Add("Ngày sinh");
            if (string.IsNullOrWhiteSpace(textBox_EmailInput.Text))
                missingFields.Add("Email");
            if (string.IsNullOrWhiteSpace(textBox_SoDienThoaiInput.Text))
                missingFields.Add("Số điện thoại");
            if (dateTimePicker_NgayNhanViecInput.Value == null)
                missingFields.Add("Ngày nhận việc");

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

        private void AddNhanVien()
        {
            DialogResult result = MessageBox.Show($"Bạn có chắc muốn thêm nhân viên {textBox_HoVaTenInput.Text} không?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (NhanVienEntities db = new NhanVienEntities())
                {
                    NhanVien nhanVien = new NhanVien()
                    {
                        HoTen = textBox_HoVaTenInput.Text,
                        GioiTinh = comboBox_GioiTinhInput.Text,
                        ChucVu = comboBox_ChucVuInput.Text,
                        NgaySinh = dateTimePicker_NgaySinhInput.Value,
                        Email = textBox_EmailInput.Text,
                        SoDienThoai = textBox_SoDienThoaiInput.Text,
                        NgayNhanViec = dateTimePicker_NgayNhanViecInput.Value
                    };
                    db.NhanVien.AddObject(nhanVien);
                    db.SaveChanges();
                    MessageBox.Show("Thêm nhân viên thành công");
                }
            }
            else { MessageBox.Show("Thêm nhân viên chưa thành công"); }
        }

        private void ResetControl()
        {
            textBox_HoVaTenInput.Text = null;
            comboBox_ChucVuInput.SelectedIndex = -1;
            comboBox_GioiTinhInput.SelectedIndex = -1;
            dateTimePicker_NgayNhanViecInput.Value = DateTime.Now;
            textBox_EmailInput.Text = null;
            textBox_SoDienThoaiInput.Text = null;
            dateTimePicker_NgaySinhInput.Value = DateTime.Now;
        }

        private void CheckInputForDeleteNhanVien(ref bool check)
        {
            if (!string.IsNullOrWhiteSpace(textBox_IDDeleteInput.Text)) check = true;
            else
            {
                MessageBox.Show($"Trường {textBox_IDDeleteInput.Text} không được để trống");
                check = false;
            }
        }

        private void DeleteNhanVien()
        {
            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa nhân viên có {textBox_IDDeleteInput.Text} không?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (NhanVienEntities db = new NhanVienEntities())
                {
                    int idDelete = Convert.ToInt32(textBox_IDDeleteInput.Text);
                    NhanVien nhanVien = db.NhanVien.Where(p => p.IDNhanVien == idDelete).SingleOrDefault();
                    db.NhanVien.DeleteObject(nhanVien);
                    db.SaveChanges();
                    MessageBox.Show("Xóa nhân viên thành công");
                }
            }
            else MessageBox.Show("Xóa nhân viên thất bại");
        }

        private void ResetIdDelete()
        {
            textBox_IDDeleteInput.Text = null;
        }

        private void button_SaveInsert_Click(object sender, EventArgs e)
        {
            CheckInputForInsertNhanVien(ref checkInputInsert);
            if (checkInputInsert == true) AddNhanVien();
        }

        private void button_ResetInsert_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        private void dateTimePicker_NgaySinhInput_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker_NgaySinhInput.Value > dateTimePicker_NgayNhanViecInput.Value)
            {
                MessageBox.Show("Ngày sinh không được lớn hơn ngày nhận việc của nhân viên");
                dateTimePicker_NgaySinhInput.Value = dateTimePicker_NgayNhanViecInput.Value;

            }
        }

        private void dateTimePicker_NgayNhanViecInput_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker_NgayNhanViecInput.Value < dateTimePicker_NgaySinhInput.Value)
            {
                MessageBox.Show("Ngày nhận việc không được nhỏ hơn ngày sinh của nhân viên");
                dateTimePicker_NgayNhanViecInput.Value = dateTimePicker_NgaySinhInput.Value;
            }
        }

        private void button_SaveDelete_Click(object sender, EventArgs e)
        {
            CheckInputForDeleteNhanVien(ref checkInputDelete);
            if (checkInputDelete == true) DeleteNhanVien();
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
