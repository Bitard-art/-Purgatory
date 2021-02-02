
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gudlaskap
{
    class Program
    {
        static void Main(string[] args)
        {
            //     Задание номер 1

            double a, b;

            Console.WriteLine("Введите первое число");
            
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");

            b = double.Parse(Console.ReadLine());

            double resulr = (a + b) / 2;
            
            Console.WriteLine(resulr);
            Console.ReadLine();

            //     Задание номер 2

            double G, V, C;

            Console.WriteLine("Введите первое число");

            G = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");

            V = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число");

            C = double.Parse(Console.ReadLine());

            double m = G + V + C;
            double p = G * V * C;

            Console.WriteLine("Сложение = " + m);
            Console.WriteLine("Умножение = " + p);
            Console.ReadLine();


        }  



        
    }
}
