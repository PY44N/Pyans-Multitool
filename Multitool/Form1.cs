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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Downloads Needed Files
            Download.Run();
            //Sets console title
            Text = Global.title;
            //Sets theme
            Theme.Run(this);
        }

        private void GithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Goes to our github page
            System.Diagnostics.Process.Start("https://github.com/PY44N/Pyans-Multitool");
        }

        private void Updatelog_Click(object sender, EventArgs e)
        {
            //Opens Updatelog Form
            var Form = new UpdateLog();
            Form.Show();
        }

        private void Base64Encode_Click(object sender, EventArgs e)
        {
            //Opens base64 encode form
            var Form = new Base64Encode();
            Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //opens base64 decode form
            var Form = new Base64Decode();
            Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Opens ip info form
            var Form = new IPInfo();
            Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Opens phone number info form
            var Form = new PhoneNumberInfo();
            Form.Show();
        }

    }
}
