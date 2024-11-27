Console.Clear();

Console.WriteLine("detta program är där användaren får skriva in en valfri sträng. Programmet ska sedan berätta ifall strängen innehåller...");

Console.WriteLine("Skriv in en valfri text");
string sträng = Console.ReadLine();


if (sträng.Contains("+") && sträng.Contains("-"))
{
Console.WriteLine("strängen innehåller både ett plustecken och ett minustecken");
}
else if (sträng.Contains("-"))
{
    Console.WriteLine("strängen innehåller ett minustecken");
}
else if (sträng.Contains("+"))
{
    Console.WriteLine("strängen innehållet ett plustecken");
}
else
{
    Console.WriteLine("strängen innehåller varken ett plustecken eller ett minustecken");   
}