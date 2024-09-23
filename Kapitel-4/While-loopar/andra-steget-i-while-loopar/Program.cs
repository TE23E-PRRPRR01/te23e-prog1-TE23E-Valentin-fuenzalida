Console.Clear();

// Deklarerar en variable för att lagra användarens val
string val = "";
Console.WriteLine("Detta är ett menyprogram");
Console.WriteLine("Det kan användas för att addera och multiplicera tal");

// Initiera en loop som fortsätter till användaren väljer "3" för att avsluta programmet
while (val != "3")
{
    Console.WriteLine(@"
    
    Välj ett av följande alternativ
    1. Addera två tal
    2. multiplicera två tal
    3. avsluta programmet");

    // Läs in användarens val
    Console.Write("Ditt val: ");
    val = Console.ReadLine(); 
    
    //hantera användarens val med hjälp av en switch-sats
    switch (val)
    {
        case "1":
            Console.WriteLine("Skriv in två tal på var sin rad");
            double tal1 = double.Parse(Console.ReadLine());
            double tal2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{tal1} + {tal2} = {tal1+tal2}");
            break;

        case "2":
            Console.WriteLine("Skriv in två tal på var sin rad");
            double faktor1 = double.Parse(Console.ReadLine());
            double faktor2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{faktor1} * {faktor2} = {faktor1*faktor2}");
            break;
        
        case "3":
            Console.WriteLine("Tack för idag.");
            break;

        default:
            Console.WriteLine("Du valde inte ett gilltigt alternativ");
            break;
    }
}