
// constants = immutable values which are known at compile time and don't change for the life of the program
using System.Runtime.InteropServices;

const double pi = 3.14159; 
Console.WriteLine(pi);


// TYPE CASDING = Converting a value to a different data type 
// Useful when we accept user input (string)
// Different data types can do different things

// int to double
double a = 3.14;
int b = Convert.ToInt32(a);

Console.WriteLine(b.GetType());

// double to int
int c = 123;
double d = Convert.ToDouble(c)+0.1;

System.Console.WriteLine(d);
System.Console.WriteLine(d.GetType());

// int to string
int e = 321;
String number = Convert.ToString(e);

System.Console.WriteLine(number);
System.Console.WriteLine(number.GetType());

// string to char
String g = "$";
char h = Convert.ToChar(g);

System.Console.WriteLine(h);
System.Console.WriteLine(h.GetType());

// string to bool
String i = "true";
bool j = Convert.ToBoolean(i);

System.Console.WriteLine(j);
System.Console.WriteLine(j.GetType());

Console.ReadKey();