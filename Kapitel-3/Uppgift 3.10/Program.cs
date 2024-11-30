Console.Clear();

Console.WriteLine("Detta progam ska berätta om du fick guld, silver, bronze eller ingen medalj i förhållande till användarens senaste idrottsturning");

Console.WriteLine("Vilken plays kom du på? ");
string plats = Console.ReadLine();

switch (plats)
{
    case "1":
        Console.WriteLine("Du fick guld!");
        break;
    case "2":
        Console.WriteLine("Du fick silver!");
        break;
    case "3":
        Console.WriteLine("Du fick bronze!");
        break;
    default:
        Console.WriteLine("Du fick ingen medalj");
        break;
}