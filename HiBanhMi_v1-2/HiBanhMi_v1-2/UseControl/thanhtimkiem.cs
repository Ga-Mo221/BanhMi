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
    public partial class thanhtimkiem : UserControl
    {
        public event EventHandler textchanged;
        public thanhtimkiem()
        {
            InitializeComponent();
        }

        public Color AA_mau
        {
            get { return textBox1.BackColor; }
            set { textBox1.BackColor = value; Invalidate(); }
        }
        public string AA_content
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; Invalidate(); }
        }

        private void pictureBoxCustom1_Click(object sender, EventArgs e)
        {
            if (Width < 61)
            {
                tgphai.Start();
            }
            else if (Width > 569)
            {
                tgtrai.Start();
            }
        }

        private void tgtrai_Tick(object sender, EventArgs e)
        {
            Width -= 30;
            if (Width < 61) tgtrai.Stop();
        }

        private void tgphai_Tick(object sender, EventArgs e)
        {
            Width += 30;
            if (Width > 569) tgphai.Stop();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textchanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
