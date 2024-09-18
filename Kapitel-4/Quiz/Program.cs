Console.Clear();
Console.WriteLine("Quiz");

Console.WriteLine("Vas heter du");
string namn = Console.ReadLine();

while (true)
{


    Console.WriteLine("vad heter detta gymnasium (svara a/b/c)");
    Console.WriteLine("a) NTI gymnasium Stockholm");
    Console.WriteLine("b) Teknik gymnaisum Stockholm");
    Console.WriteLine("c) Estet gymnasium Stockholm");
    string svar1 = Console.ReadLine();

    if (svar1 == "a")
    {
        Console.WriteLine("Rätt svar");
    }
    else
    {
        Console.WriteLine("Fel Svar");
    }
    Console.WriteLine("Vilken är Sverigest största stad (svara a/b/c)");
    Console.WriteLine("a) Malmö");
    Console.WriteLine("b) Göteborg");
    Console.WriteLine("c) Stockholm");
    string svar2 = Console.ReadLine();

    if (svar2 == "c")
    {
        Console.WriteLine("Rätt Svar");
    }
    else
    {
        Console.WriteLine("Fel svar");
    }

    Console.WriteLine(" Vilken är Svergies Nationaldag (svara a/b/c)");
    Console.WriteLine("a) 21 juli");
    Console.WriteLine("b) 17 maj");
    Console.WriteLine("c) 6 juni");
    string svar3 = Console.ReadLine();

    if (svar3 == "b")
    {
        Console.WriteLine("Rätt Svar");
    }
    else
    {
        Console.WriteLine("Fel Svar");
    }

    Console.WriteLine($"{namn}, Vill du spela igen (j/n)");
    string answer = Console.ReadLine().ToLower();

    if (answer != "j")
    {
        break;
    }

}