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
    public partial class TextBox_DangNhap : UserControl
    {
        public TextBox_DangNhap()
        {
            InitializeComponent();
        }

        public string AA_Title
        {
            get { return label1.Text; }
            set { label1.Text = value; Invalidate(); }
        }
        public string AA_Content
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; Invalidate(); }
        }
        public Color AA_BackgroundColor
        {
            get { return panelCustom1.BackColor; }
            set { panelCustom1.BackColor = value; Invalidate(); }
        }
        public Color AA_BorderColor
        {
            get { return textBox1.BackColor; }
            set { textBox1.BackColor = value; Invalidate(); }
        }

        public bool AA_pass
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; Invalidate(); }
        }
    }
}
