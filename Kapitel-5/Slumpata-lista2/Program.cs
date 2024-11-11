// slumpa lista med slumpade tal


/* ************************************************************
**                          Main                             **
*************************************************************** */


// validerar användarens inmatning

Console.Clear();

// deklarera variabler
// skapa en lista för att spara des slumpade talen

List<int> listaSlumptal = [];



// fråga igen tills användaren matar in ett gilltigt svar
int antal = LäsInHeltal();
Console.WriteLine($"du vill ha {antal} slumptal");

int min = LäsInHeltal();
Console.WriteLine($"lägsta slumptal blir {min}:");

int max = LäsInHeltal();
Console.WriteLine($"Högsta slumptal blir {max}:");

// Slumpar så många tal som användaren ber om
for (int i = 0; i < antal; i++)
{
    // Slumpar ett tal mellan 1 och 10
    int slumptal = Random.Shared.Next(min, max + 1);

    // Skriver ut det slumpade talet plus att skriva vilken ordning de slumpade talen är i
    Console.WriteLine("Slumpat tal: " + (i + 1) + ": " + slumptal);
}

/* ************************************************************
**                         Mina egna metoder
*************************************************************** */

static int LäsInHeltal()
{
    int heltal = 0;
    while (true)
    {
        // fråga använderaren hur många slumptal som ska skapas
        Console.WriteLine("Ange heltal: ");
        bool lyckades = int.TryParse(Console.ReadLine(), out  heltal);

        if (lyckades)
        {
            break;
        }
        else
        {
            Console.WriteLine("Du måste skriva ett heltal");
        }

    }
    return heltal;
}