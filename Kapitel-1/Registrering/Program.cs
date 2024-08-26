//program för att registrera förnamn och efternamn
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("program för att registrera förnamn och efternamn");
Console.WriteLine("ange förnamn");
String förnamn = Console.ReadLine();
Console.WriteLine("ange efternamn");
String efternamn = Console.ReadLine();
Console.WriteLine("Hej " + förnamn + " " + efternamn);
Console.WriteLine($"Hej {förnamn} {efternamn}");

// är det Valentin som loggar in?
if (förnamn == "Valentin")
{
    Console.WriteLine("Vad trevligt att du är tillbaka");
}

// är det Valentin fuenzalida som loggar in?

if (efternamn == "Fuenzalida")
{
    Console.WriteLine("Vad trevligt att du är tillbaka");
}