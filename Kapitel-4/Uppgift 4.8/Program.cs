Console.Clear();

Console.WriteLine("skriv in ett tal");
string text = Console.ReadLine();

// skapar en variabler som har startvärdet som falskt
bool Innehåller7 = false;

// går igeonom varje tal om den innehåller antingen en 7 eller en 3
for (int i = 0; i < text.Length; i++)
{
    // omvandlar hela strängen till enskilda strängar
    string teckenstring = text [i].ToString();
    // omvandlar varje enkild sträng till ett tal
    int tal = int.Parse(teckenstring);
    // repeterar igenom varje tal för att se om den ineehåller antingen en 7 eller en 3
    if (text[i] == '3' || text[i] == '7')
    {
        Innehåller7 = true;
    }
}

if (Innehåller7)
{
    Console.WriteLine("ditt tal innehöll åtminstone minst en 7:a eller en 3:a");
}
else
{
    Console.WriteLine("ditt tal innehöll varken en 7 eller en 3");
}