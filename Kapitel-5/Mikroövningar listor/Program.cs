Console.Clear();

Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

// 1. skapa en lista på frukter
List<string> listaNamn = ["Eliot", "Linnea", "Angela", "Isabella", "Edvin"];
Console.WriteLine($"Min kompisar är: {string.Join(", ", listaNamn)}");


// 2. skapa en lista på orter
List<string> listaOrter = ["Stockholm", "Göteborg", "Malmö", "Uppsala", "Lund"];
Console.WriteLine($"Fem orter: {string.Join(", ", listaOrter)}");


// 3. skapa en lista på frukter
List<int> listaÅrtal = [1492, 1776, 1914, 1945, 1969];
Console.WriteLine($"Fem viktiga årtal: '{string.Join("', '", listaÅrtal)}'");

// 4. Visa första och sista objektet i en lista
Console.WriteLine("Första namnet: " + listaNamn[0]);
Console.WriteLine("Sista namnet: " + listaNamn[4]);


// 5. skapa en lista med 5 favotirdrycker och skriv ut en per rad
List<string> listadryck = ["Kaffe", "Te", "Cola", "Juice", "Vatten"];

for (int i = 0; i < listadryck.Count; i++)
{
    Console.WriteLine($"{i+ 1}. {listadryck[i]}");
}


// skapa en lista med födelseår för 5 personer
List<int> födelseÅr = [2000, 1995, 1990, 1985, 1980];

for (int i = 0; i < födelseÅr.Count; i++)
{
    Console.WriteLine($"{i+ 1}. {födelseÅr[i]}");
}


















































































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