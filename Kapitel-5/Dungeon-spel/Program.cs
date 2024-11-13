/* ************************************************************
**                          Main                             **
*************************************************************** */


Console.Clear();
Console.WriteLine("Välkomen till Dungeon-äventyret! Du är i ett mörkt rum.");

// Programvariabler 
string rum = "hallen"; // Starta i "hallen"
int liv = 3;  // Spelaren börjar med 3 liv

Console.WriteLine("Det finns 2 rum");
Console.WriteLine($"Du börjar med {liv} liv");

List<string> inventarie = []; // Lista för att lagra föremål


Console.WriteLine("Hej modiga spelare nu börjar din spännande äventyr inne i denna dungeon fortsätta utforksa för att klara av spelet");



// spel loop
while (true)
{
    Console.WriteLine($"Du är i {rum}");

    // VIsa alternativ vaserat på vilket rum spelaren är i
    if (rum == "hallen")
    {

        // Meny
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå till rum 1");
        Console.WriteLine("3. vila");
        Console.WriteLine("4. Leta efter gömda föremål");
        Console.WriteLine("Vad vill du göra?");
        string val = Console.ReadLine();

        if (val == "1")
        {
            Console.WriteLine("du tittar runt i rummet och ser mörka hörn");
        }
        else if (val == "2")
        {
            rum = "rum 1"; // FLytta till nästa rum
            Console.WriteLine("Du går vidare till nästa rum... ");

            Console.WriteLine("-------------------------------------");
        }
        else if (val == "3")
        {
            Console.WriteLine("Du vilar");
        }
        else if (val == "4")
        {
            Console.WriteLine("du tittar bakom förmål för att hitta nya saker");
        }
    }
    else if (rum == "rum 1")

        Console.WriteLine("Du hittar en magisk dryck! vill du plocka up den? (j/n)");
        string svar = Console.ReadLine(). ToLower();

        Console.WriteLine("------------------------------------------");

        if (svar == "j")
        {
            inventarie.Add("Magisk dryck");
            Console.WriteLine("Du har plockat upp en magisk dryck.");
        }

        Console.WriteLine($"Din inventarie: {string.Join(",", inventarie)}");

        Console.WriteLine("------------------------------------------");

        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå tillbaka till hallen");
        Console.WriteLine("3. Gå till nästa rum");
        Console.Write("Vad vill du göra? ");
        string val = Console.ReadLine();

        if (val == "1")
        {
            Console.WriteLine("Du hittar en gammal kista i hörnet");
        }
        else if (val == "2")
        {
            rum = "rum 1";
            Console.WriteLine("Du går tillbaka till rum 1...");
        }
}
