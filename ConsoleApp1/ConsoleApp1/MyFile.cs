using ConsoleApp1.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyFile : Item
    {
        public string Contants { get; set; }
        public MyFile(string contants)
        {
            Contants = contants;
        }
        public override void DoSomething()
        {
            Console.WriteLine(this.Contants);
        }
        public override void Undo()
        {
            base.Undo();
            if (base.Mementos.Count > 0)
            {
                var memento = this.Mementos.Pop().GetLastInitialState();
                memento = (MyFile)memento;
                this.Contants = memento.Contants;
            }
        }

    }
}
