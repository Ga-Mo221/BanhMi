using HiBanhMi_v1_2.Codes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiBanhMi_v1_2.Forms
{
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
            this.Size = new Size(787, 640);

            //set color
            setcolor();

            //set ngon ngu
            setngonngu();

            panel1.Enabled = false;
            tb_nickname.ReadOnly = true;
            pn_doipass.Visible = false;
            bt_doipass.SendToBack();
        }

        private void bt_Capnhat_Click(object sender, EventArgs e)
        {
            if (bt_Capnhat.Text == NN.nn[19])
            {
                bt_Capnhat.Text = NN.nn[53];
                panel1.Enabled = false;
                tb_nickname.ReadOnly = true;
                pn_doipass.Visible = false;
                bt_doipass.Text = NN.nn[58];

                // xuly
                if (tb_nickname.Text != uson.users.nickname || tb_hoten.Text != uson.users.hoten || tb_sdt.Text != uson.users.sdt || tb_diachi.Text != uson.users.diachi || lb_sinhnhat.AA_sinhnhat != uson.users.sinhnhat || lb_gioitinh.AA_gioitinh != uson.users.gioitinh)
                {
                    foreach (user us in userlist.users)
                    {
                        if (tkon.Tkc == us.taikhoan)
                        {
                            us.nickname = tb_nickname.Text;
                            us.hoten = tb_hoten.Text;
                            us.sdt = tb_sdt.Text;
                            us.diachi = tb_diachi.Text;
                            us.sinhnhat = lb_sinhnhat.AA_sinhnhat;
                            us.gioitinh = lb_gioitinh.AA_gioitinh;
                            
                            uson.users = new user(us);
                            Console.WriteLine("gan xong");
                        }
                    }
                }
                GhiFile ghi = new GhiFile();
                ghi.userprofile(userlist.users);
                Console.WriteLine("ghi thanh cong");
                //
            }
            else
            {
                bt_Capnhat.Text = NN.nn[19];
                panel1.Enabled = true;
                tb_nickname.ReadOnly = false;
            }
        }

        private void pic_suaavata_Click(object sender, EventArgs e)
        {
            user currentUser = img.addimg(tkon.Tkc, pic_avata);

            if (currentUser != null)
            {
                FormMain fm = Application.OpenForms.OfType<FormMain>().FirstOrDefault();
                if (fm != null)
                {
                    fm.tcn.AA_anhdaidien = img.LoadImageWithoutLocking(img.getpathImg("avatar",uson.users.avata));
                    fm.Refresh();
                }
            }
        }

        private void pic_suatt_Click(object sender, EventArgs e)
        {
            bt_Capnhat.Text = NN.nn[19];
            panel1.Enabled = true;
            tb_nickname.ReadOnly = false;   
        }
        
        private void bt_doipass_Click(object sender, EventArgs e)
        {
            if (bt_doipass.Text == NN.nn[58]) 
            {
                lb_gioitinh.BringToFront();
                pn_doipass.Visible = true;
                bt_doipass.Text = NN.nn[19]; 
            }else if (bt_doipass.Text == NN.nn[19])
            {
                if (tb_mkCu.AA_Content.Length == 0)
                {
                    lb_thongbao.Text = NN.nn[8];
                    lb_thongbao.ForeColor = Color.Red;
                    return;
                }
                if (tb_mkmoi.AA_Content.Length == 0)
                {
                    lb_thongbao.Text = NN.nn[8];
                    lb_thongbao.ForeColor = Color.Red;
                    return; 
                }
                if (tb_xacnhanmkmoi.AA_Content.Length == 0)
                {
                    lb_thongbao.Text = NN.nn[8];
                    lb_thongbao.ForeColor = Color.Red;
                    return; 
                }
                if (tb_mkCu.AA_Content != tkon.Mkc)
                {
                    lb_thongbao.Text = NN.nn[12];
                    lb_thongbao.ForeColor = Color.Red;
                    return;
                }
                if (tb_mkmoi.AA_Content.Length < 9)
                {
                    lb_thongbao.Text = NN.nn[10];
                    lb_thongbao.ForeColor = Color.Red;
                    return;
                }
                if (tb_xacnhanmkmoi.AA_Content != tb_mkmoi.AA_Content)
                {
                    lb_thongbao.Text = NN.nn[59];
                    lb_thongbao.ForeColor = Color.Red;
                    return;
                }

                foreach (TaiKhoan tkhoan in tk.TK)
                {
                    if (tkhoan.Tk == tkon.Tkc)
                    {
                        tkhoan.Mk = tb_mkmoi.AA_Content;
                        tkon.Mkc = tb_mkmoi.AA_Content;
                        GhiFile ghi = new GhiFile();
                        ghi.Taikhoan(tk.TK);
                        lb_thongbao.Text = NN.nn[60];
                        lb_thongbao.ForeColor = Color.Green;
                    }
                }
            }
        }















        private void setcolor()
        {
            this.BackColor = ColorTranslator.FromHtml(THEME.t[0]);

            lb_nickname.ForeColor = Color.Black;
            lb_hoten.ForeColor = Color.Black;
            lb_diachi.ForeColor = Color.Black;
            lb_sdt.ForeColor = Color.Black;
            tb_nickname.BackColor = ColorTranslator.FromHtml (THEME.t[0]);
            tb_hoten.BackColor = ColorTranslator.FromHtml(THEME.t[0]);
            tb_diachi.BackColor = ColorTranslator.FromHtml(THEME.t[0]);
            tb_sdt.BackColor = ColorTranslator.FromHtml(THEME.t[0]);
            lb_sinhnhat.AA_mauLBduocchon = THEME.t[2];
            lb_gioitinh.AA_mauchon = THEME.t[2];
            bt_Capnhat.BackColor = ColorTranslator.FromHtml(THEME.t[2]);
            bt_Capnhat.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml(THEME.t[3]);
            bt_doipass.BackColor = ColorTranslator.FromHtml(THEME.t[4]);
            tb_mkCu.AA_BackgroundColor = ColorTranslator.FromHtml(THEME.t[7]);
            tb_mkCu.AA_BorderColor = ColorTranslator.FromHtml(THEME.t[7]);
            tb_mkmoi.AA_BackgroundColor = ColorTranslator.FromHtml(THEME.t[7]);
            tb_mkmoi.AA_BorderColor = ColorTranslator.FromHtml(THEME.t[7]);
            tb_xacnhanmkmoi.AA_BorderColor = ColorTranslator.FromHtml(THEME.t[7]);
            tb_xacnhanmkmoi.AA_BackgroundColor = ColorTranslator.FromHtml(THEME.t[7]);
            lb_thongbao.ForeColor = Color.Black;
            pic_avata.Image = Image.FromFile(img.getpathImg("avatar", uson.users.avata));
        }
        private void setngonngu()
        {
            lb_nickname.Text = NN.nn[45];
            lb_hoten.Text = NN.nn[46];
            lb_sdt.Text = NN.nn[48];
            lb_diachi.Text = NN.nn[47];
            lb_sinhnhat.AA_title = NN.nn[52];
            lb_gioitinh.AA_Title = NN.nn[49];
            lb_gioitinh.AA_nam = NN.nn[50];
            lb_gioitinh.AA_nu = NN.nn[51];
            lb_gioitinh.AA_khac = NN.nn[54];
            bt_Capnhat.Text = NN.nn[53];
            tb_mkCu.AA_Title = NN.nn[55];
            tb_mkmoi.AA_Title = NN.nn[56];
            tb_xacnhanmkmoi.AA_Title = NN.nn[57];
            bt_doipass.Text = NN.nn[58];
            tb_hoten.Text = uson.users.hoten;
            tb_nickname.Text = uson.users.nickname;
            tb_sdt.Text = uson.users.sdt;
            lb_gioitinh.AA_gioitinh = uson.users.gioitinh;
            tb_diachi.Text = uson.users.diachi;
            lb_sinhnhat.AA_sinhnhat = uson.users.sinhnhat;
            lb_thongbao.Text = NN.nn[58];
        }

    }
}
