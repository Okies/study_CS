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
            int a = 100;
            int b = 200;

            int result = Add(a, b);
            Console.WriteLine(result);

            result = Substract(a, b);
            Console.WriteLine(result);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Substract(int a, int b)
        {
            return a - b;
        }
    }
}
