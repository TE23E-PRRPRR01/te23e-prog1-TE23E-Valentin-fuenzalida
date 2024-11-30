Console.Clear();

Console.WriteLine("Detta program ska få reda på om användaren är gammal nog att delta i en tävling");

Console.WriteLine("Hur gammal är du? ");
int ålder = int.Parse(Console.ReadLine());


if (ålder >= 16 && ålder <= 19)
{
    Console.WriteLine("Du får vara med i tävlingen");
}
else if (ålder > 19)
{
    Console.WriteLine("Du är för gammal för att vara med i tävlingen");
}
else
{
    Console.WriteLine("Du är för ung för att vara med i tävlingen");
}