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
            int[] data = new int[] { 14, 24, 34, 52, 6, 13, 54, 100 };

            Console.WriteLine("Sum = {0}, Avg = {1}", Sum(data), Avg(data));
        }

        static int Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            return sum;
        }

        static double Avg(int[] arr)
        {
            return Sum(arr) / (double)arr.Length;
        }
    }
}
