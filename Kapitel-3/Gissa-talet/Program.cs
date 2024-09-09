// gissa ett hemligt tal
Console.Clear();

Console.WriteLine("gissa ett hemligt tal");

//slumpa ett tal
int slumptalet = Random.Shared.Next(1, 101);


Console.Write("gissa ett tall 1-100");
// läs in talen

string gissningtext = Console.ReadLine();

//convertera texten till ett hel tal
int gissning = int.Parse(gissningtext);

if (gissning == slumptalet)
{
    Console.WriteLine("bra, du har gissat rätt");

}
else if (gissning > slumptalet)
{
    Console.WriteLine("för högt");
}
else
{
    Console.WriteLine("för lågt");
}



Console.WriteLine($"slumptalet var {slumptalet}");