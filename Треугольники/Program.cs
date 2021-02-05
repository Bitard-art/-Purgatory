using System;

namespace Треугольники
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину");
            int Height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширину");
            int Width = int.Parse(Console.ReadLine());

            for (int a = 0; a < Height; a++)
            {
                for (int b = 0; b <= a; b++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            for (int z = 0; z < Height; z++)
            {
                for (int b = Width; b > z; b--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            for (int a = 0; a < Height; a++)
            {
                for (int b = Height; b > a; b--)
                {
                    Console.Write(" ");
                }
                for (int b = 0; b <= a; b++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            for (int a = 0; a < Height; a++)
            {
                for (int b = 0; b <= a; b++)
                {
                    Console.Write(" ");
                }
                for (int b = Height; b > a; b--)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }

        }

    }
}