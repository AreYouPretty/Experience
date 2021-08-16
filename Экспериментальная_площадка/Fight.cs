﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{
    public class FAndNum
    {
        public bool IsPrime(int x)
        {
            if (x <= 1) 
                return false;

            for (int i = 2; i <= x / i; i++)
            {
                if ((x % i) == 0) 
                    return false;
            }
        }
    }

   /* public class ParDemo
    {
        FAndNum ob = new FAndNum();

        for(int i=2; i<10; i++)
            {
            if(ob.IsPrime(i))
            Console.WriteLine(i + " простое число.");
            else 
            Console.WriteLine(i + " непростое число.");
            }

    }*/
}
