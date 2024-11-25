Console.Clear();

Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

// skapa en tom lista av strängar
List<string> listanamn = ["Anna", "Björn", "Cecilla"];

// skriv ut listan
Console.WriteLine("Nuvarande Lista: " + string.Join(", ", listanamn));


Console.WriteLine("skriv ett namn");
string namn = Console.ReadLine();

listanamn.Add(namn);

// skriv ut den nya listan
Console.WriteLine("Listan efter tillägg: " + string.Join(", ", listanamn));

Console.WriteLine("Skriv in ett namn du vill ta bort: ");
string namntabort = Console.ReadLine();

if (listanamn.Contains(namntabort))
{
    listanamn.Remove(namntabort);
    Console.WriteLine("Listan efter borttagning: " + string.Join(", ", listanamn));
}   
else
{
    Console.WriteLine($"Fel: {namntabort} finns inte i listan.");
}

Console.WriteLine("Skriv in ett namn som du vill söka i listan: ");
string sökanamn = Console.ReadLine();


if (listanamn.Contains(sökanamn))
{
    Console.WriteLine($"{sökanamn} finns i listan.");
}
else
{
    Console.WriteLine($"{sökanamn} finns inte i listan.");
}

Console.WriteLine("Vill du sortera listan? (j/n): ");
string svar = Console.ReadLine();

if (svar == "j")
{
    listanamn.Sort();
    Console.WriteLine($"Listan sorterad i alfabetisk ordning: {string.Join(", ", listanamn)}");
}