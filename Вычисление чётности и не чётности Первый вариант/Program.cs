using System;

namespace Вычисление_чётности_и_не_чётности_Первый_вариант
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = int.Parse(Console.ReadLine());

            while (a < b)
            {
                a++;
                Console.WriteLine(a);
                if (a % 2 == 0)
                {
                    Console.WriteLine("Чётное число");

                }
                else
                {
                    Console.WriteLine("Не чётное число");
                }
            }


        }
    }
}
