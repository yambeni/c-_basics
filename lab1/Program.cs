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
 

//basic math
Console.WriteLine("\nBasci Maths");
Console.WriteLine("-------------------------------------");

int num1 = 5;
int num2 = 10;

Console.WriteLine($"Addition {num1} + {num2}: {num1 + num2}");
Console.WriteLine($"Subtraction {num1} - {num2}: {num1 - num2}");
Console.WriteLine($"Multiplication {num1} * {num2}: {num1 * num2}");
Console.WriteLine($"Division {num1} / {num2}: {num1 / num2}");
Console.WriteLine($"Modulus {num1} % {num2}: {num1 % num2}");

//incre && decre
Console.WriteLine("\nPre-Increment & Pre-Decrement ");
Console.WriteLine("-------------------------------------");
Console.WriteLine($"Pre-Increment {num1}: {++num1}");
Console.WriteLine($"Pre-Increment {num2}: {++num2}");

Console.WriteLine($"Pre-Decrement {num1}: {--num1}");
Console.WriteLine($"Pre-Decrement {num2}: {--num2}");

Console.WriteLine("\nPost-Increment & Post-Decrement ");
Console.WriteLine("-------------------------------------");
Console.WriteLine($"Post-Increment {num1}: {num1++}");
Console.WriteLine($"Post-Increment {num2}: {num2++}");

Console.WriteLine($"Post-Decrement {num1}: {num1--}");
Console.WriteLine($"Post-Decrement {num2}: {num2--}");


//exercise
//temperature converter
Console.WriteLine("\nTemperature Converter");
Console.WriteLine("-------------------------------------");
int fahrenheit = 94;
decimal temperature = (decimal)(fahrenheit - 32) * 5 / 9;
Console.WriteLine($"The temperature is {temperature} Celsius");
