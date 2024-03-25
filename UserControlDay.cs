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
    public partial class UserControlDay : UserControl
    {
        public UserControlDay()
        {
            InitializeComponent();
        }

        private void UserControlDay_Load(object sender, EventArgs e)
        {

        }

        public void LoadDay(int numday)
        {
            label_Day.Text = numday + "";
        }

        private void UserControlDay_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 95, 105);
        }

        private void UserControlDay_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
