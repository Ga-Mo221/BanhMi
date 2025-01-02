using HiBanhMi_v1_1.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiBanhMi_v1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Hien line taikhoan dang nhap
            tb_DN_TaiKhoan.Hienline();

            // hiểu thị panel chuyển lên trên
            pn_Chuyen.BringToFront();

            // hiển thị exit lên trên
            bt_Exit.BringToFront();

            // tao su kien tb
            tb_DN_TaiKhoan.NoiDungCliked += Tb_DN_TaiKhoan_NoiDungCliked;
            tb_DN_MatKhau.NoiDungCliked += Tb_DN_MatKhau_NoiDungCliked;
            tb_DK_TaiKhoan.NoiDungCliked += Tb_DK_TaiKhoan_NoiDungCliked;
            tb_DK_Email.NoiDungCliked += Tb_DK_Email_NoiDungCliked;
            tb_DK_MatKhau.NoiDungCliked += Tb_DK_MatKhau_NoiDungCliked;

            // su kien mat khau
            tb_DN_MatKhau.NoiDungTextChanged += Tb_DN_MatKhau_NoiDungTextChanged;
            tb_DK_MatKhau.NoiDungTextChanged += Tb_DK_MatKhau_NoiDungTextChanged;
            //su kien ngoai le
            tb_DN_TaiKhoan.NoiDungTextChanged += Tb_DN_TaiKhoan_NoiDungTextChanged;
            tb_DK_TaiKhoan.NoiDungTextChanged += Tb_DK_TaiKhoan_NoiDungTextChanged;
            tb_DK_Email.NoiDungTextChanged += Tb_DK_Email_NoiDungTextChanged;

            // tao su kien button dang nhap va dang ky
            bt_DN_DangNhap.Click += Bt_DN_DangNhap_Click;
            bt_DK_DangKy.Click += Bt_DK_DangKy_Click;
        }






        // sự kiện ấn của textbox
        private void Tb_DN_TaiKhoan_NoiDungCliked(object sender, EventArgs e)
        {
            tb_DN_MatKhau.Anline();
            tb_DK_TaiKhoan.Anline();
            tb_DK_Email.Anline();
            tb_DK_MatKhau.Anline();
        }

        private void Tb_DN_MatKhau_NoiDungCliked(object sender, EventArgs e)
        {
            tb_DN_TaiKhoan.Anline();
            tb_DK_TaiKhoan.Anline();
            tb_DK_Email.Anline();
            tb_DK_MatKhau.Anline();
        }

        private void Tb_DK_MatKhau_NoiDungCliked(object sender, EventArgs e)
        {
            tb_DN_MatKhau.Anline();
            tb_DK_TaiKhoan.Anline();
            tb_DK_Email.Anline();
            tb_DN_TaiKhoan.Anline();
        }

        private void Tb_DK_Email_NoiDungCliked(object sender, EventArgs e)
        {
            tb_DN_MatKhau.Anline();
            tb_DK_TaiKhoan.Anline();
            tb_DN_TaiKhoan.Anline();
            tb_DK_MatKhau.Anline();
        }

        private void Tb_DK_TaiKhoan_NoiDungCliked(object sender, EventArgs e)
        {
            tb_DN_MatKhau.Anline();
            tb_DN_TaiKhoan.Anline();
            tb_DK_Email.Anline();
            tb_DK_MatKhau.Anline();
        }






        // sự kiện chuyển màn hình
        int speed = 20;

        private void bt_DangKy_Click(object sender, EventArgs e)
        {
            time_DK.Start();
        }
        private void time_DK_Tick(object sender, EventArgs e)
        {
            pn_Chuyen.Location = new Point(pn_Chuyen.Location.X - speed, pn_Chuyen.Location.Y);
            pic_porter.Location = new Point(pic_porter.Location.X + speed, pic_porter.Location.Y);
            bt_DangKy.Location = new Point(bt_DangKy.Location.X + speed, bt_DangKy.Location.Y);
            bt_DangNhap.Location = new Point(bt_DangNhap.Location.X + speed, bt_DangNhap.Location.Y);

            if (pn_Chuyen.Location.X == 0)
                time_DK.Stop();
        }

        //--------------------------
        private void bt_DangNhap_Click(object sender, EventArgs e)
        {
            time_DN.Start();
        }
        private void time_DN_Tick(object sender, EventArgs e)
        {
            pn_Chuyen.Location = new Point(pn_Chuyen.Location.X + speed, pn_Chuyen.Location.Y);
            pic_porter.Location = new Point(pic_porter.Location.X - speed, pic_porter.Location.Y);
            bt_DangKy.Location = new Point(bt_DangKy.Location.X - speed, bt_DangKy.Location.Y);
            bt_DangNhap.Location = new Point(bt_DangNhap.Location.X - speed, bt_DangNhap.Location.Y);

            if (pn_Chuyen.Location.X == 500)
                time_DN.Stop();
        }









        // Hàm update thông báo
        private void UpdateTB_DN(string noidung, Color color)
        {
            lb_DN_ThongBao.Text = noidung;
            lb_DN_ThongBao.ForeColor = color;
        }
        private void UpdateTB_DK(string noidung, Color color)
        {
            lb_DK_ThongBao.Text = noidung;
            lb_DK_ThongBao.ForeColor = color;
        }









        // kiểm tra mật khẩu
        int DN_count_mk;
        int DK_count_mk;

        private void Tb_DN_MatKhau_NoiDungTextChanged(object sender, EventArgs e)
        {
            DN_count_mk = tb_DN_MatKhau.Updateposition();
            if (DN_count_mk > 7)
            {
                UpdateTB_DN("Welcome!", Color.Green);
            }
            else 
            {
                UpdateTB_DN("Mật Khẩu Chưa Đủ 8 Ký Tự!", Color.Red);
            }
        }
        private void Tb_DK_MatKhau_NoiDungTextChanged(object sender, EventArgs e)
        {
            DK_count_mk = tb_DK_MatKhau.Updateposition();
            if (DK_count_mk > 7)
            {
                UpdateTB_DK("Mật Khẩu Đã OK Rồi!", Color.Green);
                if (DK_count_mk > 10)
                    UpdateTB_DK("Mật Khẩu Của Bạn Thật Đỉnh ^-^", Color.Green);
            }
            else
            {
                UpdateTB_DK("Mật Khẩu Chưa Đủ 8 Ký Tự!", Color.Red);
            }
        }

        // Hien thi mat khau
        private void bt_DN_showmk_Click(object sender, EventArgs e)
        {
            if (tb_DN_MatKhau.HienThiMatKau == true )
                tb_DN_MatKhau.HienThiMatKau = false;
            else
                tb_DN_MatKhau.HienThiMatKau = true;
        }
        private void bt_DK_showmk_Click(object sender, EventArgs e)
        {
            if (tb_DK_MatKhau.HienThiMatKau == true)
                tb_DK_MatKhau.HienThiMatKau = false;
            else
                tb_DK_MatKhau.HienThiMatKau = true;
        }

        //su kien textchanged của các textbox khác
        int DN_count_tk;
        int DK_count_tk;
        int DK_count_Em;
        private void Tb_DK_TaiKhoan_NoiDungTextChanged(object sender, EventArgs e)
        {
            DK_count_tk = tb_DK_TaiKhoan.Updateposition();
        }
        private void Tb_DN_TaiKhoan_NoiDungTextChanged(object sender, EventArgs e)
        {
            DN_count_tk = tb_DN_TaiKhoan.Updateposition();
        }
        private void Tb_DK_Email_NoiDungTextChanged(object sender, EventArgs e)
        {
            DK_count_Em = tb_DK_Email.Updateposition();
        }











        // ẩn line tất cả textbox
        private void anallline()
        {
            tb_DN_MatKhau.Anline();
            tb_DN_TaiKhoan.Anline();
            tb_DK_Email.Anline();
            tb_DK_MatKhau.Anline();
            tb_DK_TaiKhoan.Anline();
        }










        // sự kiện chính
        private void Bt_DK_DangKy_Click(object sender, EventArgs e)
        {
            anallline();
            if (DK_count_mk > 7 && DK_count_tk > 0 && DK_count_Em > 0)
                MessageBox.Show("dang ky");
            else
            {
                UpdateTB_DK("Có lẽ một cái gì đó đang Thiếu?", Color.Red);
            }
        }

        private void Bt_DN_DangNhap_Click(object sender, EventArgs e)
        {
            anallline();
            if (DN_count_mk > 7 && DN_count_tk > 0)
            {
                this.Hide();
                NewTaiKhoan newTaiKhoan = new NewTaiKhoan();
                // Đăng ký sự kiện FormClosed
                newTaiKhoan.FormClosed += (s, args) => Application.Exit();
                newTaiKhoan.Show();
            }
            else
            {
                UpdateTB_DN("Có lẽ một cái gì đó đang Thiếu?", Color.Red);
            }
        }







        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
