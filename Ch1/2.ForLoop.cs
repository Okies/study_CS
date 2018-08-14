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
            int sum = 0;
            for (int i = 0; i <= 100; i++)
                sum += i;

            Console.WriteLine("Sum from 0 to 100 : {0}", sum);
        }
    }
}
