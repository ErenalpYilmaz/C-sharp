
using System.Net.WebSockets;

Console.Write("What's your name?:");
String? name = Console.ReadLine();

Console.Write("What's your age?:");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Hello {name}! You are {age} years old.");

// Arithmetic Operators

int friends = 5;

friends++;
Console.WriteLine(friends);
friends--;
Console.WriteLine(friends);
friends *= 5;
Console.WriteLine(friends);
friends /= 2;
Console.WriteLine(friends);

int remainder = friends % 5;
Console.WriteLine(remainder);

Console.ReadKey();