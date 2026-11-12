using System;

class Program
{
    static void Main()
    {
        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("***** Vykreslení obrazce ***");
            Console.WriteLine("****************************");
            Console.WriteLine();

            // Načtení šířky (strana a)
            Console.Write("Zadejte délku strany a (šířka - celé kladné číslo): ");
            int a;
            while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.Write("Nezadali jste přirozené číslo. Zadejte délku strany a znovu: ");
            }

            // Načtení výšky (strana b)
            Console.Write("Zadejte délku strany b (výška - celé kladné číslo): ");
            int b;
            while (!int.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.Write("Nezadali jste přirozené číslo. Zadejte délku strany b znovu: ");
            }

            Console.WriteLine();

            // Vykreslení obdélníku / čtverce pomocí vnořených cyklů
            // Vnější cyklus řídí řádky (výšku b)
            // Vykreslení obdélníku se střídáním barev po řádcích
            for (int i = 0; i < b; i++)
            {
                // Sudý řádek bude modrý, lichý žlutý
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                for (int j = 0; j < a; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

// DŮLEŽITÉ: Vrácení barvy zpět na výchozí, aby nebyl obarvený i zbytek textu v konzoli
Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'.");
            again = Console.ReadLine();
        }
    }
}