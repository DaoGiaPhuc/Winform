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
    public partial class Form_ThongTinNhanVienChiTiet : Form
    {
        public Form_ThongTinNhanVienChiTiet(int idNhanVien)
        {
            InitializeComponent();
            using (NhanVienEntities db = new NhanVienEntities())
            {
                label_NhanVienName.Text = db.NhanVien.Where(c => c.IDNhanVien == idNhanVien).Select(c => c.HoTen).FirstOrDefault();
                textBox_GioiThieu.Text = db.NhanVien.Where(c => c.IDNhanVien == idNhanVien).Select(c => c.GioiThieu).FirstOrDefault();
                label_IDInfo.Text = db.NhanVien.Where(c => c.IDNhanVien == idNhanVien).Select(c => c.IDNhanVien).FirstOrDefault().ToString();
                label_HoVaTenInfo.Text = db.NhanVien.Where(c => c.IDNhanVien == idNhanVien).Select(c => c.HoTen).FirstOrDefault();
                label_GioiTinhInfo.Text = db.NhanVien.Where(c => c.IDNhanVien == idNhanVien).Select(c => c.GioiTinh).FirstOrDefault();
                label_ChucVuInfo.Text = db.NhanVien.Where(c => c.IDNhanVien == idNhanVien).Select(c => c.ChucVu).FirstOrDefault();
                label_NgaySinhInfo.Text = db.NhanVien.Where(c => c.IDNhanVien == idNhanVien).Select(c => c.NgaySinh).FirstOrDefault().ToString();
                label_EmailInfo.Text = db.NhanVien.Where(c => c.IDNhanVien == idNhanVien).Select(c => c.Email).FirstOrDefault();
                label_SoDienThoaiInfo.Text = db.NhanVien.Where(c => c.IDNhanVien == idNhanVien).Select(c => c.SoDienThoai).FirstOrDefault();
                label_NgayNhanViecInfo.Text = db.NhanVien.Where(c => c.IDNhanVien == idNhanVien).Select(c => c.NgayNhanViec).FirstOrDefault().ToString();
            }
        }

    }
}
