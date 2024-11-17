using System.Runtime.Intrinsics.Arm;

Console.Clear();

Console.WriteLine("Detta program ska säga hur många år det är kvar tills 2100");

Console.WriteLine("Vilket år är det idag");
int a = int.Parse(Console.ReadLine());

int årkvar = 2100 - a;

Console.WriteLine("Det är: " + årkvar + " år kvar tills 2100");