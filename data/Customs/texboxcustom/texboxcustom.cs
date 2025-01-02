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
    public partial class texboxcustom : UserControl
    {
        // Tạo sự kiện Công Khai
        public event EventHandler NoiDungCliked;
        public event EventHandler NoiDungTextChanged;

        public texboxcustom()
        {
            InitializeComponent();

            this.Size = new Size(280, 50);

            body.Size = new Size(280, 50);
            body.Location = new Point(0, 0);

            Title.Size = new Size(54, 19);
            Title.AutoSize = true;
            Title.Location = new Point(7, 1);

            NoiDung.Location = new Point(10, 17);
            NoiDung.Size = new Size(260, 22);

            line.Size = new Size(260, 22);
            line.Location = new Point(10, 45);

            Anline();

            // Gắn sự kiện cho textbox
            NoiDung.Click += NoiDung_Click;
            NoiDung.TextChanged += NoiDung_TextChanged;
        }


        public String TieuDe
        {
            get { return Title.Text; }
            set { Title.Text = value; }
        }

        public String Noidung
        {
            get { return NoiDung.Text; }
            set { NoiDung.Text = value; }
        }

        public int vitricontro()
        {
            return NoiDung.SelectionStart;
        }

        public void Anline() { line.Visible = false; }
        public void Hienline() { line.Visible = true; }

        public Color MauTexBoxtren
        {
            get { return body.GradientBottomColor1; }
            set { body.GradientBottomColor1 = value; }
        }
        public Color MauTexBoxgiua
        {
            get { return NoiDung.BackColor; }
            set { NoiDung.BackColor = value; }
        }
        public Color MauTexBoxduoi
        {
            get { return body.GradientTopColor; }
            set { body.GradientTopColor = value; }
        }

        public bool HienThiMatKau
        {
            get { return NoiDung.UseSystemPasswordChar; }
            set { NoiDung.UseSystemPasswordChar = value; }
        }

        public int Updateposition()
        {
            return NoiDung.SelectionStart;
        }

        private void NoiDung_Click(object sender, EventArgs e)
        {
            Hienline();
            NoiDungCliked.Invoke(this, e);
        }
        private void NoiDung_TextChanged(object sender, EventArgs e)
        {
            NoiDungTextChanged(sender, e);
        }
    }
}
