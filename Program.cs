// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Console.Write("Congratulations!");
// Console.Write(" ");
// Console.Write("You wrote your first lines of code.");


// Console.WriteLine("Congratulations!");
// Console.Write("You wrote your first lines of code.");



// Console.WriteLine('b');
// Console.WriteLine('Hello World!');
Console.WriteLine(123);

Console.WriteLine(0.25F);

Console.WriteLine(2.625);

Console.WriteLine(12.39816m);

var name = "Bob";
var number = 3; 
var option = 34.4;






Console.Write("Hello, "); 
Console.Write(name); 
Console.Write("! You have "); 
Console.Write(number); 
Console.Write(" messages in your inbox. The temperature is "); 
Console.Write(option); 
Console.Write(" celsius."); 

//Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius.


Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.Write("\nOutput Directory:\t");


string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");   



// string interpolation 

// @ symbol to allow backlash to stay or else double backlash 
// $ have string with variables in them 

string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";



string path = $@"c:\Exercise\{projectName}\data.txt";
string pathRussian = $@"c:\Exercise\{projectName}\ru-RU\data.txt";

string message = "View English output:";








Console.WriteLine($"{message}\n\t{path}");
Console.WriteLine($"{russianMessage}\n\t{pathRussian}");






// section : numbers operations 

int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);


//increment and decrement  

int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);


// position of increments 

int valuea = 1;
valuea++;
Console.WriteLine("First: " + valuea);
Console.WriteLine($"Second: {valuea++}");
Console.WriteLine("Third: " + valuea);
Console.WriteLine("Fourth: " + (++valuea));

