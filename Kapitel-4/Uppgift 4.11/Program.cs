Console.Clear();

Console.WriteLine("vilket är Europas folkrikaste land");
string svar = Console.ReadLine();
int antalgissningar = 1;

while (svar != "Tyskland".ToLower())
{
    if (antalgissningar >= 5)
    {
        Console.WriteLine("Dina gissningar är slut");
        break;
    }
    Console.WriteLine("Fel svar, försök igen");
    svar = Console.ReadLine();
    antalgissningar++;
}

if (svar == "Tyskland".ToLower())
{
    Console.WriteLine("Ditt svar är rätt.");
}