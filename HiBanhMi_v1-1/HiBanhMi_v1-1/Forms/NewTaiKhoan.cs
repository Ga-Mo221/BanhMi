using HiBanhMi_v1_1.Datacode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiBanhMi_v1_1.Forms
{
    public partial class NewTaiKhoan : Form
    {

        AddPhoto addpt = new AddPhoto();


        public NewTaiKhoan()
        {
            InitializeComponent();

            //sự kiện combobox
            cbb_ngay.BTOptionClicked += Cbb_ngay_BTOptionClicked;
            cbb_thang.BTOptionClicked += Cbb_thang_BTOptionClicked;
            cbb_nam.BTOptionClicked += Cbb_nam_BTOptionClicked;
            cbb_gioitinh.BTOptionClicked += Cbb_gioitinh_BTOptionClicked;


            // sự kiện textbox
            tb_ten.NoiDungCliked += Tb_ten_NoiDungCliked;
            tb_ten.NoiDungTextChanged += Tb_ten_NoiDungTextChanged;
            tb_sdt.NoiDungCliked += Tb_sdt_NoiDungCliked;
            tb_sdt.NoiDungTextChanged += Tb_sdt_NoiDungTextChanged;
            tb_diachi.NoiDungCliked += Tb_diachi_NoiDungCliked;
            tb_diachi.NoiDungTextChanged += Tb_diachi_NoiDungTextChanged;
            tb_bietdanh.NoiDungCliked += Tb_bietdanh_NoiDungCliked;
            tb_bietdanh.NoiDungTextChanged += Tb_bietdanh_NoiDungTextChanged;

            // dua cac pic noi xuong duoi 
            pic_iconuse.SendToBack();
            pic_diachi.SendToBack();
            pic_dienthoai.SendToBack();
        }


        private void Tb_bietdanh_NoiDungTextChanged(object sender, EventArgs e)
        {
        }

        private void Tb_diachi_NoiDungTextChanged(object sender, EventArgs e)
        {
        }

        private void Tb_sdt_NoiDungTextChanged(object sender, EventArgs e)
        {
        }

        private void Tb_ten_NoiDungTextChanged(object sender, EventArgs e)
        {
        }

        private void Tb_bietdanh_NoiDungCliked(object sender, EventArgs e)
        {
            tb_ten.Anline();
            tb_sdt.Anline();
            tb_diachi.Anline();
            cbb_ngay.Anline();
            cbb_thang.Anline();
            cbb_nam.Anline();
            cbb_gioitinh.Anline();
        }
        private void Tb_diachi_NoiDungCliked(object sender, EventArgs e)
        {
            tb_ten.Anline();
            tb_sdt.Anline();
            tb_bietdanh.Anline();
            cbb_ngay.Anline();
            cbb_thang.Anline();
            cbb_nam.Anline();
            cbb_gioitinh.Anline();
        }
        private void Tb_sdt_NoiDungCliked(object sender, EventArgs e)
        {
            tb_ten.Anline();
            tb_diachi.Anline();
            tb_bietdanh.Anline();
            cbb_ngay.Anline();
            cbb_thang.Anline();
            cbb_nam.Anline();
            cbb_gioitinh.Anline();
        }
        private void Tb_ten_NoiDungCliked(object sender, EventArgs e)
        {
            tb_sdt.Anline();
            tb_diachi.Anline();
            tb_bietdanh.Anline();
            cbb_ngay.Anline();
            cbb_thang.Anline();
            cbb_nam.Anline();
            cbb_gioitinh.Anline();
        }
        private void Cbb_gioitinh_BTOptionClicked(object sender, EventArgs e)
        {
            tb_ten.Anline();
            tb_sdt.Anline();
            tb_diachi.Anline();
            tb_bietdanh.Anline();
            cbb_ngay.Anline();
            cbb_thang.Anline();
            cbb_nam.Anline();
        }
        private void Cbb_nam_BTOptionClicked(object sender, EventArgs e)
        {
            tb_ten.Anline();
            tb_sdt.Anline();
            tb_diachi.Anline();
            tb_bietdanh.Anline();
            cbb_ngay.Anline();
            cbb_thang.Anline();
            cbb_gioitinh.Anline();
        }
        private void Cbb_thang_BTOptionClicked(object sender, EventArgs e)
        {
            tb_ten.Anline();
            tb_sdt.Anline();
            tb_diachi.Anline();
            tb_bietdanh.Anline();
            cbb_ngay.Anline();
            cbb_nam.Anline();
            cbb_gioitinh.Anline();
        }
        private void Cbb_ngay_BTOptionClicked(object sender, EventArgs e)
        {
            tb_ten.Anline();
            tb_sdt.Anline();
            tb_diachi.Anline();
            tb_bietdanh.Anline();
            cbb_thang.Anline();
            cbb_nam.Anline();
            cbb_gioitinh.Anline();
        }












        // sử lí hình ảnh avata
        private void bt_sua_Click(object sender, EventArgs e)
        {
            addpt.ThemAnh(pic_avatar);
        }













        // chuyen tiep loi mo dau
        int speed = 50;
        private void pic_chuyentiep_Click(object sender, EventArgs e)
        {
            tgchuyen.Start();
        }
        private void bt_chuyentiep_Click(object sender, EventArgs e)
        {
            tgchuyen.Start();
        }
        private void tgchuyen_Tick(object sender, EventArgs e)
        {
            if (pic_loimodau.Location.X <= 0)
            {
                pic_loimodau.Location = new Point(pic_loimodau.Location.X - speed, pic_loimodau.Location.Y);
                pic_chuyentiep.Visible = false;
                bt_chuyentiep.Location = new Point(bt_chuyentiep.Location.X - speed, bt_chuyentiep.Location.Y);
                if (pic_loimodau.Location.X == -1400)
                    tgchuyen.Stop();
            }
            if (pic_loimodau.Location.X < -1400)
            {
                pic_loimodau.Location = new Point(pic_loimodau.Location.X - speed, pic_loimodau.Location.Y);
                bt_chuyentiep.Location = new Point(bt_chuyentiep.Location.X - speed, bt_chuyentiep.Location.Y);
                if (pic_loimodau.Location.X == -2800)
                {
                    tgchuyen.Stop();
                    pic_iconuse.BringToFront();
                    pic_diachi.BringToFront();
                    pic_dienthoai.BringToFront();
                }
            }
        }














        // nút bấm
        private void nutCustom1_Click(object sender, EventArgs e)
        {
            tb_ten.Anline();
            tb_sdt.Anline();
            tb_diachi.Anline();
            tb_bietdanh.Anline();
            cbb_ngay.Anline();
            cbb_thang.Anline();
            cbb_nam.Anline();
            cbb_gioitinh.Anline();

            this.Hide();
            FormMain formMain = new FormMain();
            // Đăng ký sự kiện FormClosed
            formMain.FormClosed += (s, args) => Application.Exit();
            formMain.Show();
        }

        private void bt_exit_loimodau_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
