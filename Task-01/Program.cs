using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter weight (kg):");
            if (!double.TryParse(Console.ReadLine(), out double weight))
            {
                Console.WriteLine("Invalid weight input!");
                return;
            }

            Console.WriteLine("Enter height (m): ");
            if (!double.TryParse(Console.ReadLine(), out double height))
            {
                Console.WriteLine("Invalid height input!");
                return;
            }

            if (weight > 0 && height > 0)
            {
                double bmi = weight / (height * height);
                Console.WriteLine($"Your BMI is: {bmi:F2}");
            }
            else
            {
                Console.WriteLine("Weight and height must be positive numbers!");
            }
        }
    }
}