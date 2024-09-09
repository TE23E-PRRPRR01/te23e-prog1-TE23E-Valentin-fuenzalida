Console.Clear();

Console.WriteLine("åldergränser för spel");

Console.WriteLine("vad är ålder");

string dinålder = Console.ReadLine();

int ålder = int.Parse(dinålder);


if (ålder < 10)
{
    Console.WriteLine("du bode leva livet utan att bry dig om att spela och bara ha kul i verkliga livet");
}

if (ålder == 10)
{
    Console.WriteLine("Du får spela väldigt få spel och du borde istället vara ute och få vänner");
}

if (ålder == 16)
{
    Console.WriteLine("du får spela de flesta spelen förutom de spelen som är för realistiska, för mer realistiska spel måste du ha tillstånd från föräldrar");
}

if (ålder >= 18 && ålder <= 25)
{
    Console.WriteLine("Du får alla spel, och du kan bestäma över dit liv själv");
}

if (ålder >= 25 && ålder <= 40)
{
    Console.WriteLine("Du är gammal nog att spela de mest realistiska spelen men jag skulle säga att det är bättre att fokusera på annat än spel i din ålder");
}

if (ålder > 40)
{
    Console.WriteLine("ta hand om din familj istället och om du har barn, än att spela ett spel som inte kommer hjälpa dig alls");
}
