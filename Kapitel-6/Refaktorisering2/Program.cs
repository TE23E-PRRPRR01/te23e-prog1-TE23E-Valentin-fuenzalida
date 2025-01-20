using System.Globalization;

Console.Clear();

/* *************************************************
 * Namn: SummeraTal
 * Beskrivning: Ett program för att summera tal
 * Datum: 2024-09-01
 *********************************************** */

intro();

int poäng = 0; // Poängräkning för utmaningen

while (true)
{

    string val = Console.ReadLine();
    Meny();

    if (val == "1")
    {
        int storlek = LäsInHeltal();

        char tecken = SkrivInTecken();

        Ritafyrkant(storlek, tecken);

    }
    else if (val == "2")
    {

        int höjd = LäsInHeltal();

char tecken = SkrivInTecken();

        RitaTriangel(höjd, tecken);
    }
    else if (val == "3")
    {
        int höjd = LäsInHeltal();

        int bredd = LäsInHeltal();

        Console.Write("Ange ett tecken att rita med: ");
        char tecken = Console.ReadKey().KeyChar;
        Console.WriteLine();

        RitaRektangel(höjd, bredd, tecken);
    }
    else if (val == "4")
    {
        int höjd = LäsInHeltal();

        Console.Write("Ange ett tecken att rita med: ");
        char tecken = Console.ReadKey().KeyChar;
        Console.WriteLine();

        RitaPyramid(höjd, tecken);
    }
    else if (val == "5")
    {
        SparaFigure();
    }
    else if (val == "6")
    {
        LäsInSparadFigure();
    }
    else if (val == "7")
    {
        Random slump = new Random();
        int korrektSvar = slump.Next(3, 10);

        int gissning = LäsInHeltal();

        Utmaning(gissning, korrektSvar, poäng);

        Console.WriteLine($"Nuvarande poäng: {poäng}");

        Korrekt(korrektSvar);
    }
    else
    {
        Console.WriteLine("Ogiltigt alternativ, försök igen.");
    }

    Outro();
}

static void intro()
{
    Console.Clear();
    Console.WriteLine("""
Program för att rita konsolgrafik
===================================
""");
}

static void Meny()
{
    Console.WriteLine("""
    1. Skriv ut fyrkant
    2. Skriv ut triangel
    3. Skriv ut rektangel
    4. Skriv ut pyramid
    5. Spara figur
    6. Läs in sparad figur
    7. Utmaning: Gissa storleken
    8. Avsluta
    """);

    Console.Write("Välj ett alternativ: ");
}

static int LäsInHeltal()
{
    Console.Write("Ange storlek: ");
    string input = Console.ReadLine();
    int storlek;
    while (!int.TryParse(input, out storlek))
    {
        Console.Write("Ange ett giltigt heltal: ");
        input = Console.ReadLine();
    }
    return storlek;
}

static char SkrivInTecken()
{
        Console.Write("Ange ett tecken att rita med: ");
        char tecken = Console.ReadKey().KeyChar;
        Console.WriteLine();   
        return tecken;
}

static void Ritafyrkant(int storlek, char tecken)
{
    for (int i = 0; i < storlek; i++)
    {
        for (int j = 0; j < storlek; j++)
        {
            Console.Write(tecken);
        }
        Console.WriteLine();
    }
}

static void RitaTriangel(int höjd, char tecken)
{
    for (int i = 0; i < höjd; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write(tecken);
        }
        Console.WriteLine();
    }
}

static void RitaRektangel(int höjd, int bredd, char tecken)
{
    for (int i = 0; i < höjd; i++)
    {
        for (int j = 0; j < bredd; j++)
        {
            Console.Write(tecken);
        }
        Console.WriteLine();
    }
}

static void RitaPyramid(int höjd, char tecken)
{
    for (int i = 0; i < höjd; i++)
    {
        for (int j = 0; j < höjd - i - 1; j++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j < 2 * i + 1; j++)
        {
            Console.Write(tecken);
        }
        Console.WriteLine();
    }
}

static void SparaFigure()
{
    Console.WriteLine("Ange figur att spara:");
    string figur = Console.ReadLine();
    File.WriteAllText("figur.txt", figur);
    Console.WriteLine("Figuren har sparats!");
}

static void LäsInSparadFigure()
{
    if (File.Exists("figur.txt"))
    {
        Console.WriteLine("Senast sparade figur:");
        Console.WriteLine(File.ReadAllText("figur.txt"));
    }
    else
    {
        Console.WriteLine("Ingen sparad figur hittades.");
    }
}

static void Utmaning(int gissning, int korrektSvar, int poäng)
{
    if (gissning == korrektSvar)
    {
        Console.WriteLine("Rätt gissat! Du får 1 poäng.");
        poäng++;
    }
    else
    {
        Console.WriteLine($"Fel! Rätt svar var {korrektSvar}.");
    }
}

static void Korrekt(int korrektSvar)
{
    for (int i = 0; i < korrektSvar; i++)
    {
        for (int j = 0; j < korrektSvar; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

static void Outro()
{
    Console.WriteLine("\nTryck på valfri tangent för att fortsätta...");
    Console.ReadKey();
    Console.Clear();   
}