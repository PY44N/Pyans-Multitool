using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multitool
{
    class MainProgram
    {
        private static string Choice;
        private static string Options = @"╔----------------------------------------╗
|                                        |
|             Pyan's Mutlitool           |
|                                        |
|               (0)Changelog             |
|                (1)IP Info              |
|           (2)Phone Number Info         |
|                                        |
╚----------------------------------------╝
";
        public static void Run()
        {
            Console.Title = Global.ConsoleName;
            Console.WriteLine(Options);
            Choice = Console.ReadLine();
            Console.Clear();
            if (Choice == "0")
            {
                Changelog.Run();
            }
            else if (Choice == "1")
            {
                IpInfo.Run();
            }
            else if (Choice == "2")
            {
                PhoneNumberInfo.Run();
            }
            Console.ReadLine();
        }
    }
}
