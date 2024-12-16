Console.Clear();

// alla mina tomma Console.WriteLine är för att lämna en rad i mellan

Console.WriteLine("I denna övning ska du träna på att använda listor för att lagra, lägga till, ta bort och visa data. Du kommer också att hantera användarens inmatning för att arbeta med listan.");

Console.WriteLine();

// skapar en tom lista
List<string> Actionspellista = [];

// skapa en ny tom lista
List<string> Äventyrspellista = [];

string användarensval = "";

while (användarensval != "e")
{
    Console.WriteLine(@"
    
    a. Visa alla action-spel
    b. Registrera ett action-spel
    c. Visa alla äventyrsspel
    d. Registrera tre äventyrsspel
    e. Avsluta
    Välj ett alternativ:");
    användarensval = Console.ReadLine();

    switch (användarensval)
    {
        case "a":
            foreach (var action in Actionspellista)
            {
                Console.WriteLine($"- {action}");
            }
            break;

        case "b":
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("registrera ett action-spel");
                string action = Console.ReadLine();
                Actionspellista.Add(action);
            }
            break;

        case "c":
            foreach (var äventyr in Äventyrspellista)
            {
                Console.WriteLine($"- {äventyr}");
            }
            break;

        case "d":
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("registrera ett action-spel");
                string äventyr = Console.ReadLine();
                Äventyrspellista.Add(äventyr);
            }
        break;
        default:
        Console.WriteLine("programmet kommer att avslutas");
        break;
    }
}