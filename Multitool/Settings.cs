using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multitool
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Text = Global.title + " | Settings";
            Theme.Run(this);

            BackR.Text = Theme.BackgroundR.ToString();
            BackG.Text = Theme.BackgroundG.ToString();
            BackB.Text = Theme.BackgroundB.ToString();

            TextR.Text = Theme.TextR.ToString();
            TextG.Text = Theme.TextG.ToString();
            TextB.Text = Theme.TextB.ToString();

            ButtonR.Text = Theme.ButtonR.ToString();
            ButtonG.Text = Theme.ButtonG.ToString();
            ButtonB.Text = Theme.ButtonB.ToString();

            LinkR.Text = Theme.LinkR.ToString();
            LinkG.Text = Theme.LinkG.ToString();
            LinkB.Text = Theme.LinkB.ToString();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Theme.Set(BackR.Text, BackG.Text, BackB.Text, TextR.Text, TextG.Text, TextB.Text, ButtonR.Text, ButtonB.Text, ButtonG.Text, LinkR.Text, LinkB.Text, LinkG.Text);
        }
    }
}
