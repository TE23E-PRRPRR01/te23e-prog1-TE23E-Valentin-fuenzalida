Console.Clear();
Console.WriteLine("Ett program för att skriva in fil");


int val = 0;



while (val != 3)
{
    Console.WriteLine(@"
    
    Välj ett av följande alternativ
    1) skriv till fil
    2) läs från fil
    3) avsluta programmet");

     val = int.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (val)
    {
        case 1:
            Console.WriteLine("Skriv in Nytext");
            string Nytext = Console.ReadLine(); 
            File.AppendAllText("Textfile.txt",Nytext + Environment.NewLine);
            break;

        case 2:
            string text = File.ReadAllText("Textfile.txt");
            Console.WriteLine($"{text}");
            break;

        case 3:
            Console.WriteLine("Tack för idag");
            break;


        default:
        break;
    }
}