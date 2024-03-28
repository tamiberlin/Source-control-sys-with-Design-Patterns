// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");
MyFile file = new MyFile("I am working");
MyFile file1 = new MyFile("I am working");
file.ChangeState();
file.Backup("v1");
file.Contants += "change!";
file.Contants = "change";
file.Backup("v2");
file.ShowHistory();
Console.WriteLine("file.Contants");
Console.WriteLine(file.Contants);


