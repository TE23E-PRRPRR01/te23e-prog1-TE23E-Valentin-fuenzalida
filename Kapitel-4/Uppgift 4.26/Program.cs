Console.Clear();

Console.WriteLine("Skriv in ett tal: ");
string taltext = Console.ReadLine();

for (int i = 0; i < taltext.Length; i++)
{
    string tecken = taltext[i].ToString();
    int siffra = int.Parse(tecken);
    if (siffra == 9)
    {
        Console.Write("0");
    }
    else
    {
        Console.Write(siffra + 1);
    }
}