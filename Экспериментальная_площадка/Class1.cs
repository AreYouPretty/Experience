using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using I_m_still_here;
using Kill_my_trouble;
using I_want_to_fire;
using Am;

namespace I_m
{
    class Working
    {
        #region Example1
        public static void Example1()
        {
            int x, y;
            x = 100;

            Console.WriteLine("x содержит: " + x);

            y = x / 2;

            Console.Write("y содержит x / 2: ");
            Console.WriteLine(y);
        }
        #endregion

        #region Example2
        public static void Example2()
        {
            int ivar;
            double dvar;

            ivar = 100;
            dvar = 100;

            Console.WriteLine("Исходное значение ivar: " + ivar);
            Console.WriteLine("Исходное значение dvar: " + dvar);

            Console.WriteLine();

            ivar = ivar / 3;
            dvar = dvar / 3;

            Console.WriteLine("Pначение ivar после деления: " + ivar);
            Console.WriteLine("Значение dvar после деления: " + dvar);
        }
        #endregion

        #region Example3
        public static void Example3()
        {
            double radius, area;
            radius = 10;
            area = radius * radius * 3.1416;

            Console.WriteLine("Площадь равна: " + area);
        }
        #endregion

        #region Example4
        public static void Example4()
        {
            int a = 2, b = 3, c;

            if (a < b)
                Console.WriteLine("a меньше b");

            if (a == b)
                Console.WriteLine("этого никто не увидит");

            Console.WriteLine();

            c = a - b;

            Console.WriteLine("c содержит -1");

            if (c >= 0)
                Console.WriteLine("значение c неотрицательно");

            if (c < 0)
                Console.WriteLine("значение c отрицательно");

            c = b - a;

            Console.WriteLine();

            Console.WriteLine("c содержит 1");

            if (c >= 0)
                Console.WriteLine("значение c неотрицательно");

            if (c < 0)
                Console.WriteLine("значение c отрицательно");
        }
        #endregion

        #region Example5
        public static void Example5()
        {
            int count;

            for (count = 0; count < 5; count++)
                Console.WriteLine("Это подсчёт: " + count);

            Console.WriteLine("Готово!");
        }
        #endregion

        #region Example6
        public static void Example6()
        {
            int i, j, d;

            i = 5;
            j = 10;

            if (i != 0)
            {
                Console.WriteLine("i не равно нулю");
                d = j / i;
                Console.WriteLine("j/i равно " + d);
            }
        }
        #endregion

        #region Example7
        public static void Example7()
        {
            int prod, sum;

            sum = 0;
            prod = 1;

            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
                prod = prod * i;
            }
            Console.WriteLine("Сумма равна " + sum);
            Console.WriteLine("Произведение равно " + prod);

        }
        #endregion

        #region Example8
        public static void Example8()
        {
            int @if;

            for (@if = 0; @if < 10; @if++)
                Console.WriteLine("@if равно: " + @if);
        }
        #endregion

        #region Example9
        public static void Example9()
        {
            long inches, miles;

            miles = 93000000; // мили от Земли до  Солнца

            //5 280 футов в миле, 12 дюймов в футе.
            inches = miles * 5280 * 12;

            Console.WriteLine("Расстояние до Солнца: " + inches + " дюймов.");
        }
        #endregion

        #region Example10
        public static void Example10()
        {
            byte x;
            int sum = 0;

            for (x = 1; x <= 100; x++)
                sum = sum + x;

            Console.WriteLine("Сумма чисел от 1 до 100 равна " + sum);

        }
        #endregion

        #region Example11
        public static void Example11()
        {
            double r, area;

            area = 10;

            r = Math.Sqrt(area / 3.1416);

            Console.WriteLine("Радиус равен " + r);
        }
        #endregion

