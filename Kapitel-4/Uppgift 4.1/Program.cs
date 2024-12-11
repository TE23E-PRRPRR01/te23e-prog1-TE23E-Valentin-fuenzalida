Console.Clear();

while (true)
{
    Console.WriteLine("Vilket är folkrikaste landet? ");
    string svar = Console.ReadLine();
    if (svar == "Kina".ToLower())
    {
        Console.WriteLine("du svarade rätt");
        break;
    }
}