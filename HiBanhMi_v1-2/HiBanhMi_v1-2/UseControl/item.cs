using System;
using System.Drawing;
using System.Windows.Forms;

namespace HiBanhMi_v1_2.UseControl
{
    public partial class item : UserControl
    {
        public event EventHandler muaclick;
        public event EventHandler thich;
        public item()
        {
            InitializeComponent();
            lb_ten.ForeColor = Color.Black;
            lb_daban.ForeColor = Color.Black;
            lb_danhgia.ForeColor = Color.Black;
            lb_giamgia.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            lb_giaban.ForeColor = Color.Black;

            lb_txtdanhgia.ForeColor = Color.Black;
            lb_txtdaban.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            bt_them.BackgroundImage = Properties.Resources.add;
            pictureBox2.Image = Properties.Resources.danhgiavang;
            pic_tim.Image = Properties.Resources.likeden;
            fpn.Visible = false;
        }

        public string AA_txtdanhgia
        {
            get { return lb_txtdanhgia.Text; }
            set { lb_txtdanhgia.Text = value; Invalidate(); }
        }
        public string AA_txtdaban
        {
            get { return lb_txtdaban.Text; }
            set { lb_txtdaban.Text = value; Invalidate(); }
        }
        public bool AA_hienthitim
        {
            get { return pic_tim.Visible; }
            set { pic_tim.Visible = value; Invalidate(); }
        }
        public Image AA_anhtim
        {
            get { return pic_tim.Image; }
            set { pic_tim.Image = value; Invalidate(); }
        }
        public bool AA_sudungnutthem
        {
            get { return bt_them.Enabled; }
            set { bt_them.Enabled = value; Invalidate(); }
        }
        public string AA_giamgia
        {
            get { return lb_giamgia.Text; }
            set { lb_giamgia.Text = value; Invalidate(); }
        }
        public string AA_Gia
        {
            get { return lb_giaban.Text; }
            set { lb_giaban.Text = value; Invalidate(); }
        }
        public string AA_tensp
        {
            get { return lb_ten.Text; }
            set { lb_ten.Text = value; Invalidate(); }
        }
        public string AA_danhgia
        {
            get { return lb_danhgia.Text; }
            set { lb_danhgia.Text = value; Invalidate(); }
        }
        public string AA_daban
        {
            get { return lb_daban.Text; }
            set { lb_daban.Text = value; Invalidate(); }
        }
        public string AA_masp
        {
            get { return lb_masp.Text; }
            set { lb_masp.Text = value; Invalidate(); }
        }

        public bool AA_banggiamgia
        {
            get { return fpn.Visible; }
            set { fpn.Visible = value; Invalidate(); }
        }
        public bool AA_nutmua
        {
            get { return bt_them.Visible; }
            set { bt_them.Visible = value; Invalidate(); }
        }

        public Color AA_bg
        {
            get { return pn_bg.BackColor; }
            set { pn_bg.BackColor = value; Invalidate(); }
        }
        public Color AA_maunutthem
        {
            get { return bt_them.BackColor; }
            set { bt_them.BackColor = value; Invalidate(); }
        }
        public Image AA_anhnutthem
        {
            get { return bt_them.BackgroundImage; }
            set { bt_them.BackgroundImage = value; Invalidate(); }
        }
        public Image AA_anhsp
        {
            get { return pic_avata.Image; }
            set { pic_avata.Image = value; Invalidate(); }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            bt_them.BackColor = Color.Gray;
            bt_them.BackgroundImage = Properties.Resources.tick;
            muaclick?.Invoke(this, EventArgs.Empty);
        }
        private int check = 0;
        public int AA_thich
        {
            get => check; set => check = value;
        }
        private void pic_tim_Click(object sender, EventArgs e)
        {
            if (check == 0)
            {
                pic_tim.Image = Properties.Resources.likedo;
                check++;
            }else
            {
                pic_tim.Image= Properties.Resources.likeden;
                check--;
            }
            thich?.Invoke(this, EventArgs.Empty);
        }
    }
}
