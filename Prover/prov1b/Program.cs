using System.Net.Http.Headers;
using System.Net.WebSockets;

Console.Clear();

Console.WriteLine(@"Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten.
Marginalskatten räknas ut baserat på din bruttolön.
Med bruttolön avses din årslön före skatt.");

Console.WriteLine("vad heter du? ");
string namn = Console.ReadLine();

// program-loop
while (true)
{
    Console.WriteLine("Ange din bruttolön i kronor: ");
    int bruttolön = int.Parse(Console.ReadLine());

    if (bruttolön < 10000 || bruttolön > 1000000)
    {
        Console.WriteLine($"{namn}, Bruttolön måste vara mellan 10000:- och 1000000:-");
    }

    else
    {
        int skattesatsen = 0;
        if (bruttolön >= 10000 && bruttolön < 145000)
        {
            skattesatsen = 22;
        }

        if (bruttolön >= 145000 && bruttolön < 515000)
        {
            skattesatsen = 33;
        }
        if (bruttolön >= 515000)
        {
            skattesatsen = 53;
        }

        int nettolön = bruttolön * (100 - skattesatsen) / 100;

        Console.WriteLine($"Din nettolön blir {nettolön} kr. Uträkningen baserad på bruttolön {bruttolön} kr och marginalskatten {skattesatsen}%");

        Console.WriteLine("vill du göra en ny beräkning (j/n) ");
        string svar = Console.ReadLine().ToLower().Trim();
        if (svar != "j")
        {
            break;
        }
    }
}