using System;

namespace Массив
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите элементы массива");
            
            int Dota = int.Parse(Console.ReadLine());
            int[] Masiv = new int[Dota];


            for (int a = 0; a < Masiv.Length; a++)
            {
                Console.WriteLine($"Введите элемент массива(индекс) {a}");
                Masiv[a] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Вывод массива:");
            
            int WoW = 0;
            for (int i = 0; i < Masiv.Length; i++)
            {
                if (Masiv[i] % 2 == 0)
                {
                    WoW += Masiv[i];
                }
            }

            Console.WriteLine("Сумма чётных чисел" + " " + WoW);

            Console.ReadLine();
            int Min = Masiv[0];

            for (int i = 0; i < Masiv.Length; i++)
            {
                if (Masiv[i] < Min)
                {
                    Min = Masiv[i];
                }
            }
            Console.WriteLine("Минимальное число" + " " + Min);

            Console.ReadLine();


            for (int i = Masiv.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Массив в обратном порядке" + " " + Masiv[i]);
            }

            Console.ReadLine();



        }
        }

}
