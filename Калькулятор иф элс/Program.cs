using System;

namespace Калькулятор_иф_элс
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите желаемые числа");
            double a;
            double b;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            string c;
            Console.WriteLine("Ведите символ +  -  *  / ");
            c = Console.ReadLine();

            if (c == "+")
            {
                Console.WriteLine(a + b);
            }
            if (c == "-")
                Console.WriteLine(a - b);

            if (c == "*")
                Console.WriteLine(a * b);

            if (c == "/")
                Console.WriteLine(a / b);
            


        }   
    }
}
