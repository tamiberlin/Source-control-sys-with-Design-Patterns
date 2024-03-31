// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");
User Tami = new User("tami", 123);
User Hila = new User("Hila", 345);
Branch Tbranch = Tami.CreatBranch("tami branch");
Branch Hbranch = Hila.CreatBranch("Hila branch");
MyFile gitfile = new MyFile("gitfile", "this is a gitIgnore file");
MyFile dockerfile = new MyFile("dockerfile", "this is a dockerFile");
Folder folder1 = new Folder("folder1");
Folder folder2 = new Folder("folder2");
folder1.AddFile("newfile", "im a new file");
folder2.Add(folder1);
Tbranch.Add(folder2);
Hbranch.AddFile("hila file", "hello hila");

Tbranch.GitMerge();
Tbranch.GitAdd();
Tbranch.Backup("check add function");
Tbranch.GitCommit();
Tbranch.ShowHistory();
Tbranch.Undo();
Tbranch.GitCommit();
Tbranch.GitPush();
Tbranch.GitReview();
Tbranch.GitMerge();
Branch branchCopy=Tbranch.BrachCopy();
Console.WriteLine("Tbranch");
Console.WriteLine(Tbranch.DoSomething());
Console.WriteLine("branchCopy");
Console.WriteLine(branchCopy.DoSomething());




