using System;

namespace SimpleCalculator
{
    class Calculator
    {
        // Method for addition
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Method for subtraction
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        // Method for multiplication
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        // Method for division
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0;
            }
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- Simple Calculator ---");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5)
                {
                    running = false;
                    Console.WriteLine("Exiting calculator...");
                    break;
                }

                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (choice)
                {
                    case 1:
                        result = calc.Add(num1, num2);
                        break;
                    case 2:
                        result = calc.Subtract(num1, num2);
                        break;
                    case 3:
                        result = calc.Multiply(num1, num2);
                        break;
                    case 4:
                        result = calc.Divide(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        continue;
                }

                Console.WriteLine("Result: " + result);
            }
        }
    }
}
