Console.Clear();

Console.WriteLine("detta är ett program för att räkna ut produkten av två tal");

Console.WriteLine("Ange ett heltal: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Ange ett heltal: ");
int b = int.Parse(Console.ReadLine());

int s = b + a;

int p = b * a;

Console.WriteLine("Summan av talen är: " + s);

Console.WriteLine("Produkten av talen är: " + p);