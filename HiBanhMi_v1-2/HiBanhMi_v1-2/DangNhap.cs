using HiBanhMi_v1_2.Codes;
using HiBanhMi_v1_2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiBanhMi_v1_2
{
    public partial class DangNhap : Form
    {
        DocFile docfile = new DocFile();
        GhiFile ghifile = new GhiFile();
        int speed = 20;
        Capnhat cn = new Capnhat();



        public DangNhap()
        {
            InitializeComponent();

            cn.updt();
            docfile.TaiKhoan(tk.TK);
            pn_qmk.Visible = false;
            tb_qmk_mk.Visible = false;
            checkBox3.Visible = false;
            bt_lui.Visible = false;

            pn_qmk.Location = new Point(0, 0);


            //---------------------------------
            tb_dn_taikhoan.AA_Content = "1";//|
            tb_dn_matkhau.AA_Content = "1";// |
        }
        private void DangNhap_Load(object sender, EventArgs e)
        {
            // text
            lb_dontiep.Text = NN.nn[0];
            tb_dn_taikhoan.AA_Title = NN.nn[1];
            tb_dn_matkhau.AA_Title = NN.nn[3];
            tb_dk_taikhoan.AA_Title = NN.nn[1];
            tb_dk_email.AA_Title = NN.nn[2];
            tb_dk_matkhau.AA_Title = NN.nn[3];
            lb_thongbao.Text = NN.nn[4];
            bt_dangnhap.Text = NN.nn[6];
            bt_dangky.Text = NN.nn[7];
            bt_chuyendk.Text = NN.nn[7];
            bt_chuyendn.Text = NN.nn[6];
            lb_qmk.Text = NN.nn[13];
            tb_qmk_email.AA_Title = NN.nn[2];
            tb_qmk_mk.AA_Title = NN.nn[3];
            lb_kiemtra.Text = NN.nn[15];
            bt_qmk.Text = NN.nn[18];
            checkBox1.Text = NN.nn[20];
            checkBox2.Text = NN.nn[20];
            checkBox3.Text = NN.nn[20];

            // color
            this.BackColor = ColorTranslator.FromHtml(THEME.t[0]);
            tb_dn_taikhoan.AA_BackgroundColor = ColorTranslator.FromHtml(THEME.t[1]);
            tb_dn_taikhoan.AA_BorderColor = ColorTranslator.FromHtml(THEME.t[1]);
            tb_dn_matkhau.AA_BackgroundColor = ColorTranslator.FromHtml(THEME.t[1]);
            tb_dn_matkhau.AA_BorderColor = ColorTranslator.FromHtml(THEME.t[1]);
            tb_dk_taikhoan.AA_BackgroundColor = ColorTranslator.FromHtml(THEME.t[1]);
            tb_dk_taikhoan.AA_BorderColor = ColorTranslator.FromHtml(THEME.t[1]);
            tb_dk_email.AA_BackgroundColor = ColorTranslator.FromHtml(THEME.t[1]);
            tb_dk_email.AA_BorderColor = ColorTranslator.FromHtml(THEME.t[1]);
            tb_dk_matkhau.AA_BackgroundColor = ColorTranslator.FromHtml(THEME.t[1]);
            tb_dk_matkhau.AA_BorderColor = ColorTranslator.FromHtml(THEME.t[1]);
            bt_dangnhap.BackColor = ColorTranslator.FromHtml(THEME.t[2]);
            bt_dangnhap.BorderColor = ColorTranslator.FromHtml(THEME.t[2]);
            bt_dangky.BackColor = ColorTranslator.FromHtml(THEME.t[2]);
            bt_dangky.BorderColor = ColorTranslator.FromHtml(THEME.t[2]);
            bt_chuyendk.BackColor = ColorTranslator.FromHtml(THEME.t[2]);
            bt_chuyendk.BorderColor = ColorTranslator.FromHtml(THEME.t[2]);
            bt_chuyendn.BackColor = ColorTranslator.FromHtml(THEME.t[2]);
            bt_chuyendn.BorderColor = ColorTranslator.FromHtml(THEME.t[2]);
            pn_qmk.BackColor = ColorTranslator.FromHtml(THEME.t[1]);
            pn_qmk_fill.BackColor = ColorTranslator.FromHtml(THEME.t[0]);
            tb_qmk_email.AA_BackgroundColor = ColorTranslator.FromHtml(THEME.t[1]);
            tb_qmk_email.AA_BorderColor = ColorTranslator.FromHtml(THEME.t [1]);
            tb_qmk_mk.AA_BackgroundColor = ColorTranslator.FromHtml(THEME.t [1]);
            tb_qmk_mk.AA_BorderColor = ColorTranslator.FromHtml(THEME.t[1]);
            bt_qmk.BackColor = ColorTranslator.FromHtml (THEME.t[2]);
            bt_qmk.BorderColor = ColorTranslator.FromHtml(THEME.t [2]);



            // pass
            tb_dk_matkhau.AA_pass = true;
            tb_dn_matkhau.AA_pass = true;
        }








        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (tb_dn_taikhoan.AA_Content.Length == 0)
            {
                lb_dontiep.Text = NN.nn[8];
                lb_dontiep.ForeColor = Color.Red;
                return;
            }
            if (tb_dn_matkhau.AA_Content.Length == 0)
            {
                lb_dontiep.Text = NN.nn[8];
                lb_dontiep.ForeColor = Color.Red;
                return;
            }
            foreach (TaiKhoan taik in tk.TK)
            {

                if (tb_dn_taikhoan.AA_Content == taik.Tk )
                {
                    if (tb_dn_matkhau.AA_Content == taik.Mk)
                    {
                        tkon.Tkc = taik.Tk; tkon.Emailc = taik.Email; tkon.Mkc = taik.Mk;
                        this.Hide();
                        FormMain formm  = new FormMain();
                        formm.Show();
                        check = 1;
                        break;
                    }
                    else
                    {
                        lb_dontiep.Text = NN.nn[12];
                        lb_dontiep.ForeColor = Color.Red;
                        check = 1;
                        break;
                    }
                }    
            }
            if (check == 0)
            {
                lb_dontiep.Text = NN.nn[9];
                lb_dontiep.ForeColor = Color.Red;
            }
        }

        private void bt_dangky_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (tb_dk_taikhoan.AA_Content.Length == 0) 
            {
                lb_thongbao.Text = NN.nn[8];
                lb_thongbao.ForeColor = Color.Red;
                return; 
            }
            if (tb_dk_email.AA_Content.Length == 0) 
            {
                lb_thongbao.Text = NN.nn[8];
                lb_thongbao.ForeColor = Color.Red;
                return; 
            }
            if (tb_dk_matkhau.AA_Content.Length < 8) 
            {
                lb_thongbao.Text = NN.nn[10];
                lb_thongbao.ForeColor = Color.Red;
                return; 
            }
            foreach (TaiKhoan taik in tk.TK)
            {
                if (tb_dk_taikhoan.AA_Content == taik.Tk)
                {
                    lb_thongbao.Text = NN.nn[5];
                    lb_thongbao.ForeColor = Color.Red;
                    check++;
                }
            }
            foreach (TaiKhoan taik in tk.TK)
            {
                if (tb_dk_email.AA_Content == taik.Email)
                {
                    lb_thongbao.Text = NN.nn[22];
                    lb_thongbao.ForeColor = Color.Red;
                    check++;
                }
            }
            if (check == 0)
            {
                lb_thongbao.Text = NN.nn[11];
                lb_thongbao.ForeColor = Color.Green;
                tk.TK.Add(new TaiKhoan(tb_dk_taikhoan.AA_Content, tb_dk_email.AA_Content, tb_dk_matkhau.AA_Content));
                ghifile.Taikhoan(tk.TK);
                tb_dk_taikhoan.AA_Content = "";
                tb_dk_email.AA_Content = "";
                tb_dk_matkhau.AA_Content = "";
                tb_dn_taikhoan.AA_Content = "";
                tb_dn_matkhau.AA_Content = "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tb_dn_matkhau.AA_pass = false;
            }
            else tb_dn_matkhau.AA_pass = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                tb_dk_matkhau.AA_pass = false;
            }
            else tb_dk_matkhau.AA_pass = true;
        }

        private void bt_chuyendk_Click(object sender, EventArgs e)
        {
            tgdk.Start();
        }
        private void bt_chuyendn_Click(object sender, EventArgs e)
        {
            tgdn.Start();
        }

        private void tgdk_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(pn_chuyen.Location.X.ToString());
            pn_chuyen.Location = new Point(pn_chuyen.Location.X - speed, pn_chuyen.Location.Y);
            pic_porter.Location = new Point(pic_porter.Location.X + speed, pic_porter.Location.Y);
            bt_chuyendk.Location = new Point(bt_chuyendk.Location.X + speed, bt_chuyendk.Location.Y);
            bt_chuyendn.Location = new Point(bt_chuyendn.Location.X + speed, bt_chuyendn.Location.Y);
            if (pn_chuyen.Location.X == 0) tgdk.Stop();
        }

        private void tgdn_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(pn_chuyen.Location.X.ToString());
            pn_chuyen.Location = new Point(pn_chuyen.Location.X + speed, pn_chuyen.Location.Y);
            pic_porter.Location = new Point(pic_porter.Location.X - speed, pic_porter.Location.Y);
            bt_chuyendk.Location = new Point(bt_chuyendk.Location.X - speed, bt_chuyendk.Location.Y);
            bt_chuyendn.Location = new Point(bt_chuyendn.Location.X - speed, bt_chuyendn.Location.Y);
            if (pn_chuyen.Location.X == 400) tgdn.Stop();
        }

        private void lb_quenmatkhau_Click(object sender, EventArgs e)
        {
            pn_qmk.Visible = true;
            bt_lui.Visible = true;
            bt_lui.BringToFront();
        }




        int buoc = 1;
        private void bt_qmk_Click(object sender, EventArgs e)
        {
            if (buoc == 1)
            {
                foreach (TaiKhoan taik in tk.TK)
                {
                    if (tb_qmk_email.AA_Content == taik.Email)
                    {
                        tb_qmk_mk.Visible = true;
                        tb_qmk_email.Enabled = false;
                        checkBox3.Visible = true;
                        buoc = 2;
                        bt_qmk.Text = NN.nn[19];
                        lb_kiemtra.Text = NN.nn[21];
                        lb_kiemtra.ForeColor = Color.Green;
                        break;
                    }
                    else buoc = 3;
                }
            }
            else if (buoc == 2)
            {
                foreach (TaiKhoan taik in tk.TK)
                {
                    if (tb_qmk_email.AA_Content == taik.Email)
                    {
                        if (tb_qmk_mk.AA_Content.Length > 7)
                        {
                            taik.Mk = tb_qmk_mk.AA_Content;
                            ghifile.Taikhoan(tk.TK);
                            lb_kiemtra.Text = NN.nn[17];
                            lb_kiemtra.ForeColor = Color.Green;
                            pn_qmk_fill.Enabled = false;
                        }
                        else
                        {
                            lb_kiemtra.Text = NN.nn[10];
                            lb_kiemtra.ForeColor = Color.Red;
                        }
                    }
                }
            }
            else
            {
                lb_kiemtra.Text = NN.nn[16];
                lb_kiemtra.ForeColor = Color.Red;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                tb_qmk_mk.AA_pass = false;
            }else tb_qmk_mk.AA_pass=true;
        }

        private void bt_lui_Click(object sender, EventArgs e)
        {
            pn_qmk.Visible = false;
            bt_lui.Visible = false;
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
