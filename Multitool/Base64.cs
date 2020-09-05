using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multitool
{
    class Base64
    {
        private static string Choice;
        private static string Text;
        private static string Options = @"╔----------------------------------------╗
|                                        |
|        What would you like to do?      |
|                                        |
|                 (1)Encode              |
|                 (2)Decode              |
|                                        |
╚----------------------------------------╝
";
        public static void Run()
        {
            Console.Title = Global.ConsoleName + " | Base64";
            Console.WriteLine(Options);
            Choice = Console.ReadLine();
            Console.Clear();
            if (Choice == "1")
            {
                Console.Title = Global.ConsoleName + " | Base64 Encoder";
                Console.WriteLine("What would you like to Encode?");
                Text = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(System.Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(Text)));
            } else if (Choice == "2")
            {
                Console.Title = Global.ConsoleName + " | Base64 Decoder";
                Console.WriteLine("What would you like to Decode?");
                Text = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(System.Text.ASCIIEncoding.ASCII.GetString(System.Convert.FromBase64String(Text)));
            } else
            {
                Run();
            }
        }
    }
}
