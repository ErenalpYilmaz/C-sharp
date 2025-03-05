
// While loop = repeats some code while some dondition remains true

String? name = "";

while(name == ""){
  System.Console.WriteLine("Enter your name:");
  name = Console.ReadLine();
}
System.Console.WriteLine("Hello "+name);

// for loop = repeats some code a FINITE amount of times
for(int i = 0;i < 10;i++){
  System.Console.WriteLine(i);
}