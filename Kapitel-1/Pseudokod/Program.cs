Console.Clear();
Console.WriteLine("program för massa olika pseudokod");

Console.WriteLine("ange ett tal mellan 1-5");
int listarad1 = int.Parse(Console.ReadLine());

Console.WriteLine("ange ett tal mellan 6-9");
int listarad2 = int.Parse(Console.ReadLine());

Console.WriteLine("ange ett tal mellan 10-15");
int listarad3 = int.Parse(Console.ReadLine());

Console.WriteLine("ange ett tal mellan 16-19");
int listarad4 = int.Parse(Console.ReadLine());

Console.WriteLine("ange ett tal mellan 20-25");
int listarad5 = int.Parse(Console.ReadLine());

Console.WriteLine(@$"
{listarad1}
{listarad2}
{listarad3}
{listarad4}
{listarad5}");