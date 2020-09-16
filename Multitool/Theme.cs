using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multitool
{
    class Theme
    {
        public static Color Background = Color.FromArgb(255, 255, 255);
        public static Color Text = Color.FromArgb(0, 0, 0);
        public static Color Button = Color.FromArgb(255, 255, 255);
        public static Color Link = Color.FromArgb(0, 0, 255);

        public static void Run(Form form)
        {
            form.BackColor = Background;

            foreach (var button in form.Controls.OfType<Button>())
            {
                button.BackColor = Button;
                button.ForeColor = Text;
                button.FlatStyle = FlatStyle.Popup;
            }

            foreach (var label in form.Controls.OfType<Label>())
            {
                label.ForeColor = Text;
            }

            foreach (var link in form.Controls.OfType<LinkLabel>())
            {
                link.LinkColor = Link;
            }
        }
    }
}
