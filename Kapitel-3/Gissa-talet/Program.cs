// Det här programmet slumpar ett tal mellan 1 och 6
// och låter användaren gissa vilket tal som har slumpats
Console.Clear();
Console.WriteLine("Program för att gissa ett tal mellan 1 och 6");

// Generera ett slumpmässigt heltal mellan 1 och 6
int slumptal = Random.Shared.Next(1, 7);

// En loop som fortsätter tills användaren gissar rätt
while (true)
{
    Console.Write("Gissa ett tal (1-6): ");
    int gissning = int.Parse(Console.ReadLine());

    // Kontrollera om användarens gissning matchar det slumpade talet
    if (gissning == slumptal)
    {
        Console.WriteLine("Rätt svar!");
        break; // Avbryter loopen om gissningen är korrekt
    }
    else
    {
        Console.WriteLine("Fel svar!");
    }
}

Console.WriteLine("Tack för att du spelade!");