        #region Example12
        public static void Example12()
        {
            double theta;

            for (theta = 0.1; theta <= 1.0; theta = theta + 0.1)
            {
                Console.WriteLine("Синус угла " + theta + " равен " + Math.Sin(theta));
                Console.WriteLine("Косинус угла " + theta + " равен " + Math.Cos(theta));
                Console.WriteLine("Тангенс угла " + theta + " равен " + Math.Tan(theta));
                Console.WriteLine();
            }
        }
        #endregion

        #region Example13
        public static void Example13()
        {
            decimal price, discount, discounted_price;

            price = 19.95m;
            discount = 0.15m;

            discounted_price = price - (price * discount);

            Console.WriteLine("Цена со скидкой: $" + discounted_price);
        }
        #endregion

        #region Example14
        public static void Example14()
        {
            decimal amount, rate_of_return;
            int years, i;

            amount = 1000m;
            rate_of_return = 0.07m;
            years = 10;

            Console.WriteLine("Первоначальные капиталовложения: $" + amount);
            Console.WriteLine("Норма прибыли: " + rate_of_return);
            Console.WriteLine("В течение " + years + " лет");

            for (i = 0; i < years; i++)
                amount = amount + (amount * rate_of_return);

            Console.WriteLine("Будущая стоимость равна $" + amount);
        }
        #endregion

        #region Example15
        public static void Example15()
        {
            bool b = false;

            Console.WriteLine("b равно " + b);
            b = true;
            Console.WriteLine("b равно " + b);

            if (b)
                Console.WriteLine("Выполняется.");

            b = false;

            if (b)
                Console.WriteLine("Не выполняется.");

            Console.WriteLine("(10 > 9) равно " + (10 > 9));

        }
        #endregion

        #region Example16
        public static void Example16()
        {
            Console.WriteLine("Вы заказали " + 2 + " предмета по цене $" + 3 + " каждый.");
            Console.WriteLine("Деление 10/3 даёт: " + 10.0 / 3.0);
            Console.WriteLine("В феврале {0} или {1} дней.", 28, 29);
            Console.WriteLine("В феврале {0,10} или {1,5} дней.", 28, 29);
        }
        #endregion

        #region Example17
        public static void Example17()
        {
            Console.WriteLine("Число\tКвадрат\tКуб");

            for (int i = 1; i < 10; i++)
                Console.WriteLine("{0}\t{1}\t{2}", i, i * i, i * i * i);

            Console.WriteLine();
            Console.WriteLine("Деление 10/3 даёт: {0:#.##}", 10.0 / 3.0);
            Console.WriteLine("{0:###,###.##}", 123456.56);

        }
        #endregion

        #region Example18
        public static void Example18()
        {
            decimal balance = 12323.09m;

            Console.WriteLine("Текущий баланс равен {0:C}", balance);
        }
        #endregion

        #region Example19
        public static void Example19()
        {
            decimal price, discount, discounted_price;

            price = 19.95m;
            discount = 0.15m;
            discounted_price = price - (price * discount);

            Console.WriteLine("Цена со скидкой: ${0:C}", discounted_price);

        }
        #endregion

        #region Example20
        public static void Example20()
        {
            int c = 0xFF, d = 0x1a;

            Console.WriteLine(c);
            Console.WriteLine(d);

            Console.Write("Звуковой сигнал\a ");
            Console.Write("Возврат на одну позицию\b ");
            Console.Write("Переход на новую страницу\f ");
            Console.Write("Новая строка\n ");
            Console.Write("Возврат каретки\r ");
            Console.Write("Горизонтальная табуляция\t ");
            Console.Write("Вертикальная табуляция\v ");
            Console.Write("Пустой символ\0 ");
            Console.Write("Одинарная кавычка\' ");
            Console.Write("Двойная кавычка\" ");
            Console.Write("Обратная косая черта\\ ");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Первая строка\nВторая строка\nТретья строка");
            Console.WriteLine("Один\tДва\tТри");
            Console.WriteLine("Четыре\tПять\tШесть");
            Console.WriteLine("\"Зачем?\", спросил он.");
        }
        #endregion

