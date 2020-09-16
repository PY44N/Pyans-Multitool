using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multitool
{
    class Theme
    {
        //Defines Colors for each element
        public static Color Background = Color.FromArgb(255, 255, 255);
        public static Color Text = Color.FromArgb(0, 0, 0);
        public static Color Button = Color.FromArgb(255, 255, 255);
        public static Color Link = Color.FromArgb(0, 0, 255);

        public static void Run(Form form)
        {
            //Sets form background color
            form.BackColor = Background;

            //Sets each button color
            foreach (var button in form.Controls.OfType<Button>())
            {
                button.BackColor = Button;
                button.ForeColor = Text;
                button.FlatStyle = FlatStyle.Popup;
            }

            //Sets each label color
            foreach (var label in form.Controls.OfType<Label>())
            {
                label.ForeColor = Text;
            }

            //Sets each link color
            foreach (var link in form.Controls.OfType<LinkLabel>())
            {
                link.LinkColor = Link;
            }
        }
    }
}
