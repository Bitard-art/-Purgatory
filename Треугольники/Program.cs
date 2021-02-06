using System;

namespace Треугольники
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину");
            int Length = int.Parse(Console.ReadLine());


            for (int a = 0; a < Length; a++)
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

            for (int a = 0; a < Length; a++)
            {
                for (int b = Length; b > a; b--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            for (int a = 0; a < Length; a++)
            {
                for (int b = Length; b > a; b--)
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

            for (int a = 0; a < Length; a++)
            {
                for (int b = 0; b <= a; b++)
                {
                    Console.Write(" ");
                }
                for (int b = Length; b > a; b--)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }



            Console.ReadLine();








        }
    }
}