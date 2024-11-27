Console.Clear();

Console.WriteLine("Detta program är en frågesport däremot får användaren välja en katagori");

Console.WriteLine(@"
Välj en frågekategori.
1. Musik
2. Geografi
3. Historia
");
string katagori = Console.ReadLine();
string rättsvar = "";
switch (katagori)
{
    case "1":
    Console.WriteLine("Vad heter artisten till sången Arcade");
    rättsvar = "Duncan Laurence";
    break;
    case "2":
    Console.WriteLine("Vilken huvudstad har Tyskland");
    rättsvar = "Berlin";
    break;
    default:
    Console.WriteLine("Mellan vilka år hände andra världskriget");
    rättsvar = "1939-1945";
    break;
}

// läser in användarens svar
string svar = Console.ReadLine().ToLower();

if (svar == rättsvar)
{
    Console.WriteLine("Du hade rätt!");
}
else
{
    Console.WriteLine("Du hade fel!");
}