Console.Clear();

Console.WriteLine("Användaren ska skriva in 3 ord och programmet ska lista ut vilket ord som är i först i bokstavsordning");

Console.WriteLine("Skriv in ett ord");
string ord1 = Console.ReadLine();

Console.WriteLine("skriv in ett till ord");
string ord2 = Console.ReadLine();

Console.WriteLine("skriv in ett till ord");
string ord3 = Console.ReadLine();


if (ord1.CompareTo(ord2) < 0 && ord1.CompareTo(ord3) < 0)
{
    Console.WriteLine($"{ord1} kommer före både {ord2} och {ord3} i bokstavsordning");
}
else
{
    Console.WriteLine($"{ord1} kommer ej före både {ord2} och {ord3} i bokstavsordning");
}