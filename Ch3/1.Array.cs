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
            int[] score = new int[] { 70, 80, 88, 90, 75, 72, 82, 85, 95, 72 };

            int sum = 0;
            for (int i = 0; i < score.Length; i++)
                sum += score[i];

            Console.WriteLine(sum);
        }
    }
}
