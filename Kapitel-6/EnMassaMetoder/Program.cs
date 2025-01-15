// /* *************************************************************
// * **********************     M A I N            ***********************
// **************************************************************** */


// Console.Clear();

// SägHejNamn("Valentin");

// KvadratTal(3);

// /* *************************************************************
// * ********************* M E T O D E R *************************
// **************************************************************** */

// /// <summary>
// /// Hälsar med input
// /// </summary>
// /// <param name="namn">Namnet</param>
// static void SägHejNamn(string namn)
// {
//     Console.WriteLine($"Hej på {namn}!");
// }

// /// <summary>
// /// Metod som kvaderar ett tal
// /// </summary>
// /// <param name="Tal"></param>

// static void KvadratTal(int Tal)
// {
//     Console.WriteLine($"{Tal} i kvadrat = {Tal*Tal}");
// }









// static void SkrivPerson(string namn, int ålder)
// {
//     Console.WriteLine($"Personen heter {namn} och är {ålder} år gammal");
// }

// SkrivPerson("Holland", 35);
// SkrivPerson("Lisa", 25);



Console.WriteLine("Uppgift 1");

Console.WriteLine("skriv ett tal");
int tal = int.Parse(Console.ReadLine());


static void JämntUdda(int tal)
{
    if (tal % 2 == 0)
    {
        Console.WriteLine($"{tal} är jämt");
    }
    else
    {
        Console.WriteLine($"{tal} är udda");
    }
}

JämntUdda(tal);

Console.WriteLine();


Console.WriteLine("Uppgift 2");

Console.WriteLine("Skriv in en temperatur i Celsius");
int Celsius = int.Parse(Console.ReadLine());

static void CelsiusTillFahrenheit(int Celsius)
{
    Console.WriteLine($"{Celsius} grader Celsius motsvara {Celsius * 9/5 + 32}");
}

CelsiusTillFahrenheit(Celsius);

Console.WriteLine();


Console.WriteLine("Uppgift 3");

Console.WriteLine("Skriv ett heltal");
int heltal = int.Parse(Console.ReadLine());

static void Omvandla(int heltal)
{
    for (int i = 0; i < heltal; i++)
    {
        Console.Write("#");
    }
}

Omvandla(heltal);

Console.WriteLine();


Console.WriteLine("Uppgift 4");


Console.WriteLine("Skriv in ett heltal");
int Heltal = int.Parse(Console.ReadLine());

Console.WriteLine();

static void Vertikalt(int Heltal)
{
    for (int i = 1; i <= Heltal; i++)
    {
        Console.WriteLine(i);
    }
}

Vertikalt(Heltal);

Console.WriteLine();



Console.WriteLine("Uppgift 5");

Console.WriteLine("Skriv ett Heltal");
int Ettheltal = int.Parse(Console.ReadLine());

Console.WriteLine("Skriv en text");
string text = Console.ReadLine();

static void Text(int Ettheltal, string text)
{
    for (int i = 1; i < Ettheltal; i++)
    {
        Console.WriteLine($"{text}");
    }
}

Text(Ettheltal, text);


Console.WriteLine();



Console.WriteLine("Uppgfit 6");

Console.WriteLine("skriv ett heltal");
int AndraHeltal = int.Parse(Console.ReadLine());

static void SlumpaTal(int AndraHeltal)
{
    Random generator = new Random();

    for (int i = 0; i < AndraHeltal; i++)
    {
        Console.WriteLine(generator.Next(1, 7));
    }
}

SlumpaTal(AndraHeltal);

Console.WriteLine();

Console.WriteLine("Uppgift 7");

Console.WriteLine("Skriv ett Heltal");
int Förstatal = int.Parse(Console.ReadLine());

Console.WriteLine("Skriv ett till heltal");
int AndraHeltalet = int.Parse(Console.ReadLine());

static void Jämföra(int Förstatal, int AndraHeltalet)
{
    if (Förstatal > AndraHeltalet)
    {
        Console.WriteLine($"{Förstatal} är större");
    }
    else
    {
        Console.WriteLine($"{AndraHeltalet} är större");
    }
}

Jämföra(Förstatal, AndraHeltalet);

Console.WriteLine();


Console.WriteLine("Uppgift 8");

Console.WriteLine("Skriv in ett tal");
int tal1 = int.Parse(Console.ReadLine());

Console.WriteLine("Skriv in ett tal");
int tal2 = int.Parse(Console.ReadLine());

static void Inbetween(int tal1, int tal2)
{
    for (int i = (tal1+1); i < tal2; i++)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine();

Inbetween(tal1, tal2);

Console.WriteLine();


Console.WriteLine("Uppgift 9");


