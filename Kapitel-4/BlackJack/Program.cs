Console.Clear();


Console.WriteLine("Spelet BlackJack");

// Kortens värde är 
// 2-10 = 2-10
// Knekt, Dam, Kung = 10
// Ess = 1 (eller 11)
// @todo slump  måste efterlinka riktig kortlek, dvs 4x1, 4x2 ... 4xkung

List<string> kortlek = ["Ess", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Knekt", "Dam", "Kung"];
List<int> värde = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13];
int antalkort = 13;


while (true)
{

    // Variabler
    int summaSpelare = 0;
    int summaDatorn = 0;
    string kort;

    // Dela ut 2 kort till spelare
    int index = Random.Shared.Next(0, kortlek.Count);
    kort = kortlek[index];
    summaSpelare += värde[index];
    Console.WriteLine($"Du drog kortet {kort}");
    antalkort--;
    // Dela ut 2 kort till datorn
    index = Random.Shared.Next(0, kortlek.Count);
    kort = kortlek[index];
    summaDatorn += värde[index];
    Console.WriteLine($"Datorn drog kortet {kort}");
    antalkort--;


    // Flera gånger (loop)
    while (true)
    {
        // skriv ut summorna
        Console.WriteLine($"du har {summaSpelare} poäng");
        Console.WriteLine($"Datorn har {summaDatorn} poäng");

        // Stanna eller dra ett kort?
        Console.WriteLine("vill du ha ett nytt kort? (j/n)");
        string svar = Console.ReadLine().ToLower();
        if (svar == "n")
        {
            // Vill datorn ta ett extra kort <= 17
            while (summaDatorn < 17)
            {
                index = Random.Shared.Next(0, kortlek.Count);
                kort = kortlek[index];
                summaDatorn += värde[index];
                Console.WriteLine($"datorn drog kortet {kort}");
                antalkort--;
            }


            // vem har vunnit?
            // den har närmast 21 har vunnit
            if (summaSpelare > summaDatorn && summaSpelare < 21)
            {
                Console.WriteLine("Du har vunnit");
            }
            else


            {
                Console.WriteLine("Datorn har vunnit");
            }
            break;
        }

        // Ta ett extra kort
        index = Random.Shared.Next(0, kortlek.Count);
        kort = kortlek[index];
        summaSpelare += värde[index];
        Console.WriteLine($"Du drog kortet {kort}");
        antalkort--;

        // Datorn får ett nytt kort
        index = Random.Shared.Next(0, kortlek.Count);
        kort = kortlek[index];
        summaDatorn += värde[index];
        Console.WriteLine($"Datorn drog kortet {kort}");
        antalkort--;

        // om datrorn får 21 har datorn vunnit
        if (summaDatorn == 21)
        {
            Console.WriteLine("Datorn har vunnit");
            break;
        }

        // om spelaren får 21 har spelaren vunnit
        if (summaSpelare == 21)
        {
            Console.WriteLine("Du har vunnit");
            break;
        }
        // Är spelaren tjock
        if (summaSpelare > 21)
        {
            Console.WriteLine("Du har förlorat");
            break;
        }
        // Är datorn tjock
        if (summaDatorn > 21)
        {
            Console.WriteLine("Du har vunnit");
            break;
        }


        // Vem har vunnit
    }
    Console.WriteLine("vill du spela igen (ja/nej)");
    if (Console.ReadLine().ToLower() == "nej") break;
}