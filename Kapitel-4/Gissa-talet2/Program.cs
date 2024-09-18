// Det här programmet slumpar ett tal mellan 1 och 6
// och låter användaren gissa vilket tal som har slumpats
/*
Console.Clear();
Console.WriteLine("Program för att gissa ett tal mellan 1-100");

 Generera ett slumpmässigt heltal mellan 1 och 6
int slumptal = Random.Shared.Next(1, 101);

 En loop som fortsätter tills användaren gissar rätt
while (true)
{
     ställ fråga till advändaren
    Console.Write("Gissa ett tal (1-100): ");
    int gissning = int.Parse(Console.ReadLine());

     Kontrollera om användarens gissning matchar det slumpade talet
    if (gissning == slumptal)
    {
        Console.WriteLine("Rätt svar!");
        break; // Avbryter loopen om gissningen är korrekt
    }
    else if (gissning > slumptal)
    {
        Console.WriteLine("för högt");
    }
    else
    {
        Console.WriteLine("för lågt");
    }
}

Console.WriteLine("Tack för att du spelade!");
*/

using System.Runtime.Intrinsics.Arm;
using System.Xml.Schema;

Console.Clear();
Console.WriteLine("gissa ett tal mellan min och max som du väljer");

//Anger en ny varibler antal som är noll från början
int antal = 0;

//Ange minvärde
Console.WriteLine("Ange minivärde: ");
int min = int.Parse(Console.ReadLine());

//Ange maxvärde
Console.WriteLine("Ange maxvärde: ");
int max = int.Parse(Console.ReadLine());

//ger oss ett slumptalet mellan min och max värderna som advändarna sa
int slumptal = Random.Shared.Next(min, max + 1);

//en while loob som upprepar sig till advändaren gissar rätt tal
while (true)
{
    int gissning = 0;
    while (true)
    {
        //skriver vilka tal som advändaren kan gissa mellan
        Console.WriteLine($"gissa ett tall mellan {min} och {max}");
        gissning = int.Parse(Console.ReadLine());

        //säger om talen är mer eller mindre än maxvärdet och minvärdet
        if (gissning > max)
        {
            Console.WriteLine("gissa ett annat tal du får inte gissa detta tal");
        }
        else if (gissning < min)
        {
            Console.WriteLine("detta tal är inte med dina alternativ");
        }
        else
        {
            break;
        }
    }

    //säger att antal går upp med ett varje gissning
    antal++;

    //visar när advändare har gissat rätt och på hur många gånger
    if (gissning == slumptal)
    {
        Console.WriteLine($"Rätt svar på {antal} gånger");
        break;
    }

    //säger olika saker beroende på vad advändare gissar antingen för lågt eller för högt
    else if (gissning < slumptal)
    {
        Console.WriteLine("för lågt");
    }
    else
    {
        Console.WriteLine("för högt");
    }



    //frågar om advändaren vill gissa igen
    Console.Write("vill du gissa igen (j/n)");
    string svar = Console.ReadLine().ToLower();

    if (svar != "j")
    {
        break;
    }
}
