using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

    // phải sét SelectControlAratn = cái form mình muốn chọn
    public class DiChuyeWindows : Component
    {
        private Control controlerArtan;
        [DllImport("user32.dll")]

        private static extern int SendMessage(IntPtr a, int msg, int wParam, int IParam);
        [DllImport("user32.dll")]

        public static extern bool ReleaseCapture();

        public Control SelectControlAratn
        {
            get { return controlerArtan; }
            set
            {
                controlerArtan = value;
                controlerArtan.MouseDown += ControlerArtan_MouseDown;
            }
        }

        private void ControlerArtan_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(SelectControlAratn.FindForm().Handle, 161, 2, 0);
            }
        }
    }
