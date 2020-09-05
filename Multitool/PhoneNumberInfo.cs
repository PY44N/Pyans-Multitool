using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Multitool
{
    class PhoneNumberInfo
    {
        private static string Number;
        private static string Info;
        private static dynamic Json;
        public static void Run()
        {
            Console.Title = Global.ConsoleName + " | Phone Number Info";
            Console.WriteLine("What is your phone number (Please include country code and area code)?");
            Number = Console.ReadLine();
            Console.Clear();
            WebClient wc = new WebClient();
            Info = wc.DownloadString("https://api.telnyx.com/v1/phone_number/" + Number);
            Json = JsonConvert.DeserializeObject(Info);
            Console.WriteLine("Country Code: " + Json.country_code);
            Console.WriteLine("Phone Type: " + Json.carrier.type);
            Console.WriteLine("Carrier Name: " + Json.carrier.name);
        }
    }
}
