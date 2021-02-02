using System;

namespace Задание_четности
{
    class Program
    {
        static void Main(string[] args)
        {
         int a;

         a = int.Parse(Console.ReadLine());

            if (a%2==0)
            {
                Console.WriteLine("Ваше число чётное ");
            }
            else
            {
                Console.WriteLine("Ваше число не чётное");
            }
        }
    }
}
