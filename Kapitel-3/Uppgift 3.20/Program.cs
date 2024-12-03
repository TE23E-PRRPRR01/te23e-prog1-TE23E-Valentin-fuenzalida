Console.Clear();

Console.WriteLine("Detta program ska lista ut vilka av 3 ord är först i bokstavsordning");

Console.WriteLine("skriv in ett ord: ");
string ord1 = Console.ReadLine();
Console.WriteLine("skriv in ett ord: ");
string ord2 = Console.ReadLine();
Console.WriteLine("skriv in ett ord: ");
string ord3 = Console.ReadLine();

if (ord1.CompareTo(ord2) < 0 && ord1.CompareTo(ord3) < 0)
{
    Console.WriteLine($"{ord1} är först i bokstavsordning av orden {ord1}, {ord2} och {ord3}");
}
else if (ord2.CompareTo(ord1) < 0 && ord2.CompareTo(ord3) < 0)
{
    Console.WriteLine($"{ord2} är först i bokstavsordning av orden {ord1}, {ord2} och {ord3}");
}
else
{
    Console.WriteLine($"{ord3} är först i bokstavsordning av orden {ord1}, {ord2} och {ord3}");
}