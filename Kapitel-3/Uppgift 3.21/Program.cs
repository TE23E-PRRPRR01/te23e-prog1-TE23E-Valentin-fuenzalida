Console.Clear();

Console.WriteLine("Skapa ett program där användaren ska skriva in ett matematiskt uttryck innehållande ett eller två plustecken");


Console.WriteLine("Skriv in en addition på en rad, t.ex. \"4+5\" eller \"5+1+6,2\"");
string uttryck = Console.ReadLine();
int förstaPlus = uttryck.IndexOf("+");

// Ta reda på det första talet
string föreFörstaPlus = uttryck[..förstaPlus];
double förstaTalet = double.Parse(föreFörstaPlus);

string efterFörstaPlus = uttryck[(förstaPlus+1)..];

// Finns det två plustecken i uttrycket?
if (efterFörstaPlus.Contains("+"))
{
    int andraPlus = efterFörstaPlus.IndexOf("+");
    // Ta reda på det andra talet
    string mellanPlus = efterFörstaPlus[..andraPlus];
    double andraTalet = double.Parse(mellanPlus);

    // Ta reda på det tredje talet
    string efterAndraPlus = efterFörstaPlus[(andraPlus + 1)..];
    double tredjeTalet = double.Parse(efterAndraPlus);
    Console.WriteLine($"Uttryckets värde är {förstaTalet + andraTalet + tredjeTalet}");
}
else
{
    double andraTalet = double.Parse(efterFörstaPlus);
    Console.WriteLine($"Uttryckets värde är {förstaTalet + andraTalet}");
}
