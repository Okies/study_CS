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
                Console.Write("Score: ");
                string ans = Console.ReadLine();

                if (ans == "")
                    break;

                int score = int.Parse(ans);

                if (score >= 90)
                    Console.WriteLine("Grade A");
                else if (score >= 80)
                    Console.WriteLine("Grade B");
                else if (score >= 70)
                    Console.WriteLine("Grade C");
                else if (score >= 60)
                    Console.WriteLine("Grade D");
                else
                    Console.WriteLine("Grade F");
            }
        }
    }
}
