// Console.Clear();

Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

// // 1. skapa en lista på frukter
// List<string> listaNamn = ["Eliot", "Linnea", "Angela", "Isabella", "Edvin"];
// Console.WriteLine($"Min kompisar är: {string.Join(", ", listaNamn)}");


// // 2. skapa en lista på orter
// List<string> listaOrter = ["Stockholm", "Göteborg", "Malmö", "Uppsala", "Lund"];
// Console.WriteLine($"Fem orter: {string.Join(", ", listaOrter)}");


// // 3. skapa en lista på frukter
// List<int> listaÅrtal = [1492, 1776, 1914, 1945, 1969];
// Console.WriteLine($"Fem viktiga årtal: '{string.Join("', '", listaÅrtal)}'");

// // 4. Visa första och sista objektet i en lista
// Console.WriteLine("Första namnet: " + listaNamn[0]);
// Console.WriteLine("Sista namnet: " + listaNamn[4]);


// // 5. skapa en lista med 5 favotirdrycker och skriv ut en per rad
// List<string> listadryck = ["Kaffe", "Te", "Cola", "Juice", "Vatten"];

// for (int i = 0; i < listadryck.Count; i++)
// {
//     Console.WriteLine($"{i+ 1}. {listadryck[i]}");
// }


// // skapa en lista med födelseår för 5 personer
// List<int> födelseÅr = [2000, 1995, 1990, 1985, 1980];

// for (int i = 0; i < födelseÅr.Count; i++)
// {
//     Console.WriteLine($"{i+ 1}. {födelseÅr[i]}");
// }



















































































// Console.Clear();

// // skapa en tom lista av strängar
// List<string> listanamn = ["Anna", "Björn", "Cecilla"];

// // skriv ut listan
// Console.WriteLine("Nuvarande Lista: " + string.Join(", ", listanamn));


// Console.WriteLine("skriv ett namn");
// string namn = Console.ReadLine();

// listanamn.Add(namn);

// // skriv ut den nya listan
// Console.WriteLine("Listan efter tillägg: " + string.Join(", ", listanamn));

// Console.WriteLine("Skriv in ett namn du vill ta bort: ");
// string namntabort = Console.ReadLine();

// if (listanamn.Contains(namntabort))
// {
//     listanamn.Remove(namntabort);
//     Console.WriteLine("Listan efter borttagning: " + string.Join(", ", listanamn));
// }   
// else
// {
//     Console.WriteLine($"Fel: {namntabort} finns inte i listan.");
// }

// Console.WriteLine("Skriv in ett namn som du vill söka i listan: ");
// string sökanamn = Console.ReadLine();


// if (listanamn.Contains(sökanamn))
// {
//     Console.WriteLine($"{sökanamn} finns i listan.");
// }
// else
// {
//     Console.WriteLine($"{sökanamn} finns inte i listan.");
// }

// Console.WriteLine("Vill du sortera listan? (j/n): ");
// string svar = Console.ReadLine();

// if (svar == "j")
// {
//     listanamn.Sort();
//     Console.WriteLine($"Listan sorterad i alfabetisk ordning: {string.Join(", ", listanamn)}");
// }

































































































































































































































Console.Clear();

Console.WriteLine("I denna övning ska du träna på att använda listor för att lagra, lägga till, ta bort och visa data. Du kommer också att hantera användarens inmatning för att arbeta med listan.");

List<string> maträtter = ["Pizza", "Pasta", "Sallad"];

foreach (var rätter in maträtter)
{
    Console.WriteLine($"- {rätter}");
}

Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

List<int> årtal = [1492, 1776, 1914, 1945, 1969];


Console.Write("alla årtal");
foreach (var år in årtal)
{
    Console.Write($" {år},");
}

Console.WriteLine();

Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

List<string> namnlista = [];

while (true)
{
    Console.WriteLine("Ange ett namn att lägga till (eller 'exit' för att avsluta): ");
    string namn3 = Console.ReadLine();
    if (namn3 == "exit")
    {
        break;
    }
    namnlista.Add(namn3);
}

Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");


List<int> årtallista = [];

while (true)
{
    Console.WriteLine("Ange ett årtal att lägga till (eller '0' för att avsluta): ");
    int fleraårtal = int.Parse(Console.ReadLine());
    if (fleraårtal == 0)
    {
        break;
    }
    årtallista.Add(fleraårtal);
}

Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

// skapa en lista med 3 namn
List<string> ValentínEdvinElliot = ["Valentín", "Edvin", "Elliot"];

