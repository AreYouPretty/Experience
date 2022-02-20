using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ument221
{
    class Arg220
    {
        public class Test
        {
            public void NoChange(int i, int j)
            {
                i = i + j;
                j = -j;
            }
        }

        
        public class CallByValue
        {
            public static void Om()
            {
                Test ob = new Test();
                int a = 15, b = 20;

                Console.WriteLine("a и b до вызова: " + a
                + " " + b);

                ob.NoChange(a, b);

                Console.WriteLine("a и b после вызова: " + a
                + " " + b);
            }
        }
    }
}
