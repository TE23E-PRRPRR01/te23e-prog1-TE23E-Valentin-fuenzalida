Console.Clear();

Console.WriteLine("Menyprogram");

string användarensval = "";

while (användarensval != "3")
{
    Console.WriteLine();
    Console.Write(@"Välj ett av alternativen
    1. Omvandla meter till kilometer
    2. Omvandla kilometer till meter
    3. Avsluta programmet
    ");
    användarensval = Console.ReadLine();

    switch (användarensval)
    {
        case "1":
        Console.WriteLine("skriv in en längd: (i meter)");
        double tal = double.Parse(Console.ReadLine());
        Console.WriteLine($"{tal} i kilometer är {tal/1000}");
        break; 
        Console.WriteLine();

        case "2":
        Console.WriteLine("skriv in en längd: (i kilometer)");
        double längd = double.Parse(Console.ReadLine());
        Console.WriteLine($"{längd} i meter är {längd * 1000}");
        break;
        Console.WriteLine();

        case "3":
        Console.WriteLine("Programmet kommer att avslutas...");
        break;
        Console.WriteLine();

        default:
        Console.WriteLine("Du valde inte ett gilltigt val, försök igen");
        break;
    }
}