using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomVongPhanTram
{
    public class BieuDoTron : UserControl
    {
        //Fields
        float valueSize = 40;
        int borderSize = 15;
        Color middleCircleColor = Color.DarkBlue;
        Color outerCircleColor = Color.Transparent;

        //Constructor
        public BieuDoTron()
        {
            DoubleBuffered = true;
        }

        //Properties  
        public float ValueSize
        {
            get { return valueSize; }
            set { valueSize = (value > 100) ? 100 : value; Invalidate(); }
        }
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = (value > 20) ? 20 : value; Invalidate(); }
        }

        public Color MiddleCircleColor
        {
            get { return middleCircleColor; }
            set { middleCircleColor = ForeColor = value; Invalidate(); }
        }

        public Color OuterCircleColor
        {
            get { return outerCircleColor; }
            set { outerCircleColor = value; Invalidate(); }
        }

        // Methoth
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Pen Backpen = new Pen(Color.White, BorderSize - 1);
            Pen pen = new Pen(middleCircleColor, BorderSize) { StartCap = LineCap.Round, EndCap = LineCap.Round };
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            graphics.FillPie(new SolidBrush(outerCircleColor), new Rectangle(10, 10, Width - 20, Height - 20), 0, 360);
            graphics.DrawArc(Backpen, new Rectangle(10, 10, Width - 20, Height - 20), -90, 360);
            graphics.DrawArc(pen, new Rectangle(10, 10, Width - 20, Height - 20), -90, (ValueSize / 100) * 360);

            StringFormat stringFormat = new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center };
            graphics.DrawString(ValueSize + "%", Font, new SolidBrush(ForeColor), ClientRectangle, stringFormat);
            base.OnPaint(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            Height = Width;
            base.OnSizeChanged(e);
        }
    }
}