        #region Example21
        public static void Example21()
        {
            Console.WriteLine(@"Это буквальный 
строковый литерал,
занимающий несколько строк.
");
            Console.WriteLine(@"А это вывод с табуляцией:
1 2     3           4
5 6     7           8
");
            Console.WriteLine(@"Отзыв программиста: ""Когда-нибудь программист напишет здесь комментарий про C#"" ");
        }
        #endregion

        #region Example22
        public static void Example22()
        {
            double s1 = 4, s2 = 5, hypot;

            hypot = Math.Sqrt((s1 * s1) + (s2 * s2));

            Console.Write("Гипотенуза треугольника со сторонами " + s1 + " и " + s2 + " равна ");
            Console.WriteLine("{0:#.###}.", hypot);

        }
        #endregion

        #region Example23
        public static void Example23()
        {
            var s1 = 4;
            var s2 = 5;

            var hypot = Math.Sqrt((s1 * s1) + (s2 * s2));

            Console.Write("Гипотенуза треугольника со сторонами " + s1 + " и " + s2 + " равна ");
            Console.WriteLine("{0:#.###}.", hypot);

            //s1 = 12m; //Ошибка.
        }
        #endregion

        #region Example24
        public static void Example24()
        {
            int x = 10;

            if (x == 10)
            {
                int y = 20;

                Console.WriteLine("x и y: " + x + " " + y);
                x = y * 2;
            }
            //y = 100; //Ошибка. Переменная здесь недоступна.

            Console.WriteLine("x равно " + x);
        }
        #endregion

        #region Example25
        public static void Example25()
        {
            // Эта программа не может быть скомпилирована.
            /*int x;

            for (x = 0; x < 3; x++)
            {
                int y = -1;
                Console.WriteLine("y равно: " + y);

                y = 100;
                Console.WriteLine("y теперь равно: " + y);
            }*/

        }
        #endregion

        #region Example26
        public static void Example26()
        {
            //Эта программа не может быть скомпилирована.
            /* int count;

             for (count = 0; count < 10; count++)
             {
                 Console.WriteLine("Это подсчёт: " + count);
             }

             int count; //Недопустимо!

             for(count = 0;count < 2; count++)
             {
                 Console.WriteLine("В этой программе есть ошибка!");
             }*/

        }
        #endregion

        #region Example27
        public static void Example27()
        {
            long L;
            double D;

            L = 100123285L;
            D = L;

            /*
             Недопустимо.
             d=130812025d;
            l=d;
             */

            Console.WriteLine("L и D: " + L + " " + D);
        }
        #endregion

        #region Example28
        public static void Example28()
        {
            double x, y;
            byte b;
            int i;
            char ch;
            uint u;
            short s;
            long l;

            x = 10;
            y = 3;

            i = (int)(x / y);
            Console.WriteLine("Целочисленный результат деления x/y: " + i);
            Console.WriteLine();

            i = 255;
            b = (byte)i;
            Console.WriteLine("b после присваивания 255: " + b + " -- без потери данных.");


            i = 257;
            b = (byte)i;
            Console.WriteLine("b после присваивания 257: " + b + " -- с потерей данных.");
            Console.WriteLine();

            u = 32000;
            s = (short)u;
            Console.WriteLine("s после присваивания 32 000: " + s + " -- без потери данных.");

            u = 64000;
            s = (short)u;
            Console.WriteLine("s после присваивания 64 000: " + s + " -- с потерей данных.");
            Console.WriteLine();

            l = 64000;
            u = (uint)l;
            Console.WriteLine("u после присваивания 64 000: " + u + " -- без потери данных.");

            l = -12;
            u = (uint)l;
            Console.WriteLine("u после присваивания -12: " + u + " -- с потерей данных.");
            Console.WriteLine();

            b = 88;
            ch = (char)b;
            Console.WriteLine("ch после присваивания 88: " + ch);
        }
        #endregion

        #region Example29
        public static void Example29()
        {
            /* byte b = 10;

             b = (byte)b * b; //Необходимо приведение типов.

             Console.WriteLine("b: " + b);*/
        }
        #endregion

        #region Example30
        public static void Example30()
        {
            double n;
            for (n = 1; n <= 10; n++)
            {
                Console.WriteLine("Квадратный корень из {0} равен {1}", n, Math.Sqrt(n));
                Console.WriteLine("Целая часть числа: {0}", (int)Math.Sqrt(n));
                Console.WriteLine("Дробная часть числа: {0}", Math.Sqrt(n) - (int)Math.Sqrt(n));
                Console.WriteLine();

            }
        }
        #endregion

        #region Example31
        public static void Example31()
        {
            int iresult, irem;
            double dresult, drem;

            iresult = 10 / 3;
            irem = 10 % 3;

            dresult = 10.0 / 3.0;
            drem = 10.0 % 3.0;

            Console.WriteLine("Результат и остаток от деления 10 / 3: " + iresult + " " + irem);
            Console.WriteLine("Результат и остаток от деления 10.0 / 3.0: " + dresult + " " + drem);

        }
        #endregion

        #region Example32
        public static void Example32()
        {
            int x = 1, y = 0, i;

            Console.WriteLine("Ряд чисел, полученных " + "с помощью оператора y = y + x++;");

            for (i = 0; i < 10; i++)
            {
                y = y + x++;

                Console.WriteLine(y + " ");
            }
            Console.WriteLine();

            x = 1;
            y = 0;

            Console.WriteLine("Ряд чисел, полученных " + "с помощью оператора y = y + ++x;");

            for (i = 0; i < 10; i++)
            {
                y = y + ++x;

                Console.WriteLine(y + " ");
            }
            Console.WriteLine();

        }
        #endregion

        #region Example33
        public static void Example33()
        {
            int i = 10, j = 11;
            bool b1, b2;

            if (i < j)
                Console.WriteLine("i < j");
            if (i <= j)
                Console.WriteLine("i <= j");
            if (i != j)
                Console.WriteLine("i != j");
            if (i == j)
                Console.WriteLine("Нельзя выполнить");
            if (i >= j)
                Console.WriteLine("Нельзя выполнить");
            if (i > j)
                Console.WriteLine("Нельзя выполнить");

            b1 = true;
            b2 = false;
            if (b1 & b2)
                Console.WriteLine("Нельзя выполнить");
            if (!(b1 & b2))
                Console.WriteLine("!(b1 & b2) - true");
            if (b1 | b2)
                Console.WriteLine("b1 | b2 - true");
            if (b1 ^ b2)
                Console.WriteLine("b1 ^ b2 - true");
        }
        #endregion

        #region Example34
        public static void Example34()
        {
            bool p = false, q = false;
            int i, j;

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    if (i == 0) p = true;
                    if (i == 1) p = false;
                    if (j == 0) q = true;
                    if (j == 1) q = false;

                    Console.WriteLine("p равно " + p + ", q равно " + q);
                    if (!p | q)
                        Console.WriteLine("Результат импликации " + p + " и " + q + " равен " + true);
                    Console.WriteLine();
                }
            }


        }
        #endregion

