using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace study_CS
{
    class Person
    {
        public string Name
        {
            get;
            set;
        }
        public DateTime Birthday
        {
            get;
            set;
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person()
            {
                Name = "준창",
                Birthday = new DateTime(1993, 8, 20)
            };
            

            Console.WriteLine("Name : " + p.Name);
            Console.WriteLine("Birthday : " + p.Birthday.ToShortDateString());
            Console.WriteLine("Age : " + p.Age);
        }
    }
}
