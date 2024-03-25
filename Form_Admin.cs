using System;  
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_Desktop.Form_NhanVien;
using Test_Desktop.MachGiaHuy;

namespace Test_Desktop
{
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
            panel_ChildTaiKhoanNhanVien.Height = 0; //Mặc định button con của TKNV có height = 0
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

        bool menuExpand = false; //Biến hiển thị độ mở rộng của button con
        private void timer_TaiKhoanNhanVienTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                panel_ChildTaiKhoanNhanVien.Height += 5;
                if (panel_ChildTaiKhoanNhanVien.Height >= 100)
                {
                    timer_TaiKhoanNhanVienTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                panel_ChildTaiKhoanNhanVien.Height -= 5;
                if (panel_ChildTaiKhoanNhanVien.Height <= 0)
                {
                    timer_TaiKhoanNhanVienTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void button_TaiKhoanNhanVien_Click(object sender, EventArgs e)
        {
            timer_TaiKhoanNhanVienTransition.Start();
        }

        private void buttonThongtin_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_ThongTinNhanVien()); //Fill ChildForm vào panel cố định trong giao diện
        }

        private void buttonChinhSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_ChinhSuaTaiKhoan()); //Fill ChildForm vào panel cố định trong giao diện
        }

        private Form activeForm = null; //Biến thể hiện panel cố định đã có form nào được mở chưa
        public void openChildForm(Form childForm) //Func mở ChildForm vào 1 panel cố định trong giao diện
        {
            if(activeForm != null)
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

        private void button_LichLamViec_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_XepLichLamViec());
        }

        private void Form_Admin_Resize(object sender, EventArgs e)
        {
            
        }

        private void button_GuiThongBao_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_ThongTinSach());
        }
    }
}
