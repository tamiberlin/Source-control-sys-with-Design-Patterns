using ConsoleApp1.Memento;
using ConsoleApp1.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public abstract class Item
    {
        #region STATE

        private IState _state = new Draft();

        public virtual void ChangeState()
        {
            Console.WriteLine($"I was {_state.GetTypeState()}");
            _state=_state.SetState();
            Console.WriteLine($"And now I {_state.GetTypeState()}");
        }
        #endregion

        #region MEMENTO 

        internal  Stack<IMemento> Mementos = new Stack<IMemento>();

        public string Contants { get; internal set; }

        public virtual void DoSomething()
        { }

        #region BackUp
        public void Backup(string name)
        {
            Console.WriteLine("\nCaretaker: Saving Originator's state...");
            this.Mementos.Push(new ConcreteMemento(name, this));
        }
        #endregion

        #region Undo
        public virtual void Undo()
        {
            if (this.Mementos.Count != 0)
            {
                var memento = this.Mementos.Pop().GetLastInitialState();
                this._state = memento._state;
            }
               Console.WriteLine("no history");
        }
        #endregion

        #region ShowHistory
        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of mementos:");
            foreach (var item in this.Mementos)
            {
                Console.WriteLine(item.GetName());
            }
        }
        #endregion

        #endregion


        public Item()
        {
            
        }
        
    }
}
