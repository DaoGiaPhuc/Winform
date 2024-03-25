using CalendarCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserCa;

namespace Test_Desktop.MachGiaHuy
{
    public partial class Form_XepLichLamViec : Form
    {
        NhanVienEntities database = new NhanVienEntities();
        public Form_XepLichLamViec()
        {
            InitializeComponent();
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (UserCalendar.Days.Count != 0)
            {
                DateTime dateTimenow = DateTime.Parse(takeTimePicked());
                using (var db = new NhanVienEntities())
                {
                    var caLams = db.QuanLiCaLam.Where(q => q.Ngay == dateTimenow).ToList();
                    flowCaPanel.Controls.Clear();
                    foreach (var caLam in caLams)
                    {
                        UserCaControl userCaControl = new UserCaControl();
                        userCaControl.changeButtonCaNum("Ca" + caLam.STTCa);
                        userCaControl.changeTimeNow((TimeSpan)caLam.GioBatDau, (TimeSpan)caLam.GioKetThuc);
                        userCaControl.changeID(caLam.IDNhanVien.ToString());
                        var nhanVien = db.NhanVien.FirstOrDefault(nv => nv.IDNhanVien == caLam.IDNhanVien);
                        if (nhanVien != null)
                        {
                            userCaControl.changeHoTen(nhanVien.HoTen);
                            userCaControl.changePhoneNumber(nhanVien.SoDienThoai);
                        }
                        userCaControl.Click += userCaControl1_Click;
                        flowCaPanel.Controls.Add(userCaControl);
                    }
                }
            }
        }
        private void MessageBoxShow(string text, string caption)
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void userCaControl1_Click(object sender, EventArgs e)
        {
            UserCaControl userCaControl = sender as UserCaControl;
            Form_TaoCaLam form = new Form_TaoCaLam(takeTimePicked(), userCaControl);
            if (userCaControl.BorderStyle != BorderStyle.FixedSingle)
            {
                form.ShowDialog();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Today: " + DateTime.Now.Day + " / " + DateTime.Now.Month + " / " + DateTime.Now.Year;
            takeTimePicked();
            btnRestart_Click(sender, e);
        }
        public string takeTimePicked() //Lấy ra ngày/tháng/năm đang chọn (màu xanh)
        {
            string DateNow = "";
            string MonthNow = "";
            string DayNow = "";
            if (UserCalendar.month >= 10)
            {
                MonthNow = UserCalendar.month.ToString();
            }
            else
            {
                MonthNow = "0" + UserCalendar.month.ToString();
            }
            if (UserCalendar.DayNum < 10)
            {
                DayNow = "0" + UserCalendar.DayNum.ToString();
            }
            else
            {
                DayNow = UserCalendar.DayNum.ToString();
            }
            if (UserCalendar.DayNum != 0)
            {
                DateNow = UserCalendar.year + "-" + MonthNow + "-" + DayNow;
            }
            return DateNow;
        }

        private void btnAdding_Click(object sender, EventArgs e)
        {
            if (UserCalendar.DayNum != 0 && UserCalendar.Days.Count != 0)
            {
                int Count = 0;
                Form_TaoCaLam form = new Form_TaoCaLam(takeTimePicked());
                foreach (UserCaControl x in flowCaPanel.Controls)
                {
                    if (x is UserCaControl)
                    {
                        Count++;
                    }
                }
                if (Count == 2)
                {
                    MessageBoxShow("Đã tối đa ca một ngày!", "Thất bại");
                }
                else
                {
                    form.ShowDialog();
                }
            }
            else
            {
                MessageBoxShow("Vui lòng chọn ngày!", "Thất bại");
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            UserCaControl userCaControl = null;
            foreach (UserCaControl x in flowCaPanel.Controls)
            {
                if (x.BorderStyle == BorderStyle.FixedSingle)
                {
                    userCaControl = x; break;
                }
            }
            if (userCaControl != null)
            {
                using (NhanVienEntities db = new NhanVienEntities())
                {
                    DateTime datenow = DateTime.Parse(takeTimePicked());
                    int STTCa = userCaControl.getSTTCa();
                    var CaLam = db.QuanLiCaLam.FirstOrDefault(p => p.Ngay == datenow
                        && p.STTCa == STTCa);
                    if (CaLam != null)
                    {
                        db.QuanLiCaLam.DeleteObject(CaLam);
                        db.SaveChanges();
                        MessageBoxShow("Đã xóa ca vừa chọn", "Thành công");
                        btnRestart_Click(sender, e);
                    }
                    else
                    {
                        MessageBoxShow("Hãy lựa chọn 1 ca để xóa", "Thất bại");
                    }
                }
            }
        }

        private void userCalendar_Click(object sender, EventArgs e)
        {
            if (UserCalendar.Days.Count != 0)
            {
                btnRestart_Click(sender, e);
            }
            else
            {
                flowCaPanel.Controls.Clear();
            }
        }
    }
}