        #region Example35
        public static void Example35()
        {
            int n = 10, d = 2;

            if (d != 0 && (n % d) == 0)
                Console.WriteLine(n + " делицо нацело на " + d);

            d = 0;

            if (d != 0 && (n % d) == 0)
                Console.WriteLine(n + " делицо нацело на " + d);

            //if (d != 0 & (n % d) == 0)        //ошибка
            //    Console.WriteLine(n + " делицо нацело на " + d);

        }
        #endregion

        #region Example36
        public static void Example36()
        {
            int i = 0;
            bool someCondition = false;

            if (someCondition & (++i < 100))
                Console.WriteLine("Не выводится");
            Console.WriteLine("Оператор if выполняется: " + i);

            if (someCondition && (++i < 100))
                Console.WriteLine("Не выводится");
            Console.WriteLine("Оператор if выполняется: " + i);
        }
        #endregion

        #region Example37
        public static void Example37()
        {
            ushort num, i;

            for (i = 1; i <= 10; i++)
            {
                num = i;

                Console.WriteLine("num: " + num);

                num = (ushort)(num & 0xFFFE);

                Console.WriteLine("num после сброса младшего разряда: " + num + "\n");

            }
        }
        #endregion

        #region Example38
        public static void Example38()
        {
            ushort num = 10;

            if ((num & 1) == 1)
                Console.WriteLine("Не выводится.");

            num = 11;

            if ((num & 1) == 1)
                Console.WriteLine(num + "- нечетное число.");

        }
        #endregion

