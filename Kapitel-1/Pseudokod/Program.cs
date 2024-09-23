Console.Clear();
Console.WriteLine("program för massa olika pseudokod");

Console.WriteLine("ange första talet");
int första = int.Parse(Console.ReadLine());

Console.WriteLine("Ange hur många gånger den ska adderas");
int antalgånger = int.Parse(Console.ReadLine());


int summa = 0;

for (int i = första; i < antalgånger; i++)
{
    summa = summa + i;
    Console.WriteLine(summa);
}


int[] heltal = { 9, 9, 287, 357, 2, 3, 3, 4, 6, 7, 7, };

Console.WriteLine("ange första talet");
int förstatalet = int.Parse(Console.ReadLine());




