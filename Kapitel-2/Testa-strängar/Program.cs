//skapa en variable som är min gmail
string email= "valentin.fuenzalidaribbing@elev.ga.ntig.se";
 

//Hitta positionen för @-tecknet! och extraherar domännamnet (elev.ga.ntig.se) med två argument
int position = email.IndexOf("@");
string domain = email.Substring(position + 1, email.Length - position - 1);
Console.WriteLine($"Domännamnet är: {domain}");

//extraherar domännamnet (elev.ga.ntig.se) med ett argument
domain = email.Substring(position + 1);
Console.WriteLine($"Domännamnet är: {domain}");