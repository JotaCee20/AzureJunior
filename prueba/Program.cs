// See https://aka.ms/new-console-template for more information*/

using System.Reflection.Metadata;
using System.Text;

Console.WriteLine("Congratulations!");
Console.Write("");
Console.WriteLine("you wrote your firts lines of code");

var firstName = "Bob";
var messagesNumber = 3;
var celsius = 34.4;

firstName = "Bob";
Console.WriteLine(firstName);


firstName= "Liem";
Console.WriteLine(firstName);

firstName= "Isabella";
Console.WriteLine(firstName);

firstName= "Yasmin";
Console.WriteLine(firstName);

string message;

message= "Hello World";
Console.WriteLine(message);

Console.Write("Hello," + firstName + "! You have" + messagesNumber + "messages in your inbox. The temperature is" + celsius + "celsius.");


Console.Write("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World\"!");
Console.WriteLine("c:\\source\\repos");
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write(@"c:\invoices");
        // Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

string greeting = "Hola";
firstName = "Pepe";

Console.WriteLine(greeting+ " " + firstName + "!");

Console.Clear();
int version = 11;
string updateText = "Update to Windows";
message = $"{updateText} {version.ToString()}!";
Console.WriteLine(message);

Console.Clear();
string projectName = "First-Project";
var path = $@"C:\Output\{projectName}\Data";
Console.WriteLine(path);
