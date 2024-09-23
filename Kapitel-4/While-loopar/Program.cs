Console.Clear();
Console.WriteLine("program för att omvanlda text");

//deklarera en variable för att lagra användarens val
string val = "";

//programloopen som snurrar till användaren väljer att avsluta programet
while (true)
{
    //Meny som visas för användare
    Console.WriteLine(@"""
    Välj ett av följande alternativ
    1. Omvandla en text till versaler
    2. omvandla en text till gemener
    3. avsluta programmet""");

    //läs in användarens val
    Console.WriteLine("Ditt val: ");
    val = Console.ReadLine();

    //hantera användarens val
    if (val == "1")
    {
        Console.WriteLine("skriv in en text:");
        string text = Console.ReadLine();
        Console.WriteLine($"Texten i versaler: {text.ToUpper()}");
    }
    else if (val == "2")
    {
        Console.WriteLine("skriv in en text:");
        string text = Console.ReadLine();
        Console.WriteLine($"Texten i gemener: {text.ToUpper()}");
    }
    else if (val == "3")
    {
        Console.WriteLine("Tack för idag. ");
        break;
    }
    else
    {
        Console.WriteLine("Du valde inte ett giltigt alternativ");
    }
}

