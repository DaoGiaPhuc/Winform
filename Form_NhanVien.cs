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
    public partial class Form_NhanVien1 : Form
    {
        public Form_NhanVien1()
        {
            InitializeComponent();
            panel_ChildTaiKhoan.Height = 0; //Mặc định button con của TKNV có height = 0
            panel_ChildQuanLiSach.Height = 0; //Mặc định button con của QLS có height = 0
        }
        #region Search_Function
        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Search.Text.Length != 0)
            {
                label_Search.Text = ""; //Nếu text trong ô textBox được nhập thì xóa label Search
            }
            else if (textBox_Search.Text.Length == 0) label_Search.Text = "Search"; //Nếu text rỗng thì hiện lại label Search
        }

        private void textBox_Search_Click(object sender, EventArgs e)
        {
            if (textBox_Search.Text.Length == 0) label_Search.Text = ""; //TextBox được click thì xóa label Search

        }
        private void labelSearch_Click(object sender, EventArgs e)
        {
            textBox_Search.Focus(); //Nếu click vào label Search thì chuyển Focus vào textBox
            label_Search.Text = ""; //Xóa label Search
        }
        #endregion

        //Functions
        #region Hàm
        bool menuExpand = false; //Biến hiển thị độ mở rộng của button con
        private void Sidebar_Transition(ref bool menuExpand, Panel panel, Timer timer) //Func để mở rộng và thu nhỏ các button con
        {
            if (menuExpand == false)
            {
                panel.Height += 5;
                if (panel.Height >= 100)
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

        private void Timer_Start(Timer timer) //Func để Start Timer
        {
            timer.Start();
        }

        private void timer_TaiKhoanTransition_Tick(object sender, EventArgs e)
        {
            //Func để mở rộng và thu nhỏ button của TKNV
            Sidebar_Transition(ref menuExpand, panel_ChildTaiKhoan, timer_TaiKhoanTransition);
        }

        private void timer_QuanLiSachTransition_Tick(object sender, EventArgs e)
        {
            Sidebar_Transition(ref menuExpand, panel_ChildQuanLiSach, timer_QuanLiSachTransition);
        }

        private Form activeForm = null; //Biến thể hiện panel cố định đã có form nào được mở chưa
        private void openChildForm(Form childForm) //Func mở ChildForm vào 1 panel cố định trong giao diện
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_ChildForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        //Events
        private void button_TaiKhoan_Click(object sender, EventArgs e)
        {
            Timer_Start(timer_TaiKhoanTransition); //Start Timer của TKNV
            label_Home_CurrentFunction.Text = $"Home > Tài khoản";
            label_CurrentForm.Text = "Tài khoản nhân viên";
        }

        private void button_Thongtin_Click(object sender, EventArgs e)
        {
            label_Home_CurrentFunction.Text = $"Home > Tài khoản > Thông tin";
            label_CurrentForm.Text = "Thông tin nhân viên";
            //openChildForm(); //Fill ChildForm vào panel cố định trong giao diện
        }

        private void button_ChinhSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            label_Home_CurrentFunction.Text = $"Home > Tài khoản > Chỉnh sửa tài khoản";
            label_CurrentForm.Text = "Chỉnh sửa tài khoản";
            //openChildForm(); //Fill ChildForm vào panel cố định trong giao diện
        }

        private void button_QuanLiCaLam_Click(object sender, EventArgs e)
        {
            label_Home_CurrentFunction.Text = $"Home > Quản lí ca làm";
            label_CurrentForm.Text = "Quản lí ca làm";
            //openChildForm(); //Fill ChildForm vào panel cố định trong giao diện
        }

        private void button_QuanLiSach_Click(object sender, EventArgs e)
        {
            Timer_Start(timer_QuanLiSachTransition);
            label_Home_CurrentFunction.Text = $"Home > Quản lí sách";
            label_CurrentForm.Text = "Quản lí sách";
        }
        
        private void button_ThongTinSach_Click(object sender, EventArgs e)
        {
            label_Home_CurrentFunction.Text = $"Home > Quản lí sách > Thông tin sách";
            label_CurrentForm.Text = "Thông tin sách";
            //openChildForm(); //Fill ChildForm vào panel cố định trong giao diện
        }

        private void button_MuonTraSach_Click(object sender, EventArgs e)
        {
            label_Home_CurrentFunction.Text = $"Home > Quản lí sách > Mượn trả sách";
            label_CurrentForm.Text = "Mượn - trả sách";
            //openChildForm(); //Fill ChildForm vào panel cố định trong giao diện
        }

        private void button_QuanLiDocGia_Click(object sender, EventArgs e)
        {
            label_Home_CurrentFunction.Text = $"Home > Quản lí độc giả";
            label_CurrentForm.Text = "Quản lí độc giả";
            //openChildForm(); //Fill ChildForm vào panel cố định trong giao diện
        }
        private void button_QuanLiMuonTraSach_Click(object sender, EventArgs e)
        {
            label_Home_CurrentFunction.Text = $"Home > Quản lí mượn trả sách";
            label_CurrentForm.Text = "Quản lí mượn trả sách";
            //openChildForm(); //Fill ChildForm vào panel cố định trong giao diện
        }

        private void button_ThongKe_Click(object sender, EventArgs e)
        {
            label_Home_CurrentFunction.Text = $"Home > Thống kê";
            label_CurrentForm.Text = "Thông kê";
            //openChildForm(); //Fill ChildForm vào panel cố định trong giao diện
        }

        private void button_ThongBao_Click(object sender, EventArgs e)
        {
            label_Home_CurrentFunction.Text = $"Home > Thông báo";
            label_CurrentForm.Text = "Thông báo";
            //openChildForm(); //Fill ChildForm vào panel cố định trong giao diện
        }

        private void button_CaiDat_Click(object sender, EventArgs e)
        {
            label_Home_CurrentFunction.Text = $"Home > Cài đặt";
            label_CurrentForm.Text = "Cài đặt";
            //openChildForm(); //Fill ChildForm vào panel cố định trong giao diện
        }
    }
}
