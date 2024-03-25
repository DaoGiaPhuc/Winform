using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Test_Desktop.Form_NguoiDung.Login_NguoiDung;

namespace Test_Desktop
{
    public partial class Form_NguoiDung1 : Form
    {
        public int IDNguoiDung1 { get; private set; }
        
        public Form_NguoiDung1(int idNguoiDung)
        {
            InitializeComponent();
            IDNguoiDung1 = idNguoiDung;

            openChildForm(new Test_Desktop.Form_NguoiDung.Login_NguoiDung.Home_NguoiDung(IDNguoiDung1));
            
        }
        #region Search Function
        private void textBox_SearchFunction_TextChanged(object sender, EventArgs e)
        {
            if (textBox_SearchFunction.Text.Length != 0)
            {
                label_SearchFunction.Text = ""; //Nếu text trong ô textBox được nhập thì xóa label Search
            }
            else if (textBox_SearchFunction.Text.Length == 0) label_SearchFunction.Text = "Search or type"; //Nếu text rỗng thì hiện lại label Search
        }

        private void textBox_SearchFunction_Click(object sender, EventArgs e)
        {
            if (textBox_SearchFunction.Text.Length == 0) label_SearchFunction.Text = ""; //TextBox được click thì xóa label Search
        }

        private void label_SearchFunction_Click(object sender, EventArgs e)
        {
            textBox_SearchFunction.Focus(); //Nếu click vào label Search thì chuyển Focus vào textBox
            label_SearchFunction.Text = ""; //Xóa label Search
        }

        #endregion

        //Functions
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

        private void button_Searching_Click(object sender, EventArgs e)
        {
            
        }

        #region History

        private void button_History_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_History(IDNguoiDung1));
        }

        #endregion

        

        private void button_Home_Click(object sender, EventArgs e)
        {

        }
    }
}
