using ConsoleApp1.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyFile : Component
    {
        public string Contants { private get; set; }
        public MyFile(string name,string contants) : base(name) 
        {
            Contants = contants;
        }
    
        public override string DoSomething()
        {
            return this.Contants;
        }
        public override void Undo()
        {
            base.Undo();
            if (base.Mementos.Count > 0)
            {
                var memento = this.Mementos.Pop().GetLastInitialState();
                this.Contants =  ((MyFile)memento).Contants;
            }
        }
        public override bool IsFolder()
        {
            return false;
        }

    }
}
