using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Multitool
{
    class Download
    {
        public static void Run()
        {
            WebClient wc = new WebClient();
            wc.DownloadFile("https://github.com/PY44N/FileDownloads/raw/master/Newtonsoft.Json.dll", "Newtonsoft.Json.dll");
        }
    }
}
