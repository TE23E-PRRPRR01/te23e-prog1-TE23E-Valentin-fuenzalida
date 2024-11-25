Console.Clear();


Console.WriteLine("Detta program ska ta reda på om du får åka i en berg-och-dalbana");

Console.WriteLine("hur lång är du (svara i meter): ");
double längd = double.Parse(Console.ReadLine());

if (längd >= 1.5 && längd <= 1.9)
{
    Console.WriteLine("du får åka i berg-och-dalbanan");   
}
else if (längd < 1.5)
{
    Console.WriteLine("Du är för kort för denna berg-och-dalbanan");
}
else if (längd > 1.9)
{
    Console.WriteLine("Du är för lång för berg-och-dalbanan");
}