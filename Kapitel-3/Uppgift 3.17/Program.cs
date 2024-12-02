Console.Clear();

Console.WriteLine("Detta program ska ge användaren olika alternativ för två tal");

Console.WriteLine("skriv in ett heltal? ");
double heltal1 = double.Parse(Console.ReadLine());

Console.WriteLine("skriv in ett till heltal? ");
double heltal2 = double.Parse(Console.ReadLine());

Console.WriteLine(@"
Välj ett räknesätt
1. Addition
2. Subtraktion
3. Multiplikation
4. Division");
string räknesätt = Console.ReadLine();

Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

switch (räknesätt)
{
    case "1":
    double summa = heltal1 + heltal2;
    Console.WriteLine($"summan av de två heltalen blir {summa}");
    break;

    case "2":
    double summa2 = heltal1 -heltal2;
    Console.WriteLine($"summan av de två heltalen blir {summa2}");
    break;

    case "3":
    double produkt = heltal1 * heltal2;
    Console.WriteLine($"produkten av de två heltalen blir {produkt}");
    break;

    default:
    double kvot = heltal1/heltal2;
    Console.WriteLine($"kvoten av de två heltalen blir {kvot}");
    break;
}