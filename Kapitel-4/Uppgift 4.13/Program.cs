Console.Clear();

Console.WriteLine("Skriv in rektangelns bredd: ");
int bredd = int.Parse(Console.ReadLine());
Console.WriteLine("Skriv in rektangelns höjd");
int höjd = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 0; i < höjd; i++)
{
    for (int j = 0; j < bredd; j++)
    {
        if (i == 0 || i == höjd - 1 || j == 0 || j == bredd - 1)
        {
            Console.Write("X");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}