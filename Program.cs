using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("==== SIMPLE CALCULATOR ====");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");
                Console.Write("Choose option: ");

                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    exit = true;
                    continue;
                }

                Console.Write("Enter first number: ");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Invalid number!");
                    Console.ReadKey();
                    continue;
                }

                Console.Write("Enter second number: ");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Invalid number!");
                    Console.ReadKey();
                    continue;
                }

                try
                {
                    double result = choice switch
                    {
                        "1" => calc.Add(num1, num2),
                        "2" => calc.Subtract(num1, num2),
                        "3" => calc.Multiply(num1, num2),
                        "4" => calc.Divide(num1, num2),
                        _ => throw new Exception("Invalid option")
                    };

                    Console.WriteLine($"\nResult = {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nError: {ex.Message}");
                }

                Console.WriteLine("\nPress any key...");
                Console.ReadKey();
            }
        }
    }
}
