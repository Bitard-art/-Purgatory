using System;

namespace Счётчик_чётных_и_не_чётных_Второй_вариант
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = int.Parse(Console.ReadLine());
            uint Even = 0;
            uint Noeven = 0;


            while (a < b)
            {
                a++;
                Console.WriteLine(a);
                if (a % 2 == 0)
                {
                    Console.WriteLine("Чётное число");
                    Even++;
                    Console.WriteLine("Кол-во Чёртных" + "  " + Even);

                }
                else
                {
                    Console.WriteLine("Не чётное число");
                    Noeven++;
                    Console.WriteLine("Кол-во не Чётных" + "  " + Noeven);


                }
            }


        }
    }
}
