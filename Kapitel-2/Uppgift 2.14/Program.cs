Console.Clear();

Console.WriteLine("Detta program ska beräkna svaret av två decimal tal");


Console.WriteLine("ange en beräkning t.ex 2,6*5,6");
string beräkning = Console.ReadLine();

int gångerindex = beräkning.IndexOf("*");

string tal1Text = beräkning[..gångerindex];
string tal2Text = beräkning[(gångerindex + 1)..];

double tal1 = double.Parse(tal1Text);
double tal2 = double.Parse(tal2Text);
double produkt = tal1 * tal2;


Console.WriteLine(beräkning + " = " + produkt);