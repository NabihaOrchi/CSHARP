using System;

namespace add
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            
            Console.Write("Enter first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            
            int result;
            result = number1 + number2;
            
            Console.WriteLine("Sum of two Numbers: " + result.ToString());
            Console.ReadLine();
        }
    }
}