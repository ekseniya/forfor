using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            double S = 1;
            for (double i = 1; i <= 20; i++)
            {
                double p = 1;
                for (double j = 1; j <= 10; j++)
                {
                    p += Sin(Pow(i, 3) + Pow(j, 4));
                }
                S += p;
            }
            Console.WriteLine(S);
        }
    }
}
}
