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
    public partial class Base64Decode : Form
    {
        public Base64Decode()
        {
            InitializeComponent();
        }

        private void Base64Decode_Load(object sender, EventArgs e)
        {
            Text = Global.title + " | Base64 Decode";
            Theme.Run(this);
        }

        private void Decode_Click(object sender, EventArgs e)
        {
            Out.Text = Encoding.ASCII.GetString(Convert.FromBase64String(ToDecode.Text));
        }
    }
}
