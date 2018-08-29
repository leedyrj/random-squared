using System;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            List<int> RndNums = new List<int>();

            byte[] bytes = new byte[5];

            Random rnd = new Random();
            Byte[] b = new Byte[20];
            rnd.NextBytes(b);
            for (int i = 0; i <= b.GetUpperBound(0); i++)
                RndNums.Add(rand.Next(51));

            List<double> SqrRnd = new List<double>();


            foreach (int number in RndNums)
            {
                double randomnum = Math.Pow(number, 2);
                SqrRnd.Add(randomnum);
            }

            SqrRnd.RemoveAll(i => i % 2 != 0);

            foreach (double num in SqrRnd)
            {
                Console.WriteLine($"random numbers squared with odds removed {num}");
            }

        }
    }
}
