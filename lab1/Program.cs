Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome to c#");

// basics string variable
string firstName = "Mirriam";
string lastName = "Yambeni";
Console.Write(firstName);
Console.Write(" ");
Console.Write(lastName);
Console.WriteLine();

Console.WriteLine("\nStrings & reassigning");
Console.WriteLine("---------------------------");


firstName = "Resten";
lastName = "Madzalo";
Console.WriteLine(firstName);
Console.WriteLine(lastName);

// int, float, decimal bool, char
Console.WriteLine("\nIntegers, float, decimal, bolean, char");
Console.WriteLine("-------------------------------------");


int age = 21;
float length = 294302f;
decimal width = 2.0m;
bool isRegistered = true;
char letter = 'b';

Console.WriteLine("age: "+ age);
Console.WriteLine("length: "+ length);
Console.WriteLine("width: "+ width);
Console.WriteLine("is registered: "+ isRegistered);
Console.WriteLine("letter: "+letter);


// var
Console.WriteLine("\nImplicitly typed local variable");
Console.WriteLine("-------------------------------------");

var userName = "Olivia";
var aged = 21;
float height = 294302f;
decimal breadth = 2.0m;
bool isCold = true;

Console.WriteLine("userName: "+ userName);
Console.WriteLine("aged: "+ aged);
Console.WriteLine("height: "+ height);
Console.WriteLine("breadth: "+ breadth);
Console.WriteLine("isCold: "+ isCold);

Console.WriteLine("\nEscape sequence");
Console.WriteLine("-------------------------------------");

Console.WriteLine("Her name is \"Mirriam\"");


Console.WriteLine("\nInterpolation, verbatim");
Console.WriteLine("-------------------------------------");

string studentFirstName = "Mirriam";
string studentLastName = "Yambeni";
string studentRegNumber = "BSC/COM/32/19";
long accountNumber = 21974681364911;
string program = "BSC Computer Science";

Console.WriteLine($"First name: {studentFirstName} \t\tLast name: {studentLastName}");
Console.WriteLine($"Reg number: {studentRegNumber} \tAccount number: {accountNumber}");
Console.WriteLine($@"                                Program: {program}");
 














