using System;

namespace Task_02
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter price per visit: ");
            if (!double.TryParse(Console.ReadLine(), out double price))
            {
                Console.WriteLine("Invalid price input!");
                return;
            }

            Console.WriteLine("Enter number of visits: ");
            if (!int.TryParse(Console.ReadLine(), out int visits))
            {
                Console.WriteLine("Invalid visits input!");
                return;
            }

            // ⭐ ДОДАЙТЕ ЦЕЙ БЛОК - ЗЧИТУВАННЯ ЗНИЖКИ
            Console.WriteLine("Enter discount (%): ");
            if (!int.TryParse(Console.ReadLine(), out int discount))
            {
                Console.WriteLine("Invalid discount input!");
                return;
            }

            if (price <= 0 || visits <= 0 || discount < 0 || discount > 100)
            {
                Console.WriteLine("Invalid data! Price and visits must be positive, discount between 0 and 100.");
                return;
            }

            double total = price * visits * (1 - discount / 100.0);

            Console.WriteLine($"Total cost: {total:F2} UAH");
        }
    }
}