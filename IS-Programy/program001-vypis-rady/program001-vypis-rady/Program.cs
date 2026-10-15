Console.WriteLine("NAZDAR");
//JEdnořádkový komentář
/*
Toto je víceřádkový komentář
*/
string again = "a";
// .ToLower() - převede text na malá písmena, tak že program bude pokračovat při zadání "A" nebo "a"
while(again.ToLower() == "a" )
{
    Console.Clear();
Console.WriteLine("********************************");
Console.WriteLine("**********Výpis řady************");
Console.WriteLine("********************************");
Console.WriteLine("**********Adam Vrabec***********");
Console.WriteLine("********************************");
Console.WriteLine("********************************");

// Vstup počáteční hodnoty
//Console.Write("Zadejte první číslo řady: ");
//int first = int.Parse(Console.ReadLine() ??"0");

Console.Write("Zadejte první číslo řady (Celé číslo): ");
int first;
while (!int.TryParse(Console.ReadLine(), out first))
{
    Console.WriteLine("Neplatný vstup. Zadejte prosím celé číslo.");
    Console.Write("Zadejte první číslo řady (Celé číslo): ");
}

//vstup koncové hodnoty
Console.Write("Zadejte poslední číslo řady (Celé číslo): ");
int last;
while (!int.TryParse(Console.ReadLine(), out last))
{
    Console.WriteLine("Neplatný vstup. Zadejte prosím celé číslo.");
    Console.Write("Zadejte první číslo řady (Celé číslo): ");
}

// Vstup diference s kontrolou kladné hodnoty
Console.Write("Zadejte diferenci (kladné celé číslo): ");
int step;
while (!int.TryParse(Console.ReadLine(), out step) || step <= 0)
{
    Console.Write("Diference musí být kladné číslo! Zadejte diferenci (kladné celé číslo): ");
}
 // Dotaz na opakování

 Console.WriteLine();
 Console.WriteLine();
 Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte stisknutím klávesy Enter.");
 Console.WriteLine();
 Console.Write("Chcete program opakovat? ");
 again = Console.ReadLine() ??"";
}