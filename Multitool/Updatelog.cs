using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multitool
{
    class Updatelog
    {
        public static void Run()
        {
            Console.Title = Global.ConsoleName + " | Updatelog";
            Console.WriteLine(Global.Updatelog);
        }
    }
}
