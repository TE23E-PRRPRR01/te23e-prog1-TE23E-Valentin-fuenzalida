Console.Clear();

Console.WriteLine("Detta program ska få reda på om du har namnsdag idag, imorgon eller varken imorgon eller idag");

Console.WriteLine("Vad heter du? ");
string namn = Console.ReadLine();

if (namn == "Stig".ToLower())
{
    Console.WriteLine("Du har din namnasta idag, gratis");
}
else if (namn == "Abraham".ToLower())
{
    Console.WriteLine("DU har din namnasta imorgon, gratis i förskott");
}
else
{
    Console.WriteLine("Du har varken din namnsta varken imorgon eller idag");
}