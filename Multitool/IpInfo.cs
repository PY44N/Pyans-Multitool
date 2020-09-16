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
    public partial class IPInfo : Form
    {
        private static string Info;
        private static dynamic Json;

        public IPInfo()
        {
            InitializeComponent();
        }

        private void IPInfo_Load(object sender, EventArgs e)
        {
            Text = Global.title + " | IP Info";
            Theme.Run(this);

            WebClient wc = new WebClient();
            Info = wc.DownloadString("http://ip-api.com/json/");
            wc.Dispose();
            Json = JsonConvert.DeserializeObject(Info);
            IP.Text = Json.query;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            Info = wc.DownloadString("http://ip-api.com/json/" + IP.Text);
            wc.Dispose();
            Json = JsonConvert.DeserializeObject(Info);
            Out.Text = "IP: " + Json.query + "\nCountry: " + Json.country + "\nRegion: " + Json.regionName + "\nCity: " + Json.city + "\nZip: " + Json.zip + "\nTimezone: " + Json.timezone + "\nISP: " + Json.isp;
        }
    }
}
