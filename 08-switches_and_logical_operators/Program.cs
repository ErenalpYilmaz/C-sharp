using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;

System.Console.WriteLine("What day is it today?");
String? day = Console.ReadLine();

switch (day)
{
  case "Monday":
  case "Tuesday":
  case "Wednesday":
  case "Thursday":
  case "Friday":
  case "Saturday":
  case "Sunday":
    System.Console.WriteLine($"It's {day}!");
    break;
  default:
    System.Console.WriteLine(day+" is not a day!");
    break;
}

//Logical Operators &&(and) - ||(or)
System.Console.WriteLine("What's the temperature outside: (C)");
double temp = Convert.ToDouble(Console.ReadLine());

if(temp >= 10 && temp <= 25){
  System.Console.WriteLine("It's warm outside!");
}
else if(temp <= -50 || temp >= 50){
  System.Console.WriteLine("DON'T GO OUTSIDE!!!");
}