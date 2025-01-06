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
    public partial class Lsdh : UserControl
    {
        public Lsdh()
        {
            InitializeComponent();

            setcolor();
        }
        
        public string AA_txtmadon
        {
            get { return lb_txtmadon.Text; }
            set {  lb_txtmadon.Text = value;Invalidate();}
        }
        public string AA_madon
        {
            get { return lb_madon.Text; }
            set { lb_madon.Text = value; Invalidate(); }
        }
        public string AA_txtthoigian
        {
            get { return lb_txtthoigian.Text; }
            set { lb_txtthoigian.Text = value; Invalidate(); }
        }
        public string AA_thoigian
        {
            get { return lb_thoigian.Text; }
            set { lb_thoigian.Text = value; Invalidate(); }
        }
        public string AA_txttongtien
        {
            get { return lb_txttong.Text; }
            set { lb_txttong.Text = value; Invalidate(); }
        }
        public string AA_tongtien
        {
            get { return lb_tong.Text; }
            set { lb_tong.Text = value; Invalidate(); }
        }



        private void setcolor()
        {
            lb_txtmadon.ForeColor = Color.Black;
            lb_madon.ForeColor = Color.Black;
            lb_txtthoigian.ForeColor = Color.Black;
            lb_thoigian.ForeColor = Color.Black;
            lb_txttong.ForeColor = Color.Black;
            lb_tong.ForeColor= Color.Black;
            lb_donvi.ForeColor = Color.Black;
        }
    }
}