        #region Example39
        public static void Example39()
        {
            int t;
            byte val = 123;

            for (t = 128; t > 0; t = t / 2)
            {
                if ((val & t) != 0) Console.Write("1 ");
                if ((val & t) == 0) Console.Write("0 ");
            }

        }
        #endregion

        #region Example40
        public static void Example40()
        {
            ushort num, i;

            for (i = 1; i <= 10; i++)
            {
                num = i;

                Console.WriteLine("num: " + num);

                num = (ushort)(num | 1);

                Console.WriteLine("num после установки младшего разряда: " + num + "\n");
            }
        }
        #endregion

        #region Example41
        public static void Example41()
        {
            char ch1 = 'H', ch2 = 'i', ch3 = '!';
            int key = 88;

            Console.WriteLine("Исходное сообщение: " + ch1 + ch2 + ch3);

            ch1 = (char)(ch1 ^ key);
            ch2 = (char)(ch2 ^ key);
            ch3 = (char)(ch3 ^ key);

            Console.WriteLine("Зашифрованное сообщение: " + ch1 + ch2 + ch3);

            ch1 = (char)(ch1 ^ key);
            ch2 = (char)(ch2 ^ key);
            ch3 = (char)(ch3 ^ key);

            Console.WriteLine("Расшифрованное сообщение: " + ch1 + ch2 + ch3);
        }
        #endregion

        #region Example42
        public static void Example42()
        {
            sbyte b = -34;

            for (int t = 128; t > 0; t = t / 2)
            {
                if ((b & t) != 0)
                    Console.Write("1 ");
                if ((b & t) == 0)
                    Console.Write("0 ");
            }
            Console.WriteLine();

            b = (sbyte)~b;
            for (int t = 128; t > 0; t = t / 2)
            {
                if ((b & t) != 0)
                    Console.Write("1 ");
                if ((b & t) == 0)
                    Console.Write("0 ");
            }

        }
        #endregion

        #region Example43
        public static void Example43()
        {
            int val = 1;

            for (int i = 0; i < 8; i++)
            {
                for (int t = 128; t > 0; t = t / 2)
                {
                    if ((val & t) != 0)
                        Console.Write("1 ");
                    if ((val & t) == 0)
                        Console.Write("0 ");
                }
                Console.WriteLine();
                val = val << 1;
            }

            val = 128;

            for (int i = 0; i < 8; i++)
            {
                for (int t = 128; t > 0; t = t / 2)
                {
                    if ((val & t) != 0)
                        Console.Write("1 ");
                    if ((val & t) == 0)
                        Console.Write("0 ");
                }
                Console.WriteLine();
                val = val >> 1;
            }

        }
        #endregion

