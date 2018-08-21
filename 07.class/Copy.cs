using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study_CS
{
    class MyClass
    {
        public int a;
        public int b;

        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass();
            newCopy.a = this.a;
            newCopy.b = this.b;

            return newCopy;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //얕은 복사
            {
                MyClass source = new MyClass();
                source.a = 10;
                source.b = 20;

                MyClass target = source;
                target.b = 30;

                Console.WriteLine("{0} {1}", source.b, target.b);
            }

            //깊은 복사
            {
                MyClass source = new MyClass();
                source.a = 10;
                source.b = 20;

                MyClass target = source.DeepCopy();
                target.b = 30;

                Console.WriteLine("{0} {1}", source.b, target.b);
            }
        }
    }
}
