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
            string s = "Hello";

            char c = s[0];
            Console.WriteLine(c);
            Console.WriteLine(s[1]);
            Console.WriteLine(s[2]);

            string s2 = "World";

            s = s + ", " + s2;
            Console.WriteLine(s);

            string sub = s.Substring(1, 4);
            Console.WriteLine(sub);

            s = "I am a boy";

            string[] words = s.Split(' ');
            foreach (var item in words)
                Console.WriteLine(item);
        }
    }
}
