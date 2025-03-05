
Console.Write("1st side of the triangle: ");
double edge1 = Convert.ToDouble(Console.ReadLine());
Console.Write("2st side of the triangle: ");
double edge2 = Convert.ToDouble(Console.ReadLine());

double hypotenuse = Math.Sqrt((edge1*edge1)+(edge2*edge2));

System.Console.WriteLine($"The hypotenuse is: {hypotenuse}");