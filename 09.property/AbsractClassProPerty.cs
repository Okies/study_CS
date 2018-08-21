using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace study_CS
{
    abstract class Product
    {
        private static int serial = 0;
        public string SerialID
        { get { return string.Format("{0:d5}", serial++); } }
        abstract public DateTime ProductDate
        { get; set; }
    }
    class MyProduct : Product
    {
        public override DateTime ProductDate
        { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyProduct p1 = new MyProduct()
            { ProductDate = new DateTime(2018, 8, 20) };
            Console.WriteLine(p1.SerialID + ", " + p1.ProductDate);

            MyProduct p2 = new MyProduct()
            { ProductDate = new DateTime(2018, 8, 21) };
            Console.WriteLine(p2.SerialID + ", " + p2.ProductDate);
        }
    }
}
