//skapa en variable som är min gmail
string email= "valentin.fuenzalidaribbing@elev.ga.ntig.se";

// Dela upp strängen vid @-tecknet
string[] parts = email.Split('@');
Console.WriteLine($"Användernamn: {parts [0]}");
Console.WriteLine($"Användernamn: {parts [1]}");