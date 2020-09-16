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
            //Sets form title and sets theme
            Text = Global.title + " | Base64 Decode";
            Theme.Run(this);
        }

        private void Decode_Click(object sender, EventArgs e)
        {
            //Decodes Base64 and Sets output text to decoded base64
            Out.Text = Encoding.ASCII.GetString(Convert.FromBase64String(ToDecode.Text));
        }
    }
}
