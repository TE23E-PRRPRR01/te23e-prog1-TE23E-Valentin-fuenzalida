Console.Clear();

Console.WriteLine("Detta program ska räkna ut medelvärdet av två tal");

Console.WriteLine("Ange ett tal: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Ange ett tal: ");
int b = int.Parse(Console.ReadLine());

int m = (a + b)/2;

Console.WriteLine("Talens medelvärde är " + m);