using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multitool
{
    class Credits
    {
        public static void Run()
        {
            Console.Title = Global.ConsoleName + " | Credits";
            Console.WriteLine(Global.Credits);
        }
    }
}
