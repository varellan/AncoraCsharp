using System;

namespace Lab2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;

            Console.WriteLine("Enter a value for the first number:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for the second number:");
            number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 + number2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(result);

            result = number1 - number2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(result);


            result = number1 * number2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(result);

            double results2 = (double)number1 / (double)number2;
            double results3 = number1 % number2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(results2);
            Console.WriteLine(results3);
        }
    }
}
