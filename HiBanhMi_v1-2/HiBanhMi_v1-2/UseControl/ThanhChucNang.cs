using HiBanhMi_v1_2.Codes;
using HiBanhMi_v1_2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiBanhMi_v1_2.UseControl
{
    public partial class ThanhChucNang : UserControl
    {
        // tao su kien click
        public event EventHandler Homeclick;
        public event EventHandler ThucDonclick;
        public event EventHandler YeuThichclick;
        public event EventHandler LichSuclick;
        public event EventHandler Settingclick;




        public ThanhChucNang()
        {
            InitializeComponent();
            lb_ten.ForeColor = Color.Black;             
        }

        public Color AA_backgroundcolor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; Invalidate(); }
        }
        public Image AA_anhdaidien
        {
            get { return pn_avata.BackgroundImage; }
            set { pn_avata.BackgroundImage = value; Invalidate(); }
        }
        public string AA_ten
        {
            get { return lb_ten.Text; }
            set {  lb_ten.Text = value; Invalidate(); }
        }



        // button home
        public Image AA_1homeimg
        {
            get { return pictureBox1.BackgroundImage; }
            set { pictureBox1.BackgroundImage = value; Invalidate(); }
        }
        public Color AA_1homebg
        {
            get { return bt_home.BackColor; }
            set { bt_home.BackColor = value; Invalidate(); }
        }
        public Color AA_1homeicon
        {
            get { return pn_home.BackColor; }
            set { pn_home.BackColor = value; Invalidate(); }
        }
        public Color AA_1homeTitle
        {
            get { return lb_home.ForeColor; }
            set { lb_home.ForeColor = value; Invalidate(); }
        }
        public string AA_1hometext
        {
            get { return lb_home.Text; }
            set { lb_home.Text = value; Invalidate(); }
        }
        // button thucdon
        public Image AA_2thucdonimg
        {
            get { return pictureBox2.BackgroundImage; }
            set { pictureBox2.BackgroundImage = value; Invalidate(); }
        }
        public Color AA_2thucdonbg
        {
            get { return bt_thucdon.BackColor; }
            set { bt_thucdon.BackColor = value; Invalidate(); }
        }
        public Color AA_2thucdonicon
        {
            get { return pn_thucdon.BackColor; }
            set { pn_thucdon.BackColor = value; Invalidate(); }
        }
        public Color AA_2thucdonTitle
        {
            get { return lb_thucdon.ForeColor; }
            set { lb_thucdon.ForeColor = value; Invalidate(); }
        }
        public string AA_2thucdontext
        {
            get { return lb_thucdon.Text; }
            set { lb_thucdon.Text = value; Invalidate(); }
        }
        // button yeuthich
        public Image AA_3yeuthichimg
        {
            get { return pictureBox3.BackgroundImage; }
            set { pictureBox3.BackgroundImage = value; Invalidate(); }
        }
        public Color AA_3yeuthichbg
        {
            get { return bt_yeuthich.BackColor; }
            set { bt_yeuthich.BackColor = value; Invalidate(); }
        }
        public Color AA_3yeuthichicon
        {
            get { return pn_yeuthich.BackColor; }
            set { pn_yeuthich.BackColor = value; Invalidate(); }
        }
        public Color AA_3yeuthichTitle
        {
            get { return lb_yeuthich.ForeColor; }
            set { lb_yeuthich.ForeColor = value; Invalidate(); }
        }
        public string AA_3yeuthichtext
        {
            get { return lb_yeuthich.Text; }
            set { lb_yeuthich.Text = value; Invalidate(); }
        }
        // button lichsu
        public Image AA_4lichsuimg
        {
            get { return pictureBox4.BackgroundImage; }
            set { pictureBox4.BackgroundImage = value; Invalidate(); }
        }
        public Color AA_4lichsubg
        {
            get { return bt_lichsu.BackColor; }
            set { bt_lichsu.BackColor = value; Invalidate(); }
        }
        public Color AA_4lichsuicon
        {
            get { return pn_lichsu.BackColor; }
            set { pn_lichsu.BackColor = value; Invalidate(); }
        }
        public Color AA_4lichsuTitle
        {
            get { return lb_lichsu.ForeColor; }
            set { lb_lichsu.ForeColor = value; Invalidate(); }
        }
        public string AA_4lichsutext
        {
            get { return lb_lichsu.Text; }
            set { lb_lichsu.Text = value; Invalidate(); }
        }
        // button setting
        public Image AA_5settingimg
        {
            get { return pictureBox5.BackgroundImage; }
            set { pictureBox5.BackgroundImage = value; Invalidate(); }
        }
        public Color AA_5settingbg
        {
            get { return bt_setting.BackColor; }
            set { bt_setting.BackColor = value; Invalidate(); }
        }
        public Color AA_5settingicon
        {
            get { return pn_setting.BackColor; }
            set { pn_setting.BackColor = value; Invalidate(); }
        }
        public Color AA_5settingTitle
        {
            get { return lb_setting.ForeColor; }
            set { lb_setting.ForeColor = value; Invalidate(); }
        }
        public string AA_5settingtext
        {
            get { return lb_setting.Text; }
            set { lb_setting.Text = value; Invalidate(); }
        }





        // Phương thức công khai để kích hoạt sự kiện lb_thucdon_Click
        public void TriggerThucDonClick()
        {
            lb_thucdon_Click(this, EventArgs.Empty); // Gọi sự kiện click của lb_thucdon
        }
        private void lb_home_Click(object sender, EventArgs e)
        {
            Homeclick?.Invoke(this, EventArgs.Empty);
        }

        private void lb_thucdon_Click(object sender, EventArgs e)
        {
            ThucDonclick?.Invoke(this, EventArgs.Empty);
        }

        private void lb_yeuthich_Click(object sender, EventArgs e)
        {
            YeuThichclick?.Invoke(this, EventArgs.Empty);
        }

        private void lb_lichsu_Click(object sender, EventArgs e)
        {
            LichSuclick?.Invoke(this, EventArgs.Empty);
        }

        private void lb_setting_Click(object sender, EventArgs e)
        {
            Settingclick?.Invoke(this, EventArgs.Empty);
        }
    }
}
