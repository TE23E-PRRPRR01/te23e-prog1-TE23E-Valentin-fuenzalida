using System.Runtime.Intrinsics.Arm;

Console.Clear();

Console.WriteLine("Ceasar-krypto: Kryptera eller dekryptera ett meddelande.");
Console.WriteLine("1. Kryptera meddelande");
Console.WriteLine("2. Dekryptera meddelande");
Console.Write("Ange ditt val: ");
string val = Console.ReadLine();

// Om val 1
if (val == "1")
{
    //Kryptera meddelande 


    //för att kunna skriva med svenska bokstäver
    Console.InputEncoding = System.Text.Encoding.Unicode;
    Console.WriteLine("Ceasar-krypto: Kryptera ett ord");
    Console.WriteLine("Ange ett meddelande: ");
    // skapar en variabel för att kunna få svår från användaren
    string meddelande = Console.ReadLine().ToUpper();

    // skapa ett variabel för hela alfabetet
    string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";


    Console.WriteLine("Ange en nyckel (1-9): ");
    int nyckel = int.Parse(Console.ReadLine());

    string KrypteraMeddelande = "";
    // Loppa igenom varje bokstav i ordet
    foreach (char bokstav in meddelande)
    {
        int index = alfabet.IndexOf(bokstav);
        if (index != -1)
        {
            // lägg till nyckeln och använd modulus för att hantera omslag
            int nyposition = index + nyckel;

            // Kolla om nyPosition är utanför alfabetet och börjar isåfall om
            if (nyposition >= alfabet.Length)
            {
                nyposition -= alfabet.Length;
            }

            //plocka ut det nya teknet
            char krypteradBokstav = alfabet[nyposition];

            // lägger till det krypterade bokstaven till meddelandet
            KrypteraMeddelande += krypteradBokstav;
        }
        else
        {
            // Lämna tecken som inte finns i alfabetet oförändrad
            KrypteraMeddelande += bokstav;
        }
    }
    // skapa lite mellan rum mellan den nyckeln och den krypterade texten
    Console.WriteLine("-----------------------");

    Console.WriteLine($"Chiffertext: {KrypteraMeddelande}");

}

else if (val == "2")
{
    //Dekryptera meddelande
    Console.InputEncoding = System.Text.Encoding.Unicode;
    Console.WriteLine("Ceasar-krypto: Dekryptera ett meddelande");
    Console.WriteLine("Ange ett meddelande: ");
    string meddelandet = Console.ReadLine().ToLower();

    string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

    Console.WriteLine("Ange en nyckel: ");
    int nyckel = int.Parse(Console.ReadLine());

    string DekrypteradMeddelande = "";
    foreach(char bokstav in meddelandet)
    {
        int index = alfabet.IndexOf(bokstav);
    }
}
else
{
    Console.WriteLine("Ogiltigt val. Avslutar programmet.");
}