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
    public partial class chonthucdon : UserControl
    {
        public event EventHandler ChonthucdonClick;
        public string colobg;
        public chonthucdon()
        {
            InitializeComponent();
            label1.ForeColor = Color.Black;
            colobg = "#ec6083";
        }

        public Image AA_anh
        {
            get => pictureBox1.Image;
            set { pictureBox1.Image = value; Invalidate(); }
        }
        public string AA_maukhinhan
        {
            get => colobg;
            set => colobg = value;
        }
        public string AA_Title
        {
            get => label1.Text;
            set { label1.Text = value; Invalidate(); }
        }

        private void nhan()
        {
            this.BackColor = ColorTranslator.FromHtml(colobg);
        }

        public void quaylai(string maubandau)
        {
            this.BackColor = ColorTranslator.FromHtml(maubandau);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            nhan();
            ChonthucdonClick.Invoke(this, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            nhan();
            ChonthucdonClick.Invoke(this, e);
        }
    }
}
