Console.Clear();


Console.WriteLine("Spelet BlackJack");

// Kortens värde är 
// 2-10 = 2-10
// Knekt, Dam, Kung = 10
// Ess = 1 (eller 11)
// @todo slump  måste efterlinka riktig kortlek, dvs 4x1, 4x2 ... 4xkung
while (true)
{

    // Variabler
    int summaSpelare = 0;
    int summaDatorn = 0;
    int kort = 0;

    // Dela ut 2 kort till spelare
    kort = Random.Shared.Next(1, 11); // @todo Knekt, Dam och Kung?
    summaSpelare += kort;
    kort = Random.Shared.Next(1, 11); // @todo Knekt, Dam och Kung?
    summaSpelare += kort;
    // Dela ut 2 kort till datorn
    kort = Random.Shared.Next(1, 11); // @todo Knekt, Dam och Kung?
    summaDatorn += kort;
    kort = Random.Shared.Next(1, 11); // @todo Knekt, Dam och Kung?
    summaDatorn += kort;


    // Flera gånger (loop)
    while (true)
    {
        // skriv ut summorna
        Console.WriteLine($"du har {summaSpelare} poäng");
        Console.WriteLine($"Datorn har {summaDatorn} poäng");

        // Stanna eller dra ett kort?
        Console.Write("vill du ha ett nytt kort? (j/n)");
        string svar = Console.ReadLine().ToLower();
        if (svar == "n")
        {
            // Vill datorn ta ett extra kort <= 17
            while (summaDatorn < 17)
            {
                kort = Random.Shared.Next(1, 11); // @todo Knekt, Dam och Kung?
                summaDatorn += kort; 
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
        kort = Random.Shared.Next(1, 11); // @todo Knekt, Dam och Kung?
        summaSpelare += kort;
        // Skriv ut kortet
        Console.WriteLine($"Du fick {kort}");

        // Datorn får ett nytt kort
        kort = Random.Shared.Next(1, 11); // @todo Knekt, Dam och Kung?
        summaDatorn += kort;
        // Skriv ut kortet
        Console.WriteLine($"Datorn fick {kort}");

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