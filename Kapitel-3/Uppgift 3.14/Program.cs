Console.Clear();

Console.WriteLine("Detta program ska bestämma om ett företag vill anställa användaren");

Console.WriteLine("Har du går ut gymnasiet? (Svara med j/n)");
string Svar = Console.ReadLine();


Console.WriteLine("Hur gammal är du? ");
int ålder = int.Parse(Console.ReadLine());

if (Svar == "j" && ålder < 22)
{
    Console.WriteLine("Vi vill gärna anställa dig");
}
else
{
    Console.WriteLine("Vi letar tyvärr efter annan personal just nu");
}