Console.Clear();

string meddelande = "Hej! Är 3,14 ett heltal? Tack, för att du, läste meddelandet.";

for (int i = 0; i < meddelande.Length; i++)
{
    
    Console.Write(meddelande[i]);

    if (meddelande[i] == '.' && meddelande[i] == ',' && meddelande[i] == '?' && meddelande[i] == '!')
    {
        Thread.Sleep(1000);
    }
    else
    {
        Thread.Sleep(100);
    }
}