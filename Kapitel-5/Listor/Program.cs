// Använda listor för skapa/hantera samlingar
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

Console.Clear();

// lista på trevliga frukter: tex "äpple", "apelsin", "annanas", "granatäpple", "kiwi", "klementim", 

List<string> frukter = ["äpple", "apelsin", "annanas", "granatäpple", "kiwi", "klementim", ];

Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]}");

// ändra i listan
frukter[0] = "bannan";
Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]}");

// gå igenom listan = loopa igenom listan = från första till sista
foreach (var frukt in frukter)
{
    Console.WriteLine(frukt);
}


// skapar en lista av träd
List<string> träden = ["björk", "tall", "gran", "ek"];

// går igenom varje träd inom listan på samma rad
foreach (var träd in träden)
{
    Console.Write($"{träd} ");
}



for (int i = 0; i < träden.Count; i++)
{
    Console.Write($"{träden[i]}");
}


Console.Clear();


// Skapa ett register
// En tom lista
List<string> namnlista = [];

// while-loop
while (true)
{
    Console.Write("Ange ett namn: ");
    string namn = Console.ReadLine();
    namnlista.Add(namn);

    // skriv ut hela listan på en rad
    foreach (var allanamn in namnlista)
    {
        Console.Write($"{allanamn}, ");
    }
    Console.WriteLine();
}