Console.Clear();

Console.WriteLine("mikroövning");

int resultat = 0;

while (true)
{

        Console.WriteLine("Hur många repititioner vill du ha");
        bool lyckad = int.TryParse(Console.ReadLine(), out resultat);

    if (resultat > 0 && resultat < 11)
    {
        List<string> listanamn = ["Valentin"];

        for (int i = 0; i < resultat; i++)
        {
            Console.WriteLine($"{i + 1}. {listanamn[0]}");
        }

        break;
    }

    else
    {
        Console.WriteLine("repitioner måste vara mellan intervallet 1 till 10!!");
    }

}


Console.WriteLine("skriv in ett tal");