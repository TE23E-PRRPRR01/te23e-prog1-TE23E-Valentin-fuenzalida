Console.Clear();
Console.WriteLine("Quiz");

Console.WriteLine("Vas heter du");
string namn = Console.ReadLine();

int poäng = 0;

int total = poäng;


while (true)
{


    Console.WriteLine(@"""vad heter detta gymnasium (svara a/b/c)
    a) NTI gymnasium Stockholm
    b) teknik gymnasium Stockholm
    c) Estet gymnasium Stockholm""");
    string svar1 = Console.ReadLine();

    if (svar1 == "a")
    {
        Console.WriteLine("Rätt svar");
    }
    else
    {
        Console.WriteLine("Fel Svar");
    }

    int Rätta(char facit)
    {


        Console.Write("Ditt svar: ");
        total++; // tar upp antal totalpoäng med 1


        //ser till att svaret är a, b eller c
        char svar1;
        do svar1 = char.Parse(Console.ReadLine().ToLower()); //läser in och registrerar svaret
        while (svar1 != 'a' && svar1 != 'b' && svar1 != 'c'); // tills det är anitngen abc


        if (svar1 == facit)
        {
            Console.WriteLine("Rätt svar");
            poäng++;
        }
        else
        {
            Console.WriteLine("Fel svar");
            poäng--;
        }
        return poäng;
    }

    Console.WriteLine(@"""Vilken är Sverigest största stad (svara a/b/c)
    a) malmö
    b) Göteborg
    c) Stockholm""");
    string svar2 = Console.ReadLine();

    if (svar2 == "c")
    {
        Console.WriteLine("Rätt Svar");
    }
    else
    {
        Console.WriteLine("Fel svar");
    }

    Console.WriteLine(@""" Vilken är Svergies Nationaldag (svara a/b/c)
    a) 21 juli
    b) 17 maj
    c) 6 juni""");
    string svar3 = Console.ReadLine();

    if (svar3 == "b")
    {
        Console.WriteLine("Rätt Svar");
    }
    else
    {
        Console.WriteLine("Fel Svar");
    }

    Console.WriteLine($"Du fick {total} poäng");

    Console.WriteLine($"{namn}, Vill du spela igen (j/n)");
    string answer = Console.ReadLine().ToLower();

    if (answer != "j")
    {
        break;
    }

}