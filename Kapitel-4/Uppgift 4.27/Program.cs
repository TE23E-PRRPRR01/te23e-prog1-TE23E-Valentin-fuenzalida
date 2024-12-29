Console.Clear();

Console.WriteLine("skriv in ett meddelande: ");
string meddelande = Console.ReadLine();

Console.WriteLine("Antal steg åt höger");
int antal = int.Parse(Console.ReadLine());


for (int i = 0; i < meddelande.Length; i++)
{
    for (int j = 0; j < antal; j++)
    {
        Console.Write(" ");
    }

    Console.WriteLine(meddelande[i]);
}