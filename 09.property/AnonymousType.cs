using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace study_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new { Name = "준창", Age = 26 };
            Console.WriteLine("{0} {1}", a.Name, a.Age);

            var b = new { Subject = "수학", Scores = new int[] { 90, 80, 70, 60 } };
            Console.Write(b.Subject + " : ");
            foreach (var score in b.Scores)
                Console.Write(score + " ");
            Console.WriteLine();
        }
    }
}
