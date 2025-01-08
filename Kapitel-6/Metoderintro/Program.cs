Console.Clear();
Console.WriteLine("Hej metoder");

/* *************************************************************
* **********************     M A I N            ***********************
**************************************************************** */



/// Anropar Metoder

SägHej();

Console.WriteLine();

VisaMeny();

Console.WriteLine();

SkrivUt();

Console.WriteLine();

/* *************************************************************
* ********************* M E T O D E R *************************
**************************************************************** */


static void SägHej()
{
        Console.WriteLine("Hej på dig!");
}

static void VisaMeny()
{
    Console.WriteLine(@"
    1. Lägg till uppgift
    2. ta bort uppgift
    3. skriv ut alla uppgifter
    4. avslutning");
}

/// <summary>
/// Metod för att skriva ut något random
/// </summary>

static void SkrivUt()
{
    Console.WriteLine("Jag heter valentin och jag har en vän som heter Edvin. vad heter du?");
    string namn = Console.ReadLine();
}