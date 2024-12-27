using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiBanhMi
{
    internal class TaiForm
    {
        public TaiForm() { }

        public void openchildform(Panel panel ,Form activeform , Form childform)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = childform;
            childform.TopLevel = false;
            childform.Dock = DockStyle.Fill;
            childform.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(activeform);
            panel.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
    }
}
