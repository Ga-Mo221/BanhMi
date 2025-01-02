using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThanhChucNangChinh.chinh
{
    public partial class ThanhChucNangChinh : UserControl
    {
        string chucnang;
        int speed = 10;


        public event EventHandler HomeClick;
        public event EventHandler MenuClick;
        public event EventHandler YeuThichClick;
        public event EventHandler LichSuClick;
        public event EventHandler SettingClick;


        public ThanhChucNangChinh()
        {
            InitializeComponent();
            pic_chuyen.Location = new Point(0, 40);
            chucnang = "Home";
        }

        public string CHUCNANG
        {
            get { return chucnang; }
            set { chucnang = value; Invalidate(); }
        }
        public Image Home
        {
            get { return pic_home.Image; }
            set { pic_home.Image = value; Invalidate(); }
        }
        public Image Menu
        {
            get { return pic_menu.Image; }
            set { pic_menu.Image = value; Invalidate(); }
        }
        public Image YeuThich
        {
            get { return pic_yeuthich.Image; }
            set { pic_yeuthich.Image = value; Invalidate(); }
        }
        public Image LichSu
        {
            get { return pic_lichsu.Image; }
            set { pic_lichsu.Image = value; Invalidate(); }
        }
        public Image SetTing
        {
            get { return pic_setting.Image; }
            set { pic_setting.Image = value; Invalidate(); }
        }
        public Image CHUYEN
        {
            get { return pic_chuyen.Image; }
            set { pic_chuyen.Image = value; Invalidate(); }
        }










        private void pic_home_Click(object sender, EventArgs e)
        {
            chucnang = "Home";
            tgHome.Start();

            HomeClick.Invoke(this, e);
        }

        private void pic_menu_Click(object sender, EventArgs e)
        {
            chucnang = "Menu";
            tgMenu.Start();

            MenuClick.Invoke(this, e);
        }

        private void pic_yeuthich_Click(object sender, EventArgs e)
        {
            chucnang = "YeuThich";
            tgYeuThich.Start();

            YeuThichClick.Invoke(this, e);
        }

        private void pic_lichsu_Click(object sender, EventArgs e)
        {
            chucnang = "LichSu";
            tgLichSu.Start();

            LichSuClick.Invoke(this, e);
        }

        private void pic_setting_Click(object sender, EventArgs e)
        {
            chucnang = "Setting";
            tgSetting.Start();

            SettingClick.Invoke(this, e);
        }












        private void tgHome_Tick(object sender, EventArgs e)
        {
            if (pic_chuyen.Location.Y > 40)
            {
                pic_chuyen.Location = new Point(pic_chuyen.Location.X, pic_chuyen.Location.Y - speed);
            }
            else tgHome.Stop();
        }

        private void tgMenu_Tick(object sender, EventArgs e)
        {
            if (pic_chuyen.Location.Y > 110)
            {
                pic_chuyen.Location = new Point(pic_chuyen.Location.X, pic_chuyen.Location.Y - speed);
            }
            else if (pic_chuyen.Location.Y < 110)
            {
                pic_chuyen.Location = new Point(pic_chuyen.Location.X, pic_chuyen.Location.Y + speed);
            }
            else tgMenu.Stop();
        }

        private void tgYeuThich_Tick(object sender, EventArgs e)
        {
            if (pic_chuyen.Location.Y > 180)
            {
                pic_chuyen.Location = new Point(pic_chuyen.Location.X, pic_chuyen.Location.Y - speed);
            }
            else if (pic_chuyen.Location.Y < 180)
            {
                pic_chuyen.Location = new Point(pic_chuyen.Location.X, pic_chuyen.Location.Y + speed);
            }
            else tgYeuThich.Stop();
        }

        private void tgLichSu_Tick(object sender, EventArgs e)
        {
            if (pic_chuyen.Location.Y > 250)
            {
                pic_chuyen.Location = new Point(pic_chuyen.Location.X, pic_chuyen.Location.Y - speed);
            }
            else if (pic_chuyen.Location.Y < 250)
            {
                pic_chuyen.Location = new Point(pic_chuyen.Location.X, pic_chuyen.Location.Y + speed);
            }
            else tgLichSu.Stop();
        }

        private void tgSetting_Tick(object sender, EventArgs e)
        {
            if (pic_chuyen.Location.Y < 390)
            {
                pic_chuyen.Location = new Point(pic_chuyen.Location.X, pic_chuyen.Location.Y + speed);
            }else tgSetting.Stop();
        }
    }
}
