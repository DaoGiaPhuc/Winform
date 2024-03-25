using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Desktop
{
    public partial class Form_Login_Student : Form
    {
        public Form_Login_Student()
        {
            InitializeComponent();
        }

        public int idNguoiDung { get; private set; }

        private void Form_Login_Student_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_Login_Main formLoginMain = new Form_Login_Main();
            formLoginMain.Show();
        }

        private void button_SignIn_Click(object sender, EventArgs e)
        {
            try
            {
                using (NhanVienEntities db = new NhanVienEntities())
                {
                    var user = db.TaiKhoan.FirstOrDefault(r => r.Email == textBox_Username.Text && r.MatKhau == textBox_Password.Text && (r.IDNguoiDung != 0));
                    if (user != null)
                    {
                        idNguoiDung = (int)user.IDNguoiDung;

                        this.Hide();
                        Form_NguoiDung1 nguoidung = new Form_NguoiDung1(idNguoiDung);

                        nguoidung.Show();
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
            QuenMK_NguoiDung quenmk = new QuenMK_NguoiDung();
            quenmk.Show();
        }
    }
}
