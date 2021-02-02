using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание норме 3
            Console.WriteLine("Количество желаемой суммы");

            int Rub = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Перевод валюты из Евро в рубли - 1 ");

            Console.WriteLine("Перевод валюьы из Долларов в рубли - 2 ");

            int caseSwitch = Convert.ToInt32(Console.ReadLine());
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Сумма в евро равна " + (Rub * 92));
                    break;
                case 2:
                    Console.WriteLine("Сумма в Долларах равна " + (Rub * 76));
                    break;
                default:
                    Console.WriteLine("Валюта отсутствует");
                    break;

            }
        }
    }
}
