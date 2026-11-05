using System;

class Program
{
    static void Main()
    {
        Console.Write("Zadejte celé číslo: ");
        string input = Console.ReadLine();

        // Ošetření záporného znaménka a neplatných znaků
        input = input.Trim();
        if (input.StartsWith("-"))
        {
            input = input.Substring(1); // Odstraní záporné znaménko '-'
        }

        int sum = 0;
        int product = 1;
        bool isValid = input.Length > 0; // Kontrola, zda nezůstal prázdný řetězec

        // Projdeme všechny znaky v textu jeden po druhém
        foreach (char c in input)
        {
            // Převod znaku '0'-'9' na jeho číselnou hodnotu
            if (char.IsDigit(c))
            {
                int digit = c - '0'; // Příklad: '5' - '0' = 5
                sum += digit;
                product *= digit;
            }
            else
            {
                isValid = false;
                break;
            }
        }

        if (isValid)
        {
            Console.WriteLine($"Součet cifer: {sum}");
            Console.WriteLine($"Součin cifer: {product}");
        }
        else
        {
            Console.WriteLine("Neplatný vstup. Zadejte prosím platné celé číslo.");
        }
    }
}