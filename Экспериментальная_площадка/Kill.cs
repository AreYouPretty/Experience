using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kill_my_trouble
{
    public class Kill
    {
        public static bool IsPrime(int x)
        {
            if (x <= 1)
            {
                return false;
            }

                for (int i = 2; i <= x / i; i++)
                {
                    if ((x % i) == 0)
                        return false;
                }   
            
            return true;
        }


        public int LeastComFactor(int a, int b)
        {
            int max;

            if (IsPrime(a) || IsPrime(b))
            {
                return 1;
            }

            max = a < b ? a : b;

            for (int i = 2; i <= max / 2; i++)
            {
                if (((a % i) == 0) && ((b % i) == 0))
                    return i;
            }

            return 1;

        }
    }
    
    public class ParmDemo
    {
        public static Kill ob = new Kill();
        public static int a, b;

       public static void More()
        {
            for (int i = 2; i < 10; i++)
            {
                if (Kill.IsPrime(i))
                {
                    Console.WriteLine(i + " простое число.");
                }
                else
                    Console.WriteLine(i + " непростое число.");

            }
            
            a = 7;
            b = 8;
            
            Console.WriteLine("Наименьший общий множитель чисел " + a + " и " + b + " равен " + ob.LeastComFactor(a, b));
            
            a = 100;
            b = 8;
            
            Console.WriteLine("Наименьший общий множитель чисел " + a + " и " + b + " равен " + ob.LeastComFactor(a, b));
                
            a = 100;
            b = 75;

            Console.WriteLine("Наименьший общий множитель чисел " + a + " и " + b + " равен " + ob.LeastComFactor(a, b));
        }
    }
}


