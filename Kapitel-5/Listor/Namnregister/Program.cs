// ett litet namnregister
Console.Clear();
Console.WriteLine("ett litet namnregister");


List<string> namnregister = [];

// program loopen
while (true)
{
    // visa en meny
    Console.WriteLine(@"
1. registrera namn
2. skriva ut alla namn
3. avsluta programmet
Ange ditt val
");
    // skapa variblen för menyn
    string val = Console.ReadLine();

    // avslutar programmet om användaren väljer val 3
    if (val == "3")
    {
        break;
    }

    // registrerar ett namn om användaren väljer 1
    else if (val == "1")
    {
        Console.WriteLine("Ange ett namn: ");
        string namn = Console.ReadLine();
        namnregister.Add(namn);
    }

    // Skriv ut alla registrerade namn
    else if (val == "2")
    {
        foreach (var allanamn in namnregister)
        {
            Console.Write($"{allanamn}, ");
        }
    }
}