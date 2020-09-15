using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Multitool
{
    public partial class PhoneNumberInfo : Form
    {
        private static dynamic Json;
        private static string Info;

        public PhoneNumberInfo()
        {
            InitializeComponent();
        }

        private void PhoneNumberInfo_Load(object sender, EventArgs e)
        {
            Text = Global.title + " | Phone Number Info";
        }

        private void Search_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            Info = wc.DownloadString("https://api.telnyx.com/v1/phone_number/" + PhoneNumber.Text);
            wc.Dispose();
            Json = JsonConvert.DeserializeObject(Info);
            Out.Text = "Country Code: " + Json.country_code + "\nPhone Type: " + Json.carrier.type + "\nCarrier Name: " + Json.carrier.name;
        }
    }
}
