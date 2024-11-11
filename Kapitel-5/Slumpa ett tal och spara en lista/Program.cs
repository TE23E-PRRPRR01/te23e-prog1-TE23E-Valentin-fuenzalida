Console.Clear();
Console.WriteLine("Välkommen till slumptalprogrammet!");


while (true)
{
    // be användaren välja hur många tal som ska slumpas
    Console.WriteLine("Hur många tal vill du slumpa");
    int antal = int.Parse(Console.ReadLine());

    Console.WriteLine("--------------------------------");

    // be använderen ange min och max 
    Console.WriteLine("Ange ett minivärde för intervallet");
    int min = int.Parse(Console.ReadLine());

    Console.WriteLine("--------------------------------");

    Console.WriteLine("Ange ett maxvärde för intervallet");
    int max = int.Parse(Console.ReadLine());

    Console.WriteLine("--------------------------------");


    // skapa en lista för att lagra tal
    List<int> listaSlumptal = [];

    // Slumpar endast antal större en noll
    if (antal > 0 && max > min)
    {
        // Slumpar så många tal som användaren ber om
        for (int i = 0; i < antal; i++)
        {
            // Slumpar ett tal mellan 1 och 10
            int slumptal = Random.Shared.Next(min, max + 1);

            //lägg till talet i listan
            listaSlumptal.Add(slumptal);

            // Skriver ut det slumpade talet plus att skriva vilken ordning de slumpade talen är i
            Console.WriteLine("Slumpat tal: " + (i + 1) + ": " + slumptal);


        }

        Console.WriteLine("De slumpade talen är:");
        foreach (int tal in listaSlumptal)
        {
            Console.WriteLine(tal);
        }

        Console.WriteLine("--------------------------------");

        // Vill användaren slumpa fler tal
        Console.WriteLine("Vill du slumpa fler tal? (j/n): ");
        if (Console.ReadLine().ToLower() != "j")
        {
            break;
        }
    }

    // om inte antalet är större än noll
    else if (antal < 0)
    {
        Console.WriteLine("Antalet tal måste vara större än 0");
    }
    else if (max < min)
    {
        Console.WriteLine("Min måste vara mindre än max och max måste vara större än min");
    }
}
