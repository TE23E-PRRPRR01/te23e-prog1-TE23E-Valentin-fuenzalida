Console.Clear();

Console.WriteLine("Detta program ska säga hur många datorer du äger");

Console.WriteLine("Hur många datorer äger du? ");
int antal = int.Parse(Console.ReadLine());

string datorOrd = antal > 1 ? "Datorer" : "dator";

Console.WriteLine($"Du har {antal} {datorOrd}.");