using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arg222
{
    public class Ument221
    {
        public int a, b;
        public Ument221(int i, int j)
        {
            a = i ;
            b = j;
        }

        public void Change(Ument221 ob)
        {
            ob.a = ob.a + ob.b;
            ob.b = -ob.b;
        }
    }

    public class CallByRef
    {
        public static void M()
        {
            Ument221 ob = new Ument221(15, 20);

            Console.WriteLine("a и b до вызова: " + ob.a
                + " " + ob.b);

            ob.Change(ob);

            Console.WriteLine("a и b после вызова: " + ob.a 
        + " " + ob.b);
        }
    }

}
