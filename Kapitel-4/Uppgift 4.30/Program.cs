Console.Clear();

Console.WriteLine("Hur många X per grupp?");
int antalX = int.Parse(Console.ReadLine());
Console.WriteLine("Hur många O? per grupp");
int antalO = int.Parse(Console.ReadLine());
Console.WriteLine("Hur många O-grupper per rad?");
int antalGånger = int.Parse(Console.ReadLine());
Console.WriteLine("Hur många rader?");
int antalRader = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 0; i < antalRader; i++)
{
    for (int j = 0; j < antalGånger; j++)
    {
        for (int k = 0; k < antalX; k++)
        {
            Console.Write("X");
        }
        Console.Write("-");

        for (int k = 0; k < antalO; k++)
        {
            Console.Write("O");
        }
        Console.Write("-");
    }
    for (int k = 0; k < antalX; k++)
    {
        Console.Write("X");
    }
    Console.WriteLine();
}
Console.WriteLine();