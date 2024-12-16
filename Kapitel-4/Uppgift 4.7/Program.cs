Console.Clear();

Console.WriteLine("Detta program ska beräkna siffersumman av ett tal användaren skriver in");

Console.WriteLine();

Console.WriteLine("skriv in ett tal");
string text = Console.ReadLine();

int siffersumma = 0;
for (int i = 0; i < text.Length; i++)
{
    string teckenstring = text[i].ToString();
    int tal = int.Parse(teckenstring);
    siffersumma += tal;
}

Console.WriteLine();

Console.WriteLine($"Siffersumman av {text} är lika med {siffersumma}");