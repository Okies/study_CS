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
            study_CS.Program.Display("Hi");
            Display("Hiii");

            int result = study_CS.MyMath.Sum(1, 2);
            study_CS.Program.Display(result);

            result = MyMath.Sum(1, 2);
            Display(result);
        }

        static void Display(object msg)
        {
            Console.WriteLine(msg);
        }
    }

    class MyMath
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
