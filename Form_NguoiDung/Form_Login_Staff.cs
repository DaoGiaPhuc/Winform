
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test_Desktop
{
    public partial class Form_Login_Staff : Form
    {
        public Form_Login_Staff()
        {
            InitializeComponent();
        }

        NhanVienEntities db_Staff = new NhanVienEntities();

        private void Form_Login_Staff_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_Login_Main formLoginMain = new Form_Login_Main();
            formLoginMain.Show();
        }

        private void button_SignIn_Click(object sender, EventArgs e)
        {
            try
            {
                using (NhanVienEntities db_Staff = new NhanVienEntities())
                {

                    if (db_Staff.TaiKhoan.Where(r => r.Email == textBox_Username.Text && r.MatKhau == textBox_Password.Text && (r.IDNhanVien!=0 )).Count() > 0)
                    {
    
                            this.Hide();
                            Form_Admin nhanvien = new Form_Admin();
                            nhanvien.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("Nhập sai Tài khoản/Mật khẩu");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
        }
        private void linkLabel_ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            QuenMK_NhanVien quenmk = new QuenMK_NhanVien();
            quenmk.Show();
        }
    }
}
