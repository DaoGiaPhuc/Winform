using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Desktop
{
    public partial class FormLichLamViec : Form
    {
        public FormLichLamViec()
        {
            InitializeComponent();
            userCaControl2.changeButtonCaNum("Ca 2");
            userCaControl3.changeButtonCaNum("Ca 3");

        }

        private void FormLichLamViec_Load(object sender, EventArgs e)
        {
            DisplayDay();
        }

        int month, year;
        private void DisplayDay()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            HandleDisplayDay();
        }
        private void HandleDisplayDay()
        {
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label_MonthYearName.Text = monthName + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                flowLayoutPanel_Calendar.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDay ucday = new UserControlDay();
                ucday.LoadDay(i);
                flowLayoutPanel_Calendar.Controls.Add(ucday);
            }
        }

        private void button_Previous_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_Calendar.Controls.Clear();
            month--;
            HandleDisplayDay();
        }

        private void userCalendar1_Load(object sender, EventArgs e)
        {
            
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_Calendar.Controls.Clear();
            month++;
            HandleDisplayDay();
        }


        
    }
}
