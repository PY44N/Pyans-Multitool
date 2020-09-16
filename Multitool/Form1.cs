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
            Download.Run();
            Text = Global.title;
            Theme.Run(this);
        }

        private void GithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/PY44N/Pyans-Multitool");
        }

        private void Updatelog_Click(object sender, EventArgs e)
        {
            var Form = new UpdateLog();
            Form.Show();
        }

        private void Base64Encode_Click(object sender, EventArgs e)
        {
            var Form = new Base64Encode();
            Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Form = new Base64Decode();
            Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Form = new IPInfo();
            Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Form = new PhoneNumberInfo();
            Form.Show();
        }

    }
}
