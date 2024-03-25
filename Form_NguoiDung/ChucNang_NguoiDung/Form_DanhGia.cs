using Avalonia.Animation;
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
    public partial class Form_DanhGia : Form
    {
        public int IDNguoiDung3;
        public Form_DanhGia(int idSach, int idNguoiDung2)
        {
            InitializeComponent();
            button_Save.Hide();
            IDNguoiDung3 = idNguoiDung2;
        
            using (var db = new NhanVienEntities())
            {
                #region Hien thi ten, tac gia
                var tensach = db.MuonTraSach.FirstOrDefault(s => s.IDSach == idSach);

                if (tensach != null)
                {
                    // Hiển thị tên sách lên label_TenSach
                    label_TenSach.Text = tensach.TenSach;
                }
                else
                {
                    // Xử lý trường hợp không tìm thấy sách
                    label_TenSach.Text = "Không tìm thấy sách";
                 
                }

                var tentacgia = db.Sach.FirstOrDefault(s => s.TenSach == label_TenSach.Text);
                if (tentacgia != null)
                {
                    label_TacGia.Text = tentacgia.TacGia;
                }
                else
                {
                    // Xử lý trường hợp không tìm thấy sách
                    label_TenSach.Text = "Không tìm thấy tác giả";

                }
                #endregion

                #region Hien thi Diem danh gia, nhan xet

                //DanhGia
                var  danhgia = db.DanhGiaSach
                    .Where(d => (d.IDNguoiDung == 1) && d.IDSach == idSach)
                    .Select(d => d.DiemDanhGia)
                    .SingleOrDefault();
                if (danhgia != null)
                {
                    RatingStar.Value = (float)danhgia;
                }
                else
                {
                    RatingStar.Value = 0;
                }
                


                // NhanXet
                var nhanxet = db.DanhGiaSach
                    .Where(d => (d.IDNguoiDung == 1) && d.IDSach == idSach)
                    .Select(d=> d.NhanXet)
                    .SingleOrDefault();

                if (nhanxet != null)
                {
                    
                    textBox_NhanXet.Text = nhanxet.ToString();
                    textBox_NhanXet.Cursor = Cursors.No;
                    
                }
                else
                {
                    label2.Text = "Hãy chia sẻ những điều bạn thích về tài liệu này với những người khác nhé.";
                }

                

                #endregion

            }

        }

        private void textBox_NhanXet_MouseHover(object sender, EventArgs e)
        {
            textBox_NhanXet.Cursor = Cursors.No;
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            textBox_NhanXet.Cursor = Cursors.IBeam;
            textBox_NhanXet.ReadOnly = false;
            RatingStar.ReadOnly = false;
            button_Save.Show();
            button_Edit.Hide();
            label2.Hide();
        }

        
        private void button_Save_Click(object sender, EventArgs e)
        {
            using (var db = new NhanVienEntities())
            {
                var idsach = db.Sach
                    .Where(t => t.TenSach == label_TenSach.Text)
                    .Select(t => t.IDSach)
                    .SingleOrDefault();


                var danhgia = db.DanhGiaSach
                    .FirstOrDefault(d => (d.IDNguoiDung == IDNguoiDung3) && (d.IDSach == idsach));



                if (danhgia != null)
                {
                    danhgia.DiemDanhGia = (int)RatingStar.Value;
                    danhgia.NhanXet = textBox_NhanXet.Text;

                    db.SaveChanges();

                    MessageBox.Show("Lưu Nhận xét thành công");
                    Hide();
                }
                else
                {
                    danhgia = new DanhGiaSach
                    {
                        IDNguoiDung = IDNguoiDung3, // Giá trị của IDNguoiDung bạn muốn gán
                        IDSach = idsach,
                        DiemDanhGia = (int)RatingStar.Value,
                        NhanXet = textBox_NhanXet.Text
                    };

                    // Thêm đối tượng mới vào db
                    db.DanhGiaSach.AddObject(danhgia);
                    db.SaveChanges();
                    //MessageBox.Show("Không tìm thấy đánh giá cho sách này.");
                }


            }  
        }
    }
}
