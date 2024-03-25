using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Test_Desktop
{
    public partial class QuenMK_NhanVien : Form
    {
        public QuenMK_NhanVien()
        {
            InitializeComponent();
        }

        
       

        private void textBox_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            using (NhanVienEntities db_Staff = new NhanVienEntities())
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


                    if (db_Staff.TaiKhoan.Where(r => r.Email == textBox_Username.Text && r.IDTaiKhoan == ID && (r.IDNhanVien!=0)).Count() > 0)
                    {
                        var user = db_Staff.TaiKhoan.FirstOrDefault(r => r.Email == textBox_Username.Text && r.IDTaiKhoan == ID && (r.IDNhanVien != 0));

                       
                           
                            user.MatKhau = newPassword;
                            db_Staff.SaveChanges();
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

        
    }
}

