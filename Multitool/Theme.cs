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
        public static int BackgroundR;
        public static int BackgroundG;
        public static int BackgroundB;
        public static int TextR;
        public static int TextG;
        public static int TextB;
        public static int ButtonR;
        public static int ButtonG;
        public static int ButtonB;
        public static int LinkR;
        public static int LinkG;
        public static int LinkB;

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

            using (StreamReader reader = new StreamReader("Theme.BackgroundR.dll", Encoding.UTF8))
            {
                BackgroundR = LoadInt(reader);
            }

            using (StreamReader reader = new StreamReader("Theme.BackgroundG.dll", Encoding.UTF8))
            {
                BackgroundG = LoadInt(reader);
            }

            using (StreamReader reader = new StreamReader("Theme.BackgroundB.dll", Encoding.UTF8))
            {
                BackgroundB = LoadInt(reader);
            }

            using (StreamReader reader = new StreamReader("Theme.TextR.dll", Encoding.UTF8))
            {
                TextR = LoadInt(reader);
            }

            using (StreamReader reader = new StreamReader("Theme.TextG.dll", Encoding.UTF8))
            {
                TextG = LoadInt(reader);
            }

            using (StreamReader reader = new StreamReader("Theme.TextB.dll", Encoding.UTF8))
            {
                TextB = LoadInt(reader);
            }

            using (StreamReader reader = new StreamReader("Theme.ButtonR.dll", Encoding.UTF8))
            {
                ButtonR = LoadInt(reader);
            }

            using (StreamReader reader = new StreamReader("Theme.ButtonG.dll", Encoding.UTF8))
            {
                ButtonG = LoadInt(reader);
            }

            using (StreamReader reader = new StreamReader("Theme.ButtonB.dll", Encoding.UTF8))
            {
                ButtonB = LoadInt(reader);
            }

            using (StreamReader reader = new StreamReader("Theme.LinkR.dll", Encoding.UTF8))
            {
                LinkR = LoadInt(reader);
            }

            using (StreamReader reader = new StreamReader("Theme.LinkG.dll", Encoding.UTF8))
            {
                LinkG = LoadInt(reader);
            }

            using (StreamReader reader = new StreamReader("Theme.LinkB.dll", Encoding.UTF8))
            {
                LinkB = LoadInt(reader);
            }

            Background = Color.FromArgb(BackgroundR, BackgroundG, BackgroundB);
            Text = Color.FromArgb(TextR, TextG, TextB);
            Button = Color.FromArgb(ButtonR, ButtonG, ButtonB);
            Link = Color.FromArgb(LinkR, LinkG, LinkB);
        }

        public static void Set(string BackgroundR, string BackgroundG, string BackgroundB, string TextR, string TextG, string TextB, string ButtonR, string ButtonB, string ButtonG, string LinkR, string LinkB, string LinkG)
        {
            using (StreamWriter writer = new StreamWriter("Theme.BackgroundR.dll"))
            {
                writer.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes(BackgroundR)));
            }

            using (StreamWriter writer = new StreamWriter("Theme.BackgroundG.dll"))
            {
                writer.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes(BackgroundG)));
            }

            using (StreamWriter writer = new StreamWriter("Theme.BackgroundB.dll"))
            {
                writer.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes(BackgroundB)));
            }

            using (StreamWriter writer = new StreamWriter("Theme.TextR.dll"))
            {
                writer.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes(TextR)));
            }

            using (StreamWriter writer = new StreamWriter("Theme.TextG.dll"))
            {
                writer.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes(TextG)));
            }

            using (StreamWriter writer = new StreamWriter("Theme.TextB.dll"))
            {
                writer.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes(TextB)));
            }

            using (StreamWriter writer = new StreamWriter("Theme.ButtonR.dll"))
            {
                writer.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes(ButtonR)));
            }

            using (StreamWriter writer = new StreamWriter("Theme.ButtonG.dll"))
            {
                writer.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes(ButtonG)));
            }

            using (StreamWriter writer = new StreamWriter("Theme.ButtonB.dll"))
            {
                writer.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes(ButtonB)));
            }

            using (StreamWriter writer = new StreamWriter("Theme.LinkR.dll"))
            {
                writer.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes(LinkR)));
            }

            using (StreamWriter writer = new StreamWriter("Theme.LinkG.dll"))
            {
                writer.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes(LinkG)));
            }

            using (StreamWriter writer = new StreamWriter("Theme.LinkB.dll"))
            {
                writer.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes(LinkB)));
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
