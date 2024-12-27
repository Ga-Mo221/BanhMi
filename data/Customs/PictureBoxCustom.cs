using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomPictureBox
{
    public class PictureBoxCustom : PictureBox
    {
        // Fields
        private int borderSize = 2;
        private int borderRadius = 40;
        private float gradientAngle = 90F;
        private Color borderGradientTop = Color.DodgerBlue;
        private Color borderGradientBottom = Color.CadetBlue;

        // Constructor
        public PictureBoxCustom()
        {
            SizeMode = PictureBoxSizeMode.StretchImage;
            Size = new Size(120, 120);
        }

        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; Invalidate(); }
        }

        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; Invalidate(); }
        }

        public float GradientAngle
        {
            get { return gradientAngle; }
            set { gradientAngle = value; Invalidate(); }
        }

        public Color BorderGradientTop
        {
            get { return borderGradientTop; }
            set { borderGradientTop = value; Invalidate(); }
        }
        public Color BorderGradientBottom
        {
            get { return borderGradientBottom; }
            set { borderGradientBottom = value; Invalidate(); }
        }

        //Overridden Methods
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Size = new Size(Width, Width);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            //Fields
            var graphics = pe.Graphics;
            var rectangleSmooth = Rectangle.Inflate(ClientRectangle, -1, -1);
            var rectangleBorder = Rectangle.Inflate(rectangleSmooth, -borderSize, -borderSize);
            var SmoothSize = borderSize > 0 ? borderSize * 3 : 1;

            using (var BorderGradientColor = new LinearGradientBrush(rectangleBorder, borderGradientTop, borderGradientBottom, gradientAngle)) 
            using (var pathRegion = new GraphicsPath())
            using (var penSooth = new Pen(Parent.BackColor, SmoothSize))
            using (var penBorder = new Pen(BorderGradientColor, SmoothSize))
            {
                pathRegion.AddEllipse(rectangleSmooth);
                Region = new Region(pathRegion);
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.DrawEllipse(penSooth, rectangleBorder);

                if (borderSize > 0)
                    graphics.DrawEllipse(penBorder, rectangleBorder);
            }
            Size = new Size(Width, Height);
        }
    }
}
