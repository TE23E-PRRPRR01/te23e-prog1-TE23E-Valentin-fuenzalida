Console.Clear();


// Skapa en lista med 52 kort
List<string> kortlek = ["Ess", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Knekt", "Dam", "Kung"];


// Slump ut 5 kort
int antalkort = 5;
while (antalkort > 0)
{
    // Slumpa ett index för att kort i kortleken
    int index = Random.Shared.Next(0, kortlek.Count);
    string kort = kortlek[index];
    Console.WriteLine($"Du drog kortet: {kort}");

    // Räkna ner antalet dragna kort
    antalkort--;

    // Ta bort kortet från kortleken
    kortlek.RemoveAt(index);

    // Avsluta om det finns fler kort i kortleken
    if (kortlek.Count == 0)
    {
        Console.WriteLine("Det finns inga fler kort i kortleken.");
        break;
    }

    // Skriv ut alla kort kvar i kortleken
    Console.WriteLine("Kvar i kortleken: ");
    foreach (var kortKvar in kortlek)
    {
        Console.WriteLine(kortKvar);
    }
    Console.WriteLine();

    // vill du dra fler kort?
    Console.WriteLine("Vill du dra ett till kort? (j/n): ");
    if (Console.ReadLine().ToLower() != "j")
    {
        break;
    }
}
