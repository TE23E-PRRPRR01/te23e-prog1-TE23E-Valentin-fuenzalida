Console.Clear();

Console.WriteLine("Detta program ska få reda på om du får köpa kaffe för ett billigare pris");

Console.WriteLine("Hur gammal är du? ");
int ålder = int.Parse(Console.ReadLine());

if ((ålder >= 10 && ålder <= 18) || ålder >= 65)
{
    Console.WriteLine("Du får köpa kaffe billigare");
}
else
{
    Console.WriteLine("Du får inte köpa kaffe billigt");
}
