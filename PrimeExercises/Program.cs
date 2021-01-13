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
            double x = 542;
            Console.WriteLine(Prime(x));
        }

        private static bool Prime(double x)
        {
            if (((x / 2) % 1 == 0) && x != 2 )
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
    }
}
