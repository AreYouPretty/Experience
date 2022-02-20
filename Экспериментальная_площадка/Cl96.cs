using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H12h7
{
    public class More
    {
        int alpha, beta;
        public More(int i, int j)
        {
            alpha = i;
            beta = j;
        }

        public bool SameAs(More ob)
        {
            if ((ob.alpha == alpha) & (ob.beta == beta))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Copy(More ob)
        {
            alpha = ob.alpha;
            beta = ob.beta;
        }

        public void Show()
        {
            Console.WriteLine("alpha: {0}, beta: {1}",
                alpha, beta);
        }
    }


    public class P35
    {
        public static void M12()
        {
            More ob1 = new More(4, 5);
            More ob2 = new More(6, 7);

            Console.Write("ob1: ");
            ob1.Show();

            Console.Write("ob2: ");
            ob2.Show();

            if (ob1.SameAs(ob2))
            {
                Console.WriteLine("ob1 и ob2 имеют " +
                    "одинаковые значения.");
            }
            else
            {
                Console.WriteLine("ob1 и ob2 имеют " +
                    "разные значения.");
            }

            Console.WriteLine();

            ob1.Copy(ob2);

            Console.Write("ob1 после копирования: ");
            ob1.Show();

            if (ob1.SameAs(ob2))
            {
                Console.WriteLine("ob1 и ob2 имеют " +
                    "разные значения.");
            }
            else
            {
                Console.WriteLine("ob1 и ob2 имеют " +
                   "разные значения.");
            }

        }
    }

}
    
    


