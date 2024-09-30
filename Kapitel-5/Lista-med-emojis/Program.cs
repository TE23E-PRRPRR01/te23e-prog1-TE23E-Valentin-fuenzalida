using System.Runtime.Intrinsics.Arm;

Console.Clear();

// Aktivera Unicode för att visa Emoji
Console.OutputEncoding = System.Text.Encoding.Unicode;

// Skapa en lista med emojis
List<string> emojis = ["❤️", "🃏", "😾", "🦁"];

// Slumpa fram 5 emojis
int antalEmojis = 4;
while (antalEmojis > 0)
{
    // slumpa fram ett tal mellan 0 och antalet emojis
    int index = Random.Shared.Next(0, emojis.Count);
    string emoji = emojis[index];
    Console.WriteLine($"Du valde: {emoji}");
    antalEmojis --;

    // Ta bort emoji från listan
    emojis.RemoveAt(index);

    // Avsluta om det inte finns några Emojis kvar
    if (antalEmojis == 0)
    {
        Console.WriteLine("Det finns inga fler emojis");
        break;
    }

    // vill du välja fler exempler
    Console.WriteLine("Vill du välja en till emoji? (j/n): ");
    if (Console.ReadLine().ToLower() != "j")
    {
        break;
    }
}