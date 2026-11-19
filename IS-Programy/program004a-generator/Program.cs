using System;

namespace program000b_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string again = "a";
            while (again == "a")
            {
                Console.Clear();
                Console.WriteLine("*************************************************");
                Console.WriteLine("***** Generátor pseudonáhodných čísel *****");
                Console.WriteLine("*************************************************");
                Console.WriteLine();

                // Vstup od uživatele s ošetřením
                Console.Write("Zadejte počet generovaných čísel (n): ");
                int n;
                while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.Write("Nezadali jste kladné celé číslo. Zadejte n znovu: ");
                }

                Console.Write("Zadejte dolní mez (lowerBound): ");
                int lowerBound;
                while (!int.TryParse(Console.ReadLine(), out lowerBound))
                {
                    Console.Write("Nezadali jste celé číslo. Zadejte lowerBound znovu: ");
                }

                Console.Write("Zadejte horní mez (upperBound): ");
                int upperBound;
                while (!int.TryParse(Console.ReadLine(), out upperBound) || upperBound < lowerBound)
                {
                    Console.Write("Nezadali jste celé číslo nebo je menší než lowerBound. Zadejte upperBound znovu: ");
                }
            }
        }
    }
}