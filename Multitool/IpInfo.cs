using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using Newtonsoft.Json;

namespace Multitool
{
    class IpInfo
    {
        private static string Info;
        private static dynamic Json;
        private static string IP;
        private static string Choice;
        private static string Options = @"╔----------------------------------------╗
|                                        |
|     Which IP do you want to use?       |
|                                        |
|                 (1)Yours               |
|                 (2)Other               |
|                                        |
╚----------------------------------------╝
";
        public static void Run()
        {
            Console.Title = Global.ConsoleName + " | IP Info";
            Console.WriteLine(Options);
            Choice = Console.ReadLine();
            Console.Clear();

            WebClient wc = new WebClient();
            if (Choice == "1")
            {
                Info = wc.DownloadString("http://ip-api.com/json/");
            } else if (Choice == "2")
            {
                Console.WriteLine("What IP do you want to get info for?");
                IP = Console.ReadLine();
                Info = wc.DownloadString("http://ip-api.com/json/" + IP);
                Console.Clear();
            }
            Json = JsonConvert.DeserializeObject(Info);

            Console.WriteLine("IP: " + Json.query);
            Console.WriteLine("Country: " + Json.country);
            Console.WriteLine("Region: " + Json.regionName);
            Console.WriteLine("City: " + Json.city);
            Console.WriteLine("Zip: " + Json.zip);
            Console.WriteLine("Timezone: " + Json.timezone);
            Console.WriteLine("ISP: " + Json.isp);
        }
    }
}
