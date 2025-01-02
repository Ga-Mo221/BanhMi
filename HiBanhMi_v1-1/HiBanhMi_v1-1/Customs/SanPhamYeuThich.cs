using System.Drawing;
using System.Windows.Forms;

namespace luotdanhgiasanpham.chinh
{
    public partial class SanPhamYeuThich : UserControl
    {
        public SanPhamYeuThich()
        {
            InitializeComponent();
        }

        public Color BACKGROUND
        {
            get { return pn_background.BackColor; }
            set { pn_background.BackColor = value; Invalidate(); }
        }
        public Image ANHSANPHAM
        {
            get { return pn_anhsp.BackgroundImage; }
            set { pn_anhsp.BackgroundImage = value; Invalidate(); }
        }
        public Image TIMHONG
        {
            get { return pic_timhong.Image; }
            set { pic_timhong.Image = value; Invalidate(); }
        }
        public string TENSANPHAM
        {
            get { return lb_tensp.Text; }
            set { lb_tensp.Text = value; Invalidate(); }
        }
        public string LUOTTHICH
        {
            get { return lb_luotthich.Text; }
            set { lb_luotthich.Text = value; Invalidate(); }
        }
    }
}
