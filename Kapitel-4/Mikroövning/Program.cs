// Console.Clear();

// Console.WriteLine("mikroövning");

// int resultat = 0;

// while (true)
// {

//         Console.WriteLine("Hur många repititioner vill du ha");
//         bool lyckad = int.TryParse(Console.ReadLine(), out resultat);

//     if (resultat > 0 && resultat < 11)
//     {
//         List<string> listanamn = ["Valentin"];

//         for (int i = 0; i < resultat; i++)
//         {
//             Console.WriteLine($"{i + 1}. {listanamn[0]}");
//         }

//         break;
//     }

//     else
//     {
//         Console.WriteLine("repitioner måste vara mellan intervallet 1 till 10!!");
//     }

// }

// double a = 0;

// Console.WriteLine("ange ett tal in ett tal: ");
// bool lyckats = double.TryParse(Console.ReadLine(), out a);

// double M = a * 2;
// double D = a / 2;
// double A = a + 2;
// double S = a - 2;

// Console.WriteLine("Multiplicerat med 2: " + M);
// Console.WriteLine("Dividerat med 2: " + D);
// Console.WriteLine("Adderat med 2: " + A);
// Console.WriteLine("Subtraherat med 2: " + S);

































// Console.Clear();




// Console.WriteLine("Ange ett startvärde: ");
// int startvärde = int.Parse(Console.ReadLine());

// Console.WriteLine("Ange ett slutvärde: ");
// int slutvärde = int.Parse(Console.ReadLine());

// Console.Clear();

// int summan = 0;

// for (int i = startvärde; i < slutvärde; i++)
// {
//     summan = summan + (i);
// }

// Console.WriteLine($"Summan av siffrorna {startvärde} till {slutvärde} är: {summan}");

// Console.WriteLine("--------------------------------------------");

// Console.WriteLine("Jämna siffror: ");
// for (int i = 0; i < 20; i++)
// {
//     if (i % 2 == 0) Console.WriteLine(i + ",");
// }

// Console.WriteLine("--------------------------------------------");

// Console.WriteLine("Udda tal: ");
// for (int i = 0; i < 20; i++)
// {
//     if (i % 2 != 0) Console.WriteLine(i + ",");
// }

// Console.WriteLine("--------------------------------------------");

// Console.WriteLine("Ange ett tal: ");
// int multiplikationstabellen = int.Parse(Console.ReadLine());

// for (int i = 1; i < 11; i++)
// {
//     Console.WriteLine($"{multiplikationstabellen} x {i} = {multiplikationstabellen * i}");
// }


// Console.WriteLine("--------------------------------------------");

Console.Clear();

Console.Clear();
Console.Write("Höjd: ");
int höjd = int.Parse(Console.ReadLine());

for (int i = 1; i <= höjd; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();

    for (int j = 2; j <= i; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}