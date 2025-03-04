
double x = 3.14;
double y = 5;
double a = Math.Pow(x,2); // x ** 2
Console.WriteLine($"Your power : {a}"); 

double b = Math.Sqrt(9);
Console.WriteLine($" Your number : 9d and new number = {b}"); // Square root of number

double c = Math.Abs(x); // absolute value
System.Console.WriteLine(c);

double d = Math.Round(x); // Number round
Console.WriteLine(d);

double e = Math.Ceiling(x);// Ceiling number
Console.WriteLine(e);

double f = Math.Floor(x);// Floor number
System.Console.WriteLine(f);


double g = Math.Max(x,y);
Console.WriteLine(g);
double h = Math.Min(x,y);
Console.WriteLine(h);

Random random = new Random();
// Next(minNumber,maxNumber)
int num = random.Next(1,21);
Console.WriteLine($"Random number :{num}");

double doubleNum = random.NextDouble();
Console.WriteLine($"Random number :{doubleNum}");

Console.ReadKey();
