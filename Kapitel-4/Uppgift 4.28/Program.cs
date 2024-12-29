Console.Clear();

Console.WriteLine("Skriv in ett ord");
string Text = Console.ReadLine();
Console.WriteLine("Skriv in exact två tecken");
string Tecken = Console.ReadLine();

bool Förstatecknet = false;
bool Andratecknet = false;

for (int i = 0; i < Text.Length; i++)
{
    if (Text[i] == Tecken[0])
    {
        Förstatecknet = true;
    }
    if (Text[i] == Tecken[1])
    {
        Andratecknet = true;        
    }
}

if (Förstatecknet && Andratecknet)
{
    Console.WriteLine("den första texten innehåller både första och andra teckent");
}
else if (Förstatecknet || Andratecknet)
{
    Console.WriteLine("minst ett av tecknen finns i texten");
}
else
{
    Console.WriteLine("inga av de två tecknen finns i första texten");
}