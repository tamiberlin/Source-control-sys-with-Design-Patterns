using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class User
    {
        private List<Branch> Branchs { get; set; }
        public string Name { get; set; }
        public int password { get; set; }
        public User(string name, int password) 
        { 
            this.Name = name;
            this.password = password;
            this.Branchs = new List<Branch>();
        }
        public Branch CreatBranch(string Name)
        {
            Branch branch1 = new Branch(Name);
            Branchs.Add(branch1);
            branch1.Datachanged += ConfirmAReview;
            return branch1;
        }
        public void RenoveBranch(Branch branch)
        {
            Branchs.Remove(branch);
        }
        public Branch CopyBranch(string Name)
        {
            Component branch = Branchs.Find(x => x.Name == Name).DeepCopy();
            return (Branch)branch;
        }
        public void ConfirmAReview()
        {
            Console.WriteLine($"hello {this.Name} your branch is being reviewd");
        }
    }
}
