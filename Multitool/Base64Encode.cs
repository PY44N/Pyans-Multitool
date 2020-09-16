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
    public partial class Base64Encode : Form
    {
        public Base64Encode()
        {
            InitializeComponent();
        }

        private void Base64Encode_Load(object sender, EventArgs e)
        {
            //Sets Form Tite
            Text = Global.title + " | Base64 Encode";
            //Sets Themes
            Theme.Run(this);
        }

        private void Encode_Click(object sender, EventArgs e)
        {
            //Sets Output text to Encoded base64
            Out.Text = Convert.ToBase64String(Encoding.ASCII.GetBytes(ToEncode.Text));
        }
    }
}
