using System;

class Program
{
    static void Main()
    {
        Console.Write("Zadejte celé číslo: ");
        string input = Console.ReadLine();

        // Ošetření neplatného vstupu
        if (int.TryParse(input, out int number))
        {
            // Převod na absolutní hodnotu pro případ záporného čísla
            number = Math.Abs(number);

            int sum = 0;
            int product = 1;

            // Speciální případ, pokud uživatel zadá rovnou nulu
            if (number == 0)
            {
                product = 0;
            }
            else
            {
                // Zpracování cifer pomocí matematiky
                while (number > 0)
                {
                    int digit = number % 10; // Získá poslední cifru (např. z 123 udělá 3)
                    sum += digit;            // Přičte cifru k celkovému součtu
                    product *= digit;        // Vynásobí cifru s celkovým součinem
                    number /= 10;            // Odstraní poslední cifru (např. z 123 udělá 12)
                }
            }

            // 5. výpis výsledků
            Console.WriteLine($"Součet cifer: {number}");
            Console.WriteLine($"Součet cifer: {sum}");
            Console.WriteLine($"Součin cifer: {product}");
        }
        else
        {
            Console.WriteLine("Neplatný vstup. Zadejte prosím platné celé číslo.");
        }
    }
}