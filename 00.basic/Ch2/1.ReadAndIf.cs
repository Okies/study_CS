using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            for (;;)
            {
                Console.WriteLine("\n========== Menu ==========\n");
                Console.WriteLine("1. One");
                Console.WriteLine("2. Two");
                Console.WriteLine("3. Three");
                Console.WriteLine("4. Four");
                Console.WriteLine("\nQ to Quit");

                string ans = Console.ReadLine();

                Console.WriteLine();

                if (ans == "q" || ans == "Q")
                    break;

                if (ans == "1")
                    Console.WriteLine("111");
                else if (ans == "2")
                    Console.WriteLine("222");
                else if (ans == "3")
                    Console.WriteLine("333");
                else if (ans == "4")
                    Console.WriteLine("444");
                else
                    Console.WriteLine("Invalid Input");
            }
        }
    }
}
