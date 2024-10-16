// en liten morsekod app
Console.Clear();
Console.WriteLine("En liten morsekod app");

// För att kunna skriva svenska tecken
Console.InputEncoding = System.Text.Encoding.Unicode; 

// Två listor
List<string> alfabetet = [ "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
                        "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
                        "U", "V", "W", "X", "Y", "Z", "Å", "Ä", "Ö", " ",
                        "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"];
List<string> morsekod = [ ".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
            "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.",
            "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-",
            "-.--", "--..", ".--.-", ".-.-", "---.", "/", ".---", "..---", 
            "...--", "....-", ".....", "-....", "--...", "---..", "----.", "-----"  ];

List<string> siffror = [];

// Läs in en text
Console.Write("Ange ett meddelande: ");
string meddelande = Console.ReadLine();

// gå igenom meddelandet bokstav för bokstav (loop)
foreach (char bokstav in meddelande)
{
    // uppslag i alfabetet efter index
    int index = alfabetet.IndexOf(bokstav.ToString());

    // hitta morsetecken (A-Ö)?
    if (index >= 0)
    {


        // Picka ut morsetecknet för detta index
        string morsetecken = morsekod[index];
        Console.Write($"{morsetecken} ");

        // spela upp morse som ljud-beep
        // Tex D = "-.."
        // Dvs loppa igenom morsetecknet
        foreach (char signal in morsetecken)
        {
            if (signal == '.') // '.'
            {
                // 1000Hz, 200ms
                Console.Beep(1000, 100);
            }
            else // '-'
            {
                // 1000Hz, 600ms
                Console.Beep(1000, 300);
            }
        }

        // paus i koden
        Thread.Sleep(TimeSpan.FromSeconds(0.5));

    }
    else
    {
        Console.WriteLine("?");
    }

}


