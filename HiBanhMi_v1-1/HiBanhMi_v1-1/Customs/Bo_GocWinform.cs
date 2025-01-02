using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bo_GocWinfrom
{
    internal class Bo_gocWinform : Component
    {
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(int nL, int nT, int nR, int nB, int nWidthEllipse, int nHeightEllipse);

        private Control control;
        private int conrnerRadius = 25;

        public Control TargetControl
        {
            get { return control; }
            set
            {
                control = value;
                control.SizeChanged += (sender, eventArgs) => control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, conrnerRadius, conrnerRadius));
            }
        }

        public int ConrnerRedius
        {
            get { return conrnerRadius; }
            set
            {
                conrnerRadius = value;
                if (control != null)
                {
                    control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, conrnerRadius, conrnerRadius));
                }
            }
        }
    }
}
