using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study_CS
{
    class Base
    {
        protected string name;

        public Base(string name)
        {
            this.name = name;
        }
    }

    class Derived : Base
    {
        public Derived(string name) : base(name)
        {
            Console.WriteLine(name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived("Name");
        }
    }
}
