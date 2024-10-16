// en liten morsekod app
Console.Clear();
Console.WriteLine("En liten morsekod app");

// Två listor
List<string> alfabetet = [ "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", 
                        "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", 
                        "U", "V", "W", "X", "Y", "Z", "Å", "Ä", "Ö", " "];
List<string> morsekod = [ ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", 
            "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", 
            "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", 
            "-.--", "--..", ".--.-", ".-.-", "---.", "/" ];

// Läs in en text
Console.WriteLine("Ange ett meddelande: ");
string bokstav = Console.ReadLine();

// uppslag i alfabetet efter index
int index = alfabetet.IndexOf(bokstav);

Console.WriteLine($"{bokstav} finns på index {index}");

// Picka ut morsetecknet för detta index
string morsetecken = morsekod[index];
Console.WriteLine($"{bokstav} är {morsetecken}");
