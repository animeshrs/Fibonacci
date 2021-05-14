using Microsoft.Extensions.DependencyInjection;
using Services;
using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to determination of nth value in Fibonacci sequence");
            Console.WriteLine("-------------------------------------------------------------");

            CalculateAndPrint();
            Console.ReadLine();
        }

        public static void CalculateAndPrint()
        {
            // inject dependencies
            var serviceProvider = Startup.ConfigureServices();
            var repository = serviceProvider.GetRequiredService<IServiceRepository>();
            
            // Factory Design Pattern
            var mathService = repository.GetMathService();
            Console.WriteLine("Please enter the value: ");
            var number = Console.ReadLine();

            int inputNumber;
            var numberParsed = int.TryParse(number, out inputNumber);

            while (!numberParsed || inputNumber < 0)
            {
                Console.WriteLine("The input number isn't valid. Please enter a valid number: ");
                number = Console.ReadLine();
                numberParsed = int.TryParse(number, out inputNumber);
            }

            var result = mathService.GetFibonacciValue(inputNumber);
            Console.WriteLine(result);
        }


    }
}
