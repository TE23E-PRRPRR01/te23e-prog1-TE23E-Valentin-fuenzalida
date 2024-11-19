Console.Clear();

Console.WriteLine("Detta är ett program för att ta reda på skillnaded i längd meter");

Console.WriteLine("Skriv in hur långt Elin hoppade (svara i meter)");
double Elinhöjd = double.Parse(Console.ReadLine());

Console.WriteLine("Skriv in hur långt Alma hoppade (svara i meter)");
double Almahöjd = double.Parse(Console.ReadLine());

double summa = Elinhöjd - Almahöjd;
Console.WriteLine($"Elin hoppade {summa} meter längre");