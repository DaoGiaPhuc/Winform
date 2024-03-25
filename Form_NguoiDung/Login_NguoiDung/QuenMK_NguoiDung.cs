using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace Test_Desktop
{
    public partial class QuenMK_NguoiDung : Form
    {
        public QuenMK_NguoiDung()
        {
            InitializeComponent();
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            using (NhanVienEntities db_User = new NhanVienEntities())
            {
                string newPassword = GenerateRandomPassword();
                string GenerateRandomPassword()
                {
                    const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
                    Random random = new Random();
                    return new string(Enumerable.Repeat(chars, 7).Select(s => s[random.Next(s.Length)]).ToArray());
                }

                if (!String.IsNullOrEmpty(textBox_ID.Text))
                {

                    int ID = Convert.ToInt32(Convert.ToInt32(textBox_ID.Text));


                    if (db_User.TaiKhoan.Where(r => r.Email == textBox_Username.Text && r.IDTaiKhoan == ID && (r.IDNguoiDung != 0)).Count() > 0)
                    {
                        var user = db_User.TaiKhoan.FirstOrDefault(r => r.Email == textBox_Username.Text && r.IDTaiKhoan == ID && (r.IDNguoiDung != 0));



                        user.MatKhau = newPassword;
                        db_User.SaveChanges();
                        this.Hide();
                        MessageBox.Show("Mật khẩu mới của bạn là: " + newPassword);
                    }
                    else
                    {
                        MessageBox.Show("Nhập sai Tài khoản/ID");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập ID");
                }

            }
        }

        private void pictureBox_UehLogo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_Username_Click(object sender, EventArgs e)
        {

        }

        private void panel_Username_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
