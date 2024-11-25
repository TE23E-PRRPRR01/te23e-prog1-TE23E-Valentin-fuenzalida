Console.Clear();

Console.WriteLine("Detta program ska lista ut hur mycket yngre/äldre använderan är än medelåldern i göteborg och hur mycket användaren är ifrån medelönen");

Console.WriteLine("Hur gammal är du? Svara i år ");
int ålder = int.Parse(Console.ReadLine());

Console.WriteLine("Hur mycket tjänar du per månad? Svara i kronor ");
int inkomst = int.Parse(Console.ReadLine());

if (ålder == 39)
{
    Console.WriteLine("Du är samma ålder som medelåldern i Göteborg");
}
else if (ålder > 39)
{
    Console.WriteLine("Du är äldre än medelåldern i Göteborg");
}
else
{
    Console.WriteLine("Du är yngre än medelåldern i Göteborg");   
}


if (inkomst == 39100)
{
    Console.WriteLine("Du tjänar like mycket som medellönen i Göteborg");
}
else if (inkomst > 39100)
{
    Console.WriteLine("Du tjänar mer än medellönen i Göteborg");
}
else
{
    Console.WriteLine("Du tjänar mindre än medellönen i Göteborg");   
}