using System;
using System.Drawing;
using System.Windows.Forms;

namespace testfrom123
{
    public partial class Form1 : Form
    {
        Form activeform;

        public Form1()
        {
            InitializeComponent();

            // Thêm sự kiện MouseMove và MouseLeave cho panel1
            this.panel1.MouseMove += Panel1_MouseMove;
            this.panel1.MouseLeave += Panel1_MouseLeave;
        }

        private void openchildform(Form childform)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = childform;
            childform.TopLevel = false;
            childform.Dock = DockStyle.Fill;
            childform.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(activeform);
            this.panel1.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.them());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openchildform(new Forms.xuat());
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            // Kiểm tra xem chuột có nằm trong vùng Panel không
            if (panel1.ClientRectangle.Contains(e.Location))
            {
                label1.Text = "Chuột đang di chuyển trong Panel!";
            }
        }

        private void Panel1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Chuột đã rời khỏi Panel!";
        }
    }
}
