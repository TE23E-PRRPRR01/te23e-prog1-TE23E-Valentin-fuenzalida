Console.Clear();

Console.WriteLine("Detta program är för att räkna ut en subration eller addition");

Console.WriteLine("skriv in en addition eller subration mellan två tal");
string räkning = Console.ReadLine();

if (räkning.Contains("+"))
{
    int plusteckenindex = räkning.IndexOf("+");
    double förstatal = double.Parse(räkning [..plusteckenindex]);
    double andratal = double.Parse(räkning[(plusteckenindex + 1)..]);

    double addition =  förstatal + andratal; 

    Console.WriteLine($"Additionen av de två talen är {addition}");
}
else if (räkning.Contains("-"))
{
    int minusteckenindex = räkning.IndexOf("-");
    double förstatal = double.Parse(räkning[..minusteckenindex]);
    double andratal = double.Parse(räkning[(minusteckenindex + 1)..]);

    double subration = förstatal - andratal;
    Console.WriteLine($"Subtration av de två talen är {subration}");
}
else
{
    Console.WriteLine("du måste välja antingen än addition eller en subration");
}

