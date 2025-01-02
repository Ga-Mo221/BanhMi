using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboobox.cust_combobox
{
    public partial class CusTomCOMBOBOX : UserControl
    {
        public event EventHandler BTOptionClicked;

        public string[] data;
        int height;
        int width;
        public CusTomCOMBOBOX()
        {
            InitializeComponent();
            height = 300;
            width = 200;
            line.Visible = false;
        }
        
        public void Hienline()
        {
            line.Visible = true;
        }
        public void Anline()
        {
            line.Visible = false;
        }
        public int CHIEUDAICUATITEM
        {
            get => width;
            set { width = value; Invalidate(); }
        }
        public int CHIEUDAILIST
        {
            get => height;
            set { height = value; Invalidate(); }
        }
        public string ITEM
        {
            get { return lb_luachon.Text; }
            set { lb_luachon.Text = value; Invalidate(); }
        }
        public string TIEUDE
        {
            get { return lb_Title.Text; }
            set { lb_Title.Text = value; Invalidate(); }
        }
        public Image ICON
        {
            get { return pic_icon.Image; }
            set { pic_icon.Image = value; Invalidate(); }
        }
        public Image OPTION
        {
            get { return pic_option.Image; }
            set { pic_option.Image = value; Invalidate(); }
        }
        public string[] DATAITEM
        {
            get => data;
            set
            {
                foreach (var item in value)
                {
                    Label label = new Label();
                    label.Text = item;
                    label.ForeColor = Color.White;
                    label.TextAlign = ContentAlignment.MiddleLeft;
                    label.Height = 25;
                    label.Width = width-25;

                    label.MouseClick += new MouseEventHandler(ITEM_dachon);
                    FLPItem.Controls.Add(label);
                }
                data = value; Invalidate();
            }
        }

        private void ITEM_dachon(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            foreach (var item in FLPItem.Controls.OfType<Label>())
            {
                item.BackColor = Color.FromArgb(192, 192, 192);
            }
            label.BackColor = Color.FromArgb(46, 239, 221);
            lb_luachon.Text = label.Text;

            tglen.Start();
        }

        private void tgxuong_Tick(object sender, EventArgs e)
        {
            if (Height < height) Height += 5;
            else tgxuong.Stop();
        }

        private void tglen_Tick(object sender, EventArgs e)
        {
            if (Height > 50) Height -= 5;
            else tglen.Stop();
        }

        private void pic_option_Click(object sender, EventArgs e)
        {
            Hienline();
            if (Height < 60)
                tgxuong.Start();
            else tglen.Start();
            BTOptionClicked(sender, e);
        }
    }
}
