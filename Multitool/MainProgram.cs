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
|                 (E)Exit                |
|               (0)Changelog             |
|                (1)IP Info              |
|           (2)Phone Number Info         |
|                 (3)Base64              |
|                                        |
╚----------------------------------------╝
";
        public static void Run()
        {
            Console.Clear();
            Console.Title = Global.ConsoleName;
            Console.WriteLine(Options);
            Choice = Console.ReadLine();
            Console.Clear();
            if (Choice == "e" || Choice == "E")
            {
                System.Environment.Exit(0);
            }
            else if (Choice == "0")
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
            } else if (Choice == "3")
            {
                Base64.Run();
            }
            Console.ReadLine();
            Run();
        }
    }
}
