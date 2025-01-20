Console.Clear();

Console.WriteLine("Uppfigt 16");

static int Taremot()
{
    string Antalbokstäver = Console.ReadLine();
    int räknabokstäver = Antalbokstäver.Length;
    return räknabokstäver;
}

Console.WriteLine("ange ett tal");

Console.WriteLine(Taremot());


Console.WriteLine();


Console.WriteLine("Uppgift 17");

static int Vokaler()
{
    int antal = 0;
    string ord = Console.ReadLine().ToLower();
    foreach (var Vokaler in ord)
    {
        if (ord.Contains(/[aeiou]/))
        {
            antal++;
        }
        else if (ord.Contains("e"))
        {
            antal++;
        }
        else if (ord.Contains("i"))
        {
            antal++;
        }
        else if (ord.Contains("o"))
        {
            antal++;
        }
        else if (ord.Contains("u"))
        {
            antal++;
        }
        else if (ord.Contains("y"))
        {
            antal++;
        }
        else if (ord.Contains("å"))
        {
            antal++;
        }
        else if (ord.Contains("ä"))
        {
            antal++;
        }
        else if (ord.Contains("ö"))
        {
            antal++;
        }
        else
        {
            antal = 0;
        }
    }
    return antal;
}

Console.WriteLine("skriv ett ord");

Console.WriteLine(Vokaler());
