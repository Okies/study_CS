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
        private string name;
        private DateTime birthday;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "준창";
            p.Birthday = new DateTime(1993, 8, 20);

            Console.WriteLine("Name : " + p.Name);
            Console.WriteLine("Birthday : " + p.Birthday.ToShortDateString());
            Console.WriteLine("Age : " + p.Age);
        }
    }
}
