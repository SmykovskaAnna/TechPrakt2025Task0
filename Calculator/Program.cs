using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть перше число: ");
            string input1 = Console.ReadLine();
            Console.Write("Введіть друге число: ");
            string input2 = Console.ReadLine();

            if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
            {
                double sum = number1 + number2;
                Console.WriteLine($"{number1} + {number2} = {sum}");
            }
            else
            {
                Console.WriteLine("Помилка: введіть коректні числа.");
            }
        }
    }
}