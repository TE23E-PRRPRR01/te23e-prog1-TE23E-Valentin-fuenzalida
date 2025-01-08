Console.Clear();

Console.WriteLine("Bestäm kvadraternas sidlängd");
int sidlängd = int.Parse(Console.ReadLine());
Console.WriteLine("Bestäm rutnätets bredd");
int bredd = int.Parse(Console.ReadLine());
Console.WriteLine("Bestäm rutnätets höjd");
int höjd = int.Parse(Console.ReadLine());

for (int i = 0; i < höjd; i++)
{
    for (int j = 0; j < sidlängd; j++)
    {
        for (int k = 0; k < bredd; k++)
        {
            for (int l = 0; l < sidlängd; l++)
            {
                Console.Write("*");
            }
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}