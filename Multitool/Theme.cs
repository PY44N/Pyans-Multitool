using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

//I know my code is garbage, I couldn't really think of a better way to do this, and I am bad at c#
namespace Multitool
{
    class Theme
    {
        //Defines Colors for each element
        public static Color Background;
        public static Color Text;
        public static Color Button;
        public static Color Link;

        private static int LoadInt(StreamReader reader)
        {
            return Convert.ToInt32(Encoding.ASCII.GetString(Convert.FromBase64String(reader.ReadToEnd())));
        }
        //Loads Themes
        public static void Load()
        {
            if (!File.Exists("Theme.BackgroundR.dll"))
            {
                using (StreamWriter writer = new StreamWriter("Theme.BackgroundR.dll"))
                {
                    writer.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes("255")));
                }
            }

            if (!File.Exists("Theme.BackgroundG.dll"))
            {
                using (StreamWriter writer = new StreamWriter("Theme.BackgroundG.dll"))
                {
                    writer.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes("255")));
                }
            }

            if (!File.Exists("Theme.BackgroundB.dll"))
            {
                using (StreamWriter writer = new StreamWriter("Theme.BackgroundB.dll"))
                {
                    writer.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes("255")));
                }
            }

            if (!File.Exists("Theme.TextR.dll"))
            {
                using (StreamWriter writer = new StreamWriter("Theme.TextR.dll"))
                {
                    writer.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes("0")));
                }
            }

            if (!File.Exists("Theme.TextG.dll"))
            {
                using (StreamWriter writer = new StreamWriter("Theme.TextG.dll"))
                {
                    writer.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes("0")));
                }
            }

            if (!File.Exists("Theme.TextB.dll"))
            {
                using (StreamWriter writer = new StreamWriter("Theme.TextB.dll"))
                {
                    writer.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes("0")));
                }
            }

            if (!File.Exists("Theme.ButtonR.dll"))
            {
                using (StreamWriter writer = new StreamWriter("Theme.ButtonR.dll"))
                {
                    writer.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes("255")));
                }
            }

            if (!File.Exists("Theme.ButtonB.dll"))
            {
                using (StreamWriter writer = new StreamWriter("Theme.ButtonB.dll"))
                {
                    writer.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes("255")));
                }
            }

            if (!File.Exists("Theme.ButtonG.dll"))
            {
                using (StreamWriter writer = new StreamWriter("Theme.ButtonG.dll"))
                {
                    writer.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes("255")));
                }
            }

            if (!File.Exists("Theme.LinkR.dll"))
            {
                using (StreamWriter writer = new StreamWriter("Theme.LinkR.dll"))
                {
                    writer.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes("0")));
                }
            }

            if (!File.Exists("Theme.LinkG.dll"))
            {
                using (StreamWriter writer = new StreamWriter("Theme.LinkG.dll"))
                {
                    writer.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes("0")));
                }
            }

            if (!File.Exists("Theme.LinkB.dll"))
            {
                using (StreamWriter writer = new StreamWriter("Theme.LinkB.dll"))
                {
                    writer.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes("255")));
                }
            }

            using (StreamReader streamReaderR = new StreamReader("Theme.BackgroundR.dll", Encoding.UTF8))
            {
                using (StreamReader streamReaderG = new StreamReader("Theme.BackgroundG.dll", Encoding.UTF8))
                {
                    using (StreamReader streamReaderB = new StreamReader("Theme.BackgroundB.dll", Encoding.UTF8))
                    {
                        Background = Color.FromArgb(LoadInt(streamReaderR), LoadInt(streamReaderB), LoadInt(streamReaderG));
                    }
                }
            }

            using (StreamReader streamReaderR = new StreamReader("Theme.TextR.dll", Encoding.UTF8))
            {
                using (StreamReader streamReaderG = new StreamReader("Theme.TextG.dll", Encoding.UTF8))
                {
                    using (StreamReader streamReaderB = new StreamReader("Theme.TextB.dll", Encoding.UTF8))
                    {
                        Text = Color.FromArgb(LoadInt(streamReaderR), LoadInt(streamReaderB), LoadInt(streamReaderG));
                    }
                }
            }

            using (StreamReader streamReaderR = new StreamReader("Theme.ButtonR.dll", Encoding.UTF8))
            {
                using (StreamReader streamReaderG = new StreamReader("Theme.ButtonG.dll", Encoding.UTF8))
                {
                    using (StreamReader streamReaderB = new StreamReader("Theme.ButtonB.dll", Encoding.UTF8))
                    {
                        Button = Color.FromArgb(LoadInt(streamReaderR), LoadInt(streamReaderB), LoadInt(streamReaderG));
                    }
                }
            }

            using (StreamReader streamReaderR = new StreamReader("Theme.LinkR.dll", Encoding.UTF8))
            {
                using (StreamReader streamReaderG = new StreamReader("Theme.LinkR.dll", Encoding.UTF8))
                {
                    using (StreamReader streamReaderB = new StreamReader("Theme.LinkR.dll", Encoding.UTF8))
                    {
                        Link = Color.FromArgb(LoadInt(streamReaderR), LoadInt(streamReaderB), LoadInt(streamReaderG));
                    }
                }
            }
        }

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
