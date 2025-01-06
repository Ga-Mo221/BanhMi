using HiBanhMi_v1_2.Codes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiBanhMi_v1_2.Forms
{
    public partial class Settingform : Form
    {
        moform mo = new moform();
        Form acctiveform = new Form();
        public Settingform()
        {
            InitializeComponent();
            this.Size = new Size(1080, 720);

            //set color
            setcolor();
            //set ngon ngu
            setngonngu();

            mo.Mo(pn_settingcon, acctiveform, new profile());
        }


        private void xulynhan(int stt)
        {
            switch (stt) {
                case 1:
                    {
                        lb_use.BackColor = ColorTranslator.FromHtml(THEME.t[8]);
                        lb_ngonngu.BackColor = ColorTranslator.FromHtml(THEME.t[9]);
                        lb_theme.BackColor = ColorTranslator.FromHtml(THEME.t[9]);
                        lb_dangxuat.BackColor = ColorTranslator.FromHtml(THEME.t[9]);
                        break;
                    }
                case 2:
                    {
                        lb_use.BackColor = ColorTranslator.FromHtml(THEME.t[9]);
                        lb_ngonngu.BackColor = ColorTranslator.FromHtml(THEME.t[8]);
                        lb_theme.BackColor = ColorTranslator.FromHtml(THEME.t[9]);
                        lb_dangxuat.BackColor = ColorTranslator.FromHtml(THEME.t[9]);
                        break;
                    }
                case 3:
                    {
                        lb_use.BackColor = ColorTranslator.FromHtml(THEME.t[9]);
                        lb_ngonngu.BackColor = ColorTranslator.FromHtml(THEME.t[9]);
                        lb_theme.BackColor = ColorTranslator.FromHtml(THEME.t[8]);
                        lb_dangxuat.BackColor = ColorTranslator.FromHtml(THEME.t[9]);
                        break;
                    }
                case 4:
                    {
                        lb_use.BackColor = ColorTranslator.FromHtml(THEME.t[9]);
                        lb_ngonngu.BackColor = ColorTranslator.FromHtml(THEME.t[9]);
                        lb_theme.BackColor = ColorTranslator.FromHtml(THEME.t[9]);
                        lb_dangxuat.BackColor = ColorTranslator.FromHtml(THEME.t[8]);
                        break;
                    }
            }
        }

        private void lb_use_Click(object sender, EventArgs e)
        {
            xulynhan(1);
            mo.Mo(pn_settingcon, acctiveform, new profile());
        }

        private void lb_ngonngu_Click(object sender, EventArgs e)
        {
            xulynhan(2);
            mo.Mo(pn_settingcon, acctiveform, new ngonngu());
        }

        private void lb_theme_Click(object sender, EventArgs e)
        {
            xulynhan(3);
            mo.Mo(pn_settingcon, acctiveform, new theme());
        }
        private void lb_dangxuat_Click_1(object sender, EventArgs e)
        {
            xulynhan(4);
            DangNhap dn = new DangNhap();

            // Tìm form chitietdonhang đang mở
            var openForm = Application.OpenForms.Cast<Form>().FirstOrDefault(f => f is FormMain) as FormMain;

            if (openForm != null)
            {
                openForm.Hide();
            }
            dn.Show();
        }













        private void setcolor()
        {
            lb_Title.ForeColor = Color.Black;
            lb_use.ForeColor = Color.Black;
            lb_theme.ForeColor = Color.Black;
            lb_ngonngu.ForeColor = Color.Black;
            lb_dangxuat.ForeColor = Color.Black;
            lb_use.BackColor = ColorTranslator.FromHtml(THEME.t[8]);
            lb_ngonngu.BackColor = ColorTranslator.FromHtml(THEME.t[9]);
            lb_theme.BackColor = ColorTranslator.FromHtml(THEME.t[9]);
            lb_dangxuat.BackColor = ColorTranslator.FromHtml (THEME.t[9]);


            this.BackColor = ColorTranslator.FromHtml(THEME.t[0]);
        }

        private void setngonngu()
        {
            lb_Title.Text = NN.nn[27];
            lb_use.Text = NN.nn[38];
            lb_ngonngu.Text = NN.nn[36];
            lb_theme.Text = NN.nn[37];
            lb_dangxuat.Text = NN.nn[81];
        }

    }
}
