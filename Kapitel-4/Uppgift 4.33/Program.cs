Console.Clear();

Console.WriteLine("Skriv in ett ord");
string ord1 = Console.ReadLine();
Console.WriteLine("Skriv in ett till ord");
string ord2 = Console.ReadLine();

for (int i = 0; i < ord1.Length; i++)
{

    // Kolla om det är första gången vi stöter på tecknet som finns på ord1[i]
    // ord1[..i] är den del av ordet som finns innan tecknet på index i
    if (ord1[..i].Contains(ord1[i]))
    {
        // Tecknet finns tidigare i ordet, gå vidare till nästa tecken
        continue;
    }

    // Hur många gånger finns tecknet i ord1?
    int antalIOrd1 = 0;
    for (int j = 0; j < ord1.Length; j++)
    {
        if (ord1[i] == ord1[j])
        {
            antalIOrd1++;
        }
    }

    // Hur många gånger finns tecknet i ord2?
    int antalIOrd2 = 0;
    for (int j = 0; j < ord2.Length; j++)
    {
        if (ord1[i] == ord2[j])
        {
            antalIOrd2++;
        }
    }

    if (antalIOrd1 > antalIOrd2)
    {
        Console.Write(ord1[i]);
    }

}