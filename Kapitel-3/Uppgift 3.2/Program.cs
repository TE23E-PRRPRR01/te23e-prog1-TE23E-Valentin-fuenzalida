Console.Clear();

Console.WriteLine("Detta program ska ta reda på om användaren vet vilket lag som vann fotbolls-VM för flickor 2015");

Console.WriteLine("Vilken lag vann fotbolls-VM för damer 2015? ");
string svar = Console.ReadLine();

string rättsvar = "USA";

if (svar == rättsvar.ToLower())
{
    Console.WriteLine("Du hade rätt");
}

if (svar != rättsvar.ToLower())
{
    Console.WriteLine("Du svarade fel svar");
}