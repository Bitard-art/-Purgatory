using System;

namespace Дз_9_видео_номер____65
{
    class Program
    {
        // Часть 1  Вывод массива при помощи *РЕКУРСИИ* (Всё работает по отдельности :3)
        static void H1(int[] My, int a = 0)
        {
            if (a < My.Length)
            {
                Console.WriteLine(My[a]);
                H1(My, a + 1);
            }
        }
      
        static void Main(string[] args)
        {
            int[] My = { 2, 1, 4, 6, 8 };
            H1(My);
        }

        // Часть 2 Сумма элементов при помози *РЕКУРСИИ* (Всё работает по отдельности :3)
        static int H2(int[] sum, int i = 0)
        {
            if (i >= sum.Length)
                return 0;
            int summa = H2(sum, i + 1);
            return sum[i] + summa;
            
        }
        
        static void Main1(string[] args)
        {
            int[] sum = { 7, 9, 2 };
            int summa = H2(sum);
            Console.WriteLine(summa);
        }

        // Часть 3 Сумма чисел 512 = 12 при помощи *РЕКУРСИИ* (Всё работает по отдельности :3)
        static int H3(int value)
        {
            if (value < 10)
                return value;

            int dab = value % 10;
            int tab = value / 10;

            return dab + H3(tab);
        }

        static void Main3(string[] args)
        {
            int del = 561;

            int Finish = H3(del);
            Console.WriteLine("Поздравляю вы финишировали" + " " + Finish);


        }

    }
}
