Console.Clear();

Console.WriteLine("detta program ska fråga användaren om hur högt hen kan hoppa i höjdhopp");


Console.WriteLine("Hur högt kan du hoppa i höjhopp mätt i meter?");
string höjdText = Console.ReadLine();
double höjd = double.Parse(höjdText);
double skillnad = 2.45 - höjd;

Console.WriteLine("Världsrekordet är " + skillnad + " meter högre.");