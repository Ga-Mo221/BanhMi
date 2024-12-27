using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiBanhMi
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            btdangnhap.Enabled = false;
            btdangky.Enabled = false;
            btchuyendangnhap.Visible = false;
        }

        private void sentobackDangNhap()
        {
            piciconlogin.SendToBack();
            picexittrai.SendToBack();
            pntaikhoan.SendToBack();
            pnmatkhau.SendToBack();
            btdangnhap.SendToBack();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // đăng nhập
            piciconlogin.Size = new Size(170, 170);
            piciconlogin.Location = new Point(165, 60);
            pntaikhoan.Size = new Size(280, 50);
            pntaikhoan.Location = new Point(110, 260);
            pnmatkhau.Size = new Size(280, 50);
            pnmatkhau.Location = new Point(110, 330);
            btdangnhap.Size = new Size(180, 65);
            btdangnhap.Location = new Point(160, 400);
            string fodername = "DangNhapPhoTo";
            ImageManager manager = new ImageManager();
            manager.LoadImage(picexittrai, fodername, "Exiticon");


            // đăng ký
            pnDKtendangnhap.Size = new Size(280, 50);
            pnDKtendangnhap.Location = new Point(610, 185);
            pnDKemail.Size = new Size(280, 50);
            pnDKemail.Location = new Point(610, 255);
            pnDKmatkhau.Size = new Size(280, 50);
            pnDKmatkhau.Location = new Point(610, 330);
            btdangky.Size = new Size(180, 65);
            btdangky.Location = new Point(660, 400);
            manager.LoadImage(picexitphai, fodername, "Exiticon");

            // chuyển 
            manager.LoadImage(picporter, fodername, "Porter");
            picporter.Size = new Size(1000, 600);
            picporter.Location = new Point(-500, 0);
            btchuyendangky.Size = new Size(210, 70);
            btchuyendangky.Location = new Point(145, 360);
            
            pnchuyen.Size = new Size(500, 600);
            pnchuyen.Location = new Point(500, 0);
            btchuyendangnhap.Size = new Size(210, 70);
        }

        private void picexittrai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picexitphai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void testboxTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if (testboxTaiKhoan.Text.Length > 0)
            {
                if (textboxMatKhau.Text.Length > 7)
                    btdangnhap.Enabled = true;
                else btdangnhap.Enabled = false;
            }
            else btdangnhap.Enabled = false ;
        }

        private void textboxMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (textboxMatKhau.Text.Length > 7)
            {
                lbthongbaodangnhap.ForeColor = Color.Green;
                lbthongbaodangnhap.Text = "Welcome!";
                if (testboxTaiKhoan.Text.Length > 0)
                    btdangnhap.Enabled = true;
                else btdangnhap.Enabled = false;
            }
            else 
            {
                lbthongbaodangnhap.Text = "*Mật khẩu chưa đủ 8 ký tự!";
                lbthongbaodangnhap.ForeColor = Color.Red;
                btdangnhap.Enabled = false; 
            }
        }

        private void testboxDKtendangnhap_TextChanged(object sender, EventArgs e)
        {
            if (testboxDKtendangnhap.Text.Length > 0)
            {
                if (testboxDKEmail.Text.Length > 0)
                {
                    if (testboxDKmatkhau.Text.Length > 7)
                        btdangky.Enabled = true;
                    else btdangky.Enabled = false;
                }
                else btdangky.Enabled = false;
            }
            else btdangky.Enabled = false;
        }

        private void testboxDKEmail_TextChanged(object sender, EventArgs e)
        {
            if (testboxDKEmail.Text.Length > 0)
            {
                if (testboxDKtendangnhap.Text.Length > 0)
                {
                    if (testboxDKmatkhau.Text.Length > 7)
                        btdangky.Enabled = true;
                    else btdangky.Enabled = false;
                }
                else btdangky.Enabled = false;
            }
            else btdangky.Enabled = false;
        }

        private void testboxDKmatkhau_TextChanged(object sender, EventArgs e)
        {
            if (testboxDKmatkhau.Text.Length > 7)
            {
                lbthongbaodangky.Text = "*Mật khẩu trung bình";
                lbthongbaodangky.ForeColor = Color.Green;
                if (testboxDKmatkhau.Text.Length > 10)
                    lbthongbaodangky.Text = "*Mật khẩu Mạnh";
                if (testboxDKtendangnhap.Text.Length > 0)
                {
                    if (testboxDKEmail.Text.Length > 0)
                        btdangky.Enabled = true;
                    else btdangky.Enabled = false;
                }
                else btdangky.Enabled = false;
            }
            else
            {
                lbthongbaodangky.Text = "*Mật khẩu chưa đủ 8 ký tự!";
                lbthongbaodangky.ForeColor = Color.Red;
                btdangky.Enabled = false;
            }
        }

        private void btchuyendangky_Click(object sender, EventArgs e)
        {
            timedangky.Start();
            testboxTaiKhoan.Text = "";
            textboxMatKhau.Text = "";
            this.AcceptButton = btdangky;
        }

        private void btchuyendangnhap_Click(object sender, EventArgs e)
        {
            timedangnhap.Start();
            testboxDKtendangnhap.Text = "";
            testboxDKEmail.Text = "";
            testboxDKmatkhau.Text = "";
            this.AcceptButton = btdangnhap;
        }
        int speed = 20;
        private void timedangky_Tick(object sender, EventArgs e)
        {
            pnchuyen.Location = new Point(pnchuyen.Location.X - speed, pnchuyen.Location.Y);
            if (pnchuyen.Location.X == 0)
            {
                timedangky.Stop();
            }
            if (pnchuyen.Location.X >= 0)
            {
                btchuyendangky.Location = new Point(btchuyendangky.Location.X + speed, btchuyendangky.Location.Y);
                picporter.Location = new Point(picporter.Location.X+speed, picporter.Location.Y);
            }
            if (pnchuyen.Location.X == 360)
            {
                btchuyendangnhap.Visible = true;
                btchuyendangnhap.Location = new Point(-210, 360);
            }
            if (pnchuyen.Location.X < 360)
            {
                btchuyendangnhap.Location = new Point(btchuyendangnhap.Location.X + speed, btchuyendangnhap.Location.Y);
            }
        }

        private void timedangnhap_Tick(object sender, EventArgs e)
        {
            pnchuyen.Location = new Point(pnchuyen.Location.X + speed, pnchuyen.Location.Y);
            if (pnchuyen.Location.X == 500)
            {
                timedangnhap.Stop();
            }
            if (pnchuyen.Location.X > 0)
            {
                btchuyendangnhap.Location = new Point(btchuyendangnhap.Location.X - speed, btchuyendangnhap.Location.Y);
            }
            if (pnchuyen.Location.X > 0)
            {
                btchuyendangky.Location = new Point(btchuyendangky.Location.X - speed, btchuyendangky.Location.Y);
                picporter.Location = new Point(picporter.Location.X - speed, picporter.Location.Y);
            }
        }

        private bool Checkdangnhap()
        {
            // code kiểm tra đăng nhập tại đây
            return true;
        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            bool kqdangnhap = Checkdangnhap();
            if (kqdangnhap)
            {
                this.Hide();
                FormMain formMain = new FormMain();
                formMain.Show();
                formMain.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btdangky_Click(object sender, EventArgs e)
        {
            MessageBox.Show
            (
                $"tài khoản: {testboxDKtendangnhap.Text}\n" +
                $"email: {testboxDKEmail.Text}\n" +
                $"mật khẩu: {testboxDKmatkhau.Text}"
            );
        }
    }
}
