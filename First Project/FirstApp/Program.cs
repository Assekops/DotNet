// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("what is your first name?");
var name = Console.ReadLine();
var currentDate=DateTime.Now;
Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d}");
Console.Write($"{Environment.NewLine}Press Any Key to exit...");
Console.ReadKey();
