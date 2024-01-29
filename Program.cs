// See https://aka.ms/new-console-template for more information

using static System.Console;
using System.Runtime.InteropServices;
using System.Xml.Schema;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hi, my name is Pedro Romero, and I'm in CPS3300");
Console.WriteLine("Version: {0}", Environment.Version.ToString());

// Add a current date and time display
Console.WriteLine("Current date and time: " + DateTime.Now);

// Interactive, showing the use of variables. Ex) string
Console.Write("Please enter your favorite programming language: ");
string favoriteLanguage = Console.ReadLine();
Console.WriteLine("Your favorite programming language is " + favoriteLanguage);

// Asking for favorite language
if (favoriteLanguage.Equals("C#", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Great choice! " + favoriteLanguage + " is a powerful language.");
}

//Simple Array
string [] consoles = {"Playstation", "Xbox",  "Nintendo"};
Console.WriteLine(consoles[0]);

string text = System.IO.File.ReadAllText("text.txt");
Console.WriteLine(text);