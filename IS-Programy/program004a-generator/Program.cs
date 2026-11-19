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
                Console.WriteLine("******************************************");
                Console.WriteLine("************** Adam Vrabec ***************");
                Console.WriteLine("******************************************");
                Console.WriteLine("******************************************");

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
                Console.WriteLine();
                Console.WriteLine("=================================================");
                Console.WriteLine($"n = {n}");
                Console.WriteLine($"lowerBound = {lowerBound}");
                Console.WriteLine($"upperBound = {upperBound}");
                Console.WriteLine("=================================================");

                // Deklarace pole a generátoru
                int[] myArray = new int[n];
                Random randomNumber = new Random();

                // Počítadla pro sledované vlastnosti
                int kladna = 0;
                int zaporna = 0;
                int nulova = 0;
                int suda = 0;
                int licha = 0;

                Console.WriteLine("\nNáhodná čísla:");
                for (int i = 0; i < n; i++)
                {
                    myArray[i] = randomNumber.Next(lowerBound, upperBound + 1);
                    Console.Write($"{myArray[i]}; ");

                    if (myArray[i] > 0)
                    {
                        kladna++;
                    }
                    else if (myArray[i] < 0)
                    {
                        zaporna++;
                    }
                    else
                    {
                        nulova++;
                    }

                    if (myArray[i] % 2 == 0)
                    {
                        suda++;
                    }
                    else
                    {
                        licha++;
                    }
                }
                Console.WriteLine("\n");
                Console.WriteLine($"Počet kladných čísel: {kladna}");
                Console.WriteLine($"Počet záporných čísel: {zaporna}");
                Console.WriteLine($"Počet nulových čísel: {nulova}");
                Console.WriteLine();
                Console.WriteLine($"Počet sudých čísel: {suda}");
                Console.WriteLine($"Počet lichých čísel: {licha}");

                Console.WriteLine("\nPro opakování programu stiskněte klávesu 'a'.");
                again = Console.ReadLine();
            }
        }
    }
}