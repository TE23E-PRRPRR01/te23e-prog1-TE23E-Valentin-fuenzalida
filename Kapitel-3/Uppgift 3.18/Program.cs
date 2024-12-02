Console.Clear();

Console.WriteLine("Detta program ska se om ditt förnamn kommer före i bokstavsordning än ditt efternamn");

Console.WriteLine("Skriv in ditt förnamn och ditt efternamn? ");
string namn = Console.ReadLine();

// delar upp båda orden från en variabel till två variabler
int mellanslagindex = namn.IndexOf(" ");
string förnamn = namn[..mellanslagindex];
string efternamn = namn[(mellanslagindex + 1)..];


// listar ut om förnamnet eller efternamnet är före i bokstavsordning
if (förnamn.CompareTo(efternamn) < 0)
{
    Console.WriteLine("Ditt förnamn kommer före ditt efternamn i bokstavsordning");
}
else if (förnamn.CompareTo(efternamn) > 0)
{
    Console.WriteLine("Ditt efternamn kommer före ditt förnamn i bokstavsordning");   
}
else
{
    Console.WriteLine("Du har samma förnamn och efternamn");
}
{
    
}

