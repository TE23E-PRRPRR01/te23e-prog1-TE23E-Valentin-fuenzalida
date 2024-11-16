Console.Clear();

Console.WriteLine("Detta program är för att fråga användaren om resemål och stad");

Console.WriteLine("Vilken stad kommer du ifrån: ");
string stad = Console.ReadLine();

Console.WriteLine("vilken är ditt drömresmål");
string drömresmål = Console.ReadLine();


Console.WriteLine($"Hej {stad}. Jag hoppas att du får resa till {drömresmål}.");