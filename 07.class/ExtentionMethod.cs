using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyExtension;

namespace MyExtension
{
    public static partial class IntegerExtention
    {
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }

        public static string Append(this string mystring, string target)
        {
            return mystring + target;
        }
    }
}

namespace study_CS
{
    public static partial class IntegerExtention
    {
        public static int Power(this int myInt, int exponent)
        {
            int result = myInt;
            for (int i = 1; i < exponent; i++)
                result *= myInt;

            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(10.Square());
            Console.WriteLine(10.Power(3));
            Console.WriteLine("Hello".Append(", World"));
        }
    }
}
