using System;

namespace DZ__7__Video_46
{
    class Program
    {
        static void WoW(string ARK, uint Surv)
        {
            for (int i = 0; i < Surv; i++)
            {
                Console.WriteLine(ARK);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите желаемый символ");
            String ARK = Console.ReadLine();

            Console.WriteLine("Желаемое количество символов");
            uint Surv = uint.Parse(Console.ReadLine());

            Program.WoW(ARK, Surv);
            Console.ReadLine();

        }




    }
}