using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_want_to_fire
{
    class Destruct
    {
        public int x;

        public Destruct(int i)
        {
            x = i;
        }

        ~Destruct()
        {
            Console.WriteLine("Уничтожить " + x);
        }

        public void Generator(int i)
        {
            Destruct o = new Destruct(i);
        }
    }
        public class DestructMenu
        {
            public static void M()
            {
                int count;

                Destruct ob = new Destruct(0);

                for (count = 1; count < 50000; count++)
                {
                    ob.Generator(count);
                }

                Console.WriteLine("Готово!");
            }
        }
}

