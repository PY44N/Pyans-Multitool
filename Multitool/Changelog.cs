using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multitool
{
    class Changelog
    {
        public static void Run()
        {
            Console.Title = Global.ConsoleName + " | Changelog";
            Console.WriteLine(Global.Changelog);
        }
    }
}
