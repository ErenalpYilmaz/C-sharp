/* Outputs */
using System.Runtime.InteropServices;

Console.Write("hi");
Console.WriteLine("Hello String Message");

// This is a comment.
/*
  This
  is
  a
  multiline
  comment
*/

Console.WriteLine("\tALP"); // \t -> Horizontal Tab
Console.WriteLine("============");
Console.WriteLine("EREN\bALP"); // \b -> backspace
Console.WriteLine("============");
Console.WriteLine("EREN\nALP"); // \n -> new line
Console.WriteLine("============");
Console.WriteLine("EREN\vALP"); // \v -> Vertical Tab
Console.WriteLine("============");
Console.WriteLine("EREN\rALP"); // \r -> Carriage return
Console.WriteLine("============");


// VARIABLES //

int x; // declaration
x = 123; // initialization

int y = 321; // declaration + initialization

int z = x + y;

int age = 21; // whole integer
System.Console.WriteLine($"Your age is {age}");

double height = 300.5; // decimal numbers
System.Console.WriteLine($"My hight is {height}cm");

bool alive = true; // true or false
System.Console.WriteLine($"Are u alive?\n -{alive}-");

char symbol = '@'; //  1 character  //using '@'. Don't try "@".
System.Console.WriteLine($"Your symbol is: {symbol}");

String name = "ALP";
System.Console.WriteLine($"Hello {name}");

String username = symbol+name;
System.Console.WriteLine($"Your username is: {username}");

Console.ReadKey();