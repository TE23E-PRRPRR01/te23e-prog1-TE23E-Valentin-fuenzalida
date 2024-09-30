Console.Clear();

// Här skapas en tom lista
List<string> länder = [];

// så här fyller vi listan med värden
länder.Add("Sverige");
länder.Add("Norge");
länder.Add("danmark");

// skriv ut alla länder
Console.WriteLine($"du har registrerat länderna {länder[0]}, {länder[1]} och {länder[2]}");

// innehållet i listan
List<string> länder1 = ["Sverige", "Norge", "Danmark"];
Console.WriteLine($"du har registrerat länderna {länder[0]}, {länder[1]} och {länder[2]}");


// innehållet i listan
Console.WriteLine($"Tre länder i Europa: {länder[0]}, {länder[1]} och {länder[2]}");

// Här skapar vi en lista på 3 heltal, vilket är ett exempel på en lista som innehåller årtal
List<int> årtal = [1990, 2000, 2010];

// här skriver vi ut innehållet i listan
Console.WriteLine($"Tre årtal: {årtal[0]}, {årtal[1]} och {årtal[2]}");


