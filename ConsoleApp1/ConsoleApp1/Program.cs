// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");
MyFile file = new MyFile("I am working");
MyFile file1 = new MyFile("I am working");
file.Backup("v1");
file.Contants = "change!";
file.Contants = "change";
file.Backup("v2");
file.ShowHistory();
Console.WriteLine(file.DoSomething());
Console.WriteLine(file.DoSomething());
Branch branch = new Branch();
branch.Add(file);
branch.Add(file1);
branch.Backup("b1");
branch.ShowHistory();
branch.Remove(file);
branch.Backup("b2");
branch.ShowHistory();
branch.DoSomething();
Branch branch2 = new Branch();
branch.GitAdd();



