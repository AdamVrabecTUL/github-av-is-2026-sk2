using System;

class Program
{
    static void Main()
    {
        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("******************************************");
            Console.WriteLine("***** Vykreslení pravoúhlého trojúhelníku *");
            Console.WriteLine("******************************************");
            Console.WriteLine();

            // Načtení výšky trojúhelníku (počet řádků)
            Console.Write("Zadejte výšku trojúhelníku (celé kladné číslo): ");
            int vyska;
            while (!int.TryParse(Console.ReadLine(), out vyska) || vyska <= 0)
            {
                Console.Write("Nezadali jste přirozené číslo. Zadejte výšku znovu: ");
            }

            Console.WriteLine();

            // Vykreslení pravoúhlého trojúhelníku
            // Vnější cyklus řídí řádky (od 1 až do zadané výšky)
            for (int i = 1; i <= vyska; i++)
            {
                // Vnitřní cyklus vypíše tolik hvězdiček, jaké je číslo aktuálního řádku (i)
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'.");
            again = Console.ReadLine();
        }
    }
}