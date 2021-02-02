using System;

namespace Калькулятор
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

            switch (c)
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    Console.WriteLine(a / b);
                    break;
                default:
                    Console.WriteLine("Команда не понятна");
                    break;
            }
                
            
        }
    }
}
