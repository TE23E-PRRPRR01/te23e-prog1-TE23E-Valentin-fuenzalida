Console.Clear();

Console.WriteLine("Detta program ska räkna ut hyre räkningen");

Console.WriteLine("Hur många timmar vill du hyra bilen? (svara i mindre än en dag)");
int timmar = int.Parse(Console.ReadLine());

int summa = timmar * 80;

if (summa > 950)
{
    summa = 950;
}

Console.WriteLine($"Din hyra blir {summa} för {timmar} timmar");