        #region Example44
        public static void Example44()
        {
            int n = 10;
            Console.WriteLine("Значение переменной n: " + n);

            n = n << 1;
            Console.WriteLine("Значение переменной n " + " операции n = n * 2: " + n);

            n = n << 2;
            Console.WriteLine("Значение переменной n " + " операции n = n * 4: " + n);

            n = n >> 1;
            Console.WriteLine("Значение переменной n " + " операции n = n / 2: " + n);

            n = n >> 2;
            Console.WriteLine("Значение переменной n " + "после операции n = n / 4: " + n);

            Console.WriteLine();

            n = 10;
            Console.WriteLine("Значение переменной n: " + n);

            n = n << 30;
            Console.WriteLine("Значение переменной n " + " сдвига на 30 позиций влево: " + n);

        }
        #endregion

        #region Example45
        public static void Example45()
        {
            int result;

            for (int i = -5; i < 6; i++)
            {
                result = i != 0 ? 100 / i : 0;
                if (i != 0)
                    Console.WriteLine("100 / " + i + " равно " + result);
            }

            Console.WriteLine();

            for (int i = -5; i < 6; i++)
            {
                if (i != 0 ? (i % 2 == 0) : false)
                    Console.WriteLine("100 / " + i + " равно " + 100 / i);
            }

        }
        #endregion

        #region Example46
        public static void Example46()
        {
            int i;

            for (i = -5; i <= 5; i++)
            {
                Console.Write("Проверка  " + i);

                if (i < 0)
                    Console.WriteLine(" отрицательное число");
                else
                    Console.WriteLine(" положительное число");
            }
        }
        #endregion

        #region Example47
        public static void Example47()
        {
            int i;

            for (i = -5; i <= 5; i++)
            {
                Console.Write("Проверка  " + i + ": ");

                if (i < 0)
                    Console.WriteLine("отрицательное число");
                else if (i == 0)
                    Console.WriteLine("число без знака");
                else
                    Console.WriteLine("положительное число");
            }
        }
        #endregion

        #region Example48
        public static void Example48()
        {
            int num;

            for (num = 2; num < 12; num++)
            {
                if ((num % 2) == 0)
                    Console.WriteLine("Наименьший множитель числа " + num + " равен 2.");
                else if ((num % 3) == 0)
                    Console.WriteLine("Наименьший множитель числа " + num + " равен 3.");
                else if ((num % 5) == 0)
                    Console.WriteLine("Наименьший множитель числа " + num + " равен 5.");
                else if ((num % 7) == 0)
                    Console.WriteLine("Наименьший множитель числа " + num + " равен 7.");
                else
                    Console.WriteLine(num + " не делится на 2, 3, 5 или 7");

            }
        }
        #endregion

        #region Example49
        public static void Example49()
        {
            int i;

            for (i = 0; i < 10; i++)
                switch (i)
                {
                    case 0:
                        Console.WriteLine("i равно нулю");
                        break;
                    case 1:
                        Console.WriteLine("i равно единице");
                        break;
                    case 2:
                        Console.WriteLine("i равно двум");
                        break;
                    case 3:
                        Console.WriteLine("i равно трём");
                        break;
                    case 4:
                        Console.WriteLine("i равно четырём");
                        break;
                    default:
                        Console.WriteLine("i равно или больше пяти");
                        break;
                }
        }
        #endregion

        #region Example50
        public static void Example50()
        {
            char ch;

            for (ch = 'A'; ch <= 'E'; ch++)
                switch (ch)
                {
                    case 'A':
                        Console.WriteLine("ch содержит A");
                        break;
                    case 'B':
                        Console.WriteLine("ch содержит B");
                        break;
                    case 'C':
                        Console.WriteLine("ch содержит C");
                        break;
                    case 'D':
                        Console.WriteLine("ch содержит D");
                        break;
                    case 'E':
                        Console.WriteLine("ch содержит E");
                        break;
                }
        }
        #endregion

        #region Example51
        public static void Example51()
        {
            int i;

            for (i = 1; i < 5; i++)
                switch (i)
                {
                    case 1:
                    case 2:
                    case 3:
                        Console.WriteLine("i равно 1, 2 или 3");
                        break;
                    case 4:
                        Console.WriteLine("i равно четырём");
                        break;

                }
        }
        #endregion

