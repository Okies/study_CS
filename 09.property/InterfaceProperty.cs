using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace study_CS
{
    interface INamedValue
    {
        string Name
        { get; set; }
        string Value
        { get; set; }
    }
    class NamedValue : INamedValue
    {
        public string Name
        { get; set; }
        public string Value
        { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NamedValue name = new NamedValue()
            { Name = "이름", Value = "준창" };

            NamedValue height = new NamedValue()
            { Name = "키", Value = "174cm" };

            NamedValue weight = new NamedValue()
            { Name = "몸무게", Value = "67Kg" };

            Console.WriteLine(name.Name + " : " + name.Value);
            Console.WriteLine(height.Name + " : " + height.Value);
            Console.WriteLine(weight.Name + " : " + weight.Value);
        }
    }
}
