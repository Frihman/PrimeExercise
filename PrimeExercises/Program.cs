using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Prime(n);
        }

        private static bool isPrime(double x)
        {
            if (x == 1)
            {
                return false;
            }

            if (((x / 2) % 1 == 0) && x != 2)
            {
                return false;
            }

            double root = Math.Sqrt(x);
            int interval = Convert.ToInt32(Math.Floor(root));

            for (int i = 3; i <= interval; i++)
            {
                if ((x / i) % 1 == 0)
                {
                    return false;
                }
            }
            
            return true;
        }

        static void Prime(int n)
        {
            int i = 1;
            int index = 0;

            do
            {
                if (isPrime(i))
                {
                    Console.WriteLine(i);
                    index += 1;
                }

                i += 1;
            } while (index < n);
        }
    }
}
