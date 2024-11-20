Console.Clear();

Console.WriteLine("Detta program ska beräkna en mellanlön mellan 3 personer");

Console.WriteLine("Ange hur mycket en anställd tjänar i lön i kr");
int anställd1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ange hur mycket en anställd tjänar i lön i kr");
int anställd2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ange hur mycket en anställd tjänar i lön i kr");
int anställd3 = int.Parse(Console.ReadLine());


int mellanlön = (anställd1 + anställd2 + anställd3) / 3;

Console.WriteLine($"Mellanlönen för det tre anställde är {mellanlön}");