        #region Example52
        public static void Example52()
        {
            char ch1, ch2;
            for (ch1 = 'A'; ch1 <= 'A'; ch1++)
                for (ch2 = 'A'; ch2 <= 'A'; ch2++)
                {
                    {
                        switch (ch1)
                        {
                            case 'A':
                                Console.WriteLine("Эта ветвь A - Часть " +
                                    "внешнего оператора switch.");

                                switch (ch2)
                                {
                                    case 'A':
                                        Console.WriteLine("Эта ветвь A - Часть " +
                                        "внутренняя оператора switch.");
                                        break;
                                }
                                break;
                        }
                    }
                }
        }
        #endregion

        #region Example53
        public static void Example53()
        {
            int x;

            for (x = 100; x >= -100; x -= 5)
                Console.WriteLine(x);
        }
        #endregion

        #region Example54
        public static void Example54()
        {
            int num, i, factor;
            bool isprime;

            for (num = 2; num < 20; num++)
            {
                isprime = true;
                factor = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if ((num % i) == 0)
                    {
                        isprime = false;
                        factor = i;
                    }
                }
                if (isprime)
                    Console.WriteLine(num + " - простое число.");
                else
                    Console.WriteLine("Наибольший множитель числа "
                        + num + " равен " + factor);
            }
        }
        #endregion

        #region Example55
        public static void Example55()
        {
            int i, j;

            for (i = 0, j = 10; i < j; i++, j--)
            {
                Console.WriteLine("i и j: " + i + " " + j);
            }
        }
        #endregion

        #region Example56
        public static void Example56()
        {
            int i, j,
               smallest, largest,
               num = 100;

            smallest = largest = 1;

            for (i = 2, j = num / 2; (i <= num / 2) & (j >= 2); i++, j--)
            {
                if ((smallest == 1) & ((num % i) == 0))
                    smallest = i;

                if ((largest == 1) & ((num % j) == 0))
                    largest = j;
            }

            Console.WriteLine("Наибольший множитель: " + largest);
            Console.WriteLine("Наименьший множитель: " + smallest);

        }
        #endregion

        #region Example57
        public static void Example57()
        {
            int i, j;
            bool done = false;

            for (i = 0, j = 100; !done; i++, j--)
            {
                if (i * i >= j) done = true;
                Console.WriteLine("i, j:" + i + " " + j);
            }

        }
        #endregion

        #region Example58
        public static void Example58()
        {
            int i;

            for (i = 0; i < 10;)
            {
                Console.WriteLine("Проход №" + i);
                i++;
            }

            Console.WriteLine();
            i = 0;

            for (; i < 10;)
            {
                Console.WriteLine("Проход №" + i);
                i++;
            }

            for (; ; )
            {
                Console.WriteLine();
                Console.WriteLine("Бесконечность - не предел!");
                Console.WriteLine();
                break;
            }
        }
        #endregion

        #region Example59
        public static void Example59()
        {
            int i, sum = 0;

            Console.WriteLine();

            for (i = 1; i <= 5; sum += i++) ;

            Console.WriteLine("Сумма равна " + sum);
        }
        #endregion

        #region Example60
        public static void Example60()
        {
            int sum = 0, fact = 1;

            for (int i = 1; i <= 5; i++)
            {
                sum += i;
                fact *= i;
            }

            Console.WriteLine("Сумма равна " + sum);
            Console.WriteLine("Факториал равен " + fact);
        }
        #endregion

        #region Example61
        public static void Example61()
        {
            int num = 435679, mag = 0, e, result;

            Console.WriteLine("Число: " + num);

            while (num > 0)
            {
                mag++;
                num /= 10;
            };

            Console.WriteLine("Порядок величины: " + mag);
            Console.WriteLine("\n");

            for (int i = 0; i < 10; i++)
            {
                result = 1;
                e = i;

                while (e > 0)
                {
                    result *= 2;
                    e--;
                }
                Console.WriteLine("2 в степени " + i + " равно " + result);
            }

        }
        #endregion

        #region Example62
        public static void Example62()
        {
            int num = 27297, nextdigit;

            Console.WriteLine("Число: " + num);
            Console.Write("Число в обратном порядке: ");

            do
            {
                nextdigit = num % 10;
                Console.Write(nextdigit);
                num = num / 10;
            }
            while (num > 0);

            Console.WriteLine();
        }
        #endregion

        #region Example63
        public static void Example63()
        {
            for (int n = -10; n <= 10; n++)
            {
                if (n > 0) break;

                Console.Write(n + " ");

            }
            Console.WriteLine("Готово!");
            Console.WriteLine();

            int i = -10;
            do
            {
                if (i > 0)
                    break;

                Console.Write(i + " ");
                i++;
            } while (i <= 10);

            Console.WriteLine("Готово!");
            Console.WriteLine();

            int factor = 1, num = -1000;

            for (int j = 2; j <= num / j; j++)
            {
                if ((num % j) == 0)
                {
                    factor = j;
                    break;
                }
            }

            Console.WriteLine("Наименьший множитель равен " + factor);
            Console.WriteLine();

            for (int t = 0; t < 3; t++)
            {
                Console.WriteLine("Подсчёт во внешнем цикле: " + t);
                Console.Write(" Подсчёт во внутреннем цикле: ");

                int h = 0;
                while (h < 100)
                {
                    if (h == 10) break;
                    Console.Write(h + " ");
                    h++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("Циклы завершены.");
        }
        #endregion

        #region Example64
        public static void Example64()
        {
            for (int i = 0; i <= 100; i++)
            {
                if ((i % 2) != 0)
                    continue;
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            for (int i = 0; i <= 100; i++)
            {
                if ((i % 2) == 0)
                    continue;
                Console.Write(i + " ");
            }
        }
        #endregion

        #region Example65
        public static void Example65()
        {
            int x = 1;
        loops1: x++;
            Console.Write(x + " ");
            if (x < 100) goto loops1;

            Console.WriteLine("\n");

            for (int i = 1; i < 5; i++)
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine("В ветви case 1.");
                        goto case 3;
                    case 2:
                        Console.WriteLine("В ветви case 2.");
                        goto case 1;
                    case 3:
                        Console.WriteLine("В ветви case 3.");
                        goto default;
                    default:
                        Console.WriteLine("В ветви default.");
                        break;
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            int t = 0, j = 0, k = 0;

            for (t = 0; t < 10; t++)
            {
                for (j = 0; j < 10; j++)
                {
                    for (k = 0; k < 10; k++)
                    {
                        Console.WriteLine("t, j, k: " + t + ", "
                            + j + ", " + k);
                        if (k == 3) goto stop;
                    }
                }
            }

        stop:
            Console.WriteLine("Моя остановочка! t, j, k:" + t + ", "
                + j + ", " + k);

        }
        #endregion

        #region Example66
        public static void Example66()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    return;
                Console.WriteLine();
            }
        }
        #endregion

        #region Example67
        public static void Example67()
        {
            I_m_still_here.BuildingDemo.My_future();
        }
        #endregion

        #region Example68
        public static void Example68()
        {
            Kill_my_trouble.ParmDemo.More();
        }
        #endregion


        #region Example69
        public static void Example69()
        {
            int i = new int();

            Console.WriteLine("i = " + i);

        }
        #endregion

        #region Example70
        public static void Example70()
        {
            I_want_to_fire.DestructMenu.M();
        }
        #endregion
        
        #region Example71
        public static void Example71()
        {
            Am.UseRect.More();
        }
        #endregion
    }

    
}
