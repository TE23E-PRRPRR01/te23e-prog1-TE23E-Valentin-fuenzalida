Console.Clear();



string användarensval = "";
while (användarensval != "3")
{
    Console.WriteLine(@"
    Välj ett av följande alternativ.
    1. Subtrahera ett tal med ett annat
    2. Dividera ett tal med ett annat
    3. Avsluta programmet");
    användarensval = Console.ReadLine();

    switch (användarensval)
    {
        case "1":
        Console.WriteLine("skriv in ett tal");
        double tal1 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Skriv in ett till tal");
        double tal2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"Subrtationen av talen är = {tal1 - tal2}");
        break;

        case "2":
        Console.WriteLine("skriv in ett tal");
        double tal3 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Skriv in ett till tal");
        double tal4 = double.Parse(Console.ReadLine());

        Console.WriteLine($"Division av talen är = {tal3/tal4}");
        break;

        default:
        break;
    }

}