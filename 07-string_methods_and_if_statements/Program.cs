String fullName = "Eren Alp";
String phoneNumber = "123-456-7890";

fullName = fullName.ToUpper();
System.Console.WriteLine($"Your upper name: {fullName}");

fullName = fullName.ToLower();
System.Console.WriteLine($"Your lower name: {fullName}");

phoneNumber = phoneNumber.Replace("-","");
System.Console.WriteLine($"Your phone number: {phoneNumber}");

// 0 -> index number.
String userName = fullName.Insert(0,"@");
System.Console.WriteLine($"Your username: {userName}");

// 0 -> index number.
String userName2 = fullName.Insert(0,"Mr.");
System.Console.WriteLine($"Your username: {userName2}");

int name_lenght = fullName.Length;
System.Console.WriteLine($"Your name's lenght: {name_lenght}");

// Substring(x,y)  x -> start index. & y -> how many times to advance  
String firstName = fullName.Substring(0,4);
String lastName = fullName.Substring(5,3);
System.Console.WriteLine($"Your first name: {firstName} & last name: {lastName}");

// if basics

System.Console.WriteLine("Please enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

if (age > 100)
{
   System.Console.WriteLine("You are too old to sign up!");
}
else if (age >= 18){
  System.Console.WriteLine("You are now signed up!");
}
else if (age < 0){
  System.Console.WriteLine("You haven't been born yet!");
}
else{
  System.Console.WriteLine("You must be 18+ to sign up!");
}
Console.WriteLine("Please enter your name: ");
String? name = Console.ReadLine();

if(name != ""){
  System.Console.WriteLine("Hello "+name);
  
}
else{
  System.Console.WriteLine("You did't enter your game !");
}