for (int i = 0; i < ValentínEdvinElliot.Count; i++)
{
    Console.WriteLine($"{i + 1}. {ValentínEdvinElliot[i]}");
}

Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");


// skapa en lista med städer
List<string> ListaStäder = ["Göteborg", "Malmö", "Stockholm", "Uppsala", "Örebro"];

while (true)
{
    for (int i = 0; i < ListaStäder.Count; i++)
    {
        Console.WriteLine($"{i}. {ListaStäder[i]}");
    }

    Console.WriteLine("Vilken stad vill du besöka (0-4)? ");
    int stad = int.Parse(Console.ReadLine().ToLower());

    if (stad == 0)
    {
        Console.WriteLine($"Du valde att besöka {ListaStäder[0]}");
        break;
    }
    else if (stad == 1)
    {
        Console.WriteLine($"Du valde att besöka {ListaStäder[1]}");
        break;
    }
    else if (stad == 2)
    {
        Console.WriteLine($"Du valde att besöka {ListaStäder[2]}");
        break;
    }
    else if (stad == 3)
    {
        Console.WriteLine($"Du valde att besöka {ListaStäder[3]}");
        break;
    }
    else if (stad == 4)
    {
        Console.WriteLine($"Du valde att besöka {ListaStäder[4]}");
        break;
    }
    else
    {
        Console.WriteLine("Fel: Ange ett index mellan 0 och 4.");
    }
}

Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

// skapa en lista med 3 namn
List<string> trenamnlista = ["Valentin", "Edvin", "Elliot"];

for (int i = 0; i < trenamnlista.Count; i++)
{
    Console.WriteLine($"{i + 1}. {trenamnlista[i]}");
}

// lägga till två namn som användaren väljer
Console.WriteLine("Skriv in ett namn du vill lägga till? ");
string läggtillnamn = Console.ReadLine();
trenamnlista.Add(läggtillnamn);

Console.WriteLine("Skriv in ett namn du vill lägga till? ");
string läggtillnamn2 = Console.ReadLine();
trenamnlista.Add(läggtillnamn2);

// låter användaren söka efter ett namn och säger till om namnet finns i listan eller inte
Console.WriteLine("Ange ett namn att söka efter: ");
string sökaefternamn = Console.ReadLine();

if (trenamnlista.Contains(sökaefternamn))
{
    Console.WriteLine($"{sökaefternamn} finns i listan.");
}
else
{
    Console.WriteLine($"{sökaefternamn} finns inte i listan.");
}

Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

// Skapa en lista på fem namn
List<string> listanamn = ["Anna", "Linnea", "Elliot", "Edvin", "Isabella"];

// visa ett namn som börjar på användarens val bokstav
Console.WriteLine("Ange en bokstav");
char bokstav = char.Parse(Console.ReadLine().ToLower());
foreach (string namn1 in listanamn)
{
    if (namn1.StartsWith(bokstav))
    {
        Console.WriteLine(namn1);
    }
}

Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");


List<string> namnlista2 = [];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ange ett namn");
    string läggatillnamn3 = Console.ReadLine();
    namnlista2.Add(läggatillnamn3);
    Console.WriteLine($"Nuvarande lista: {string.Join(", ", namnlista2)}");
}

Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");


List<string> namn = ["Linnea", "Angela", "Isabella", "Anna", "Sofia"];

for (int i = 0; i < namn.Count; i++)
{
    Console.WriteLine($"Nuvarande lista: {string.Join(", ", namn)}");
}

Console.WriteLine("Ange ett namn du vill ta bort");
string namnatttabort = Console.ReadLine();


if (namn.Contains(namnatttabort))
{
    namn.Remove(namnatttabort);

    for (int i = 0; i < namn.Count; i++)
    {
        Console.WriteLine($"Nuvarande lista: {string.Join(", ", namn)}");
    }
}
else
{
    Console.WriteLine("Fel: {namntabort} finns inte i listan.");
}




Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");


// Exempelmeny
List<string> lista = [];
int val = 0;
while (val != 4)
{

    Console.WriteLine("1. Lägg till namn\n2. Ta bort namn\n3. Visa lista\n4. Avsluta");
    val = int.Parse(Console.ReadLine());
    if (val == 1)
    {
        lista.Add("Anna"); // Simulerad inmatning
    }
    else if (val == 2 && lista.Count > 0)
    {
        lista.RemoveAt(0); // Tar bort första objektet
    }
    else if (val == 3)
    {
        Console.WriteLine(string.Join(", ", lista));
    }
}