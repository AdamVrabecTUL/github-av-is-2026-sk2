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
            for (int i = 0; i < b; i++)
            {
                // Vnitřní cyklus řídí sloupce na daném řádku (šířku a)
                for (int j = 0; j < a; j++)
                {
                    Console.Write("* "); // Mezera za hvězdičkou zajistí, že čtverec vypadá jako čtverec
                }
                // Po vypsání celého řádku odřádkujeme
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'.");
            again = Console.ReadLine();
        }
    }
}