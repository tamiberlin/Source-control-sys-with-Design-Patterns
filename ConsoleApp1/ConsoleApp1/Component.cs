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
    public abstract class Component
    {
        public string Name { get; set; }
        public Component(string name)
        {
            Name = name;
        }

        #region STATE

        private IState _state = new Draft();

        protected virtual void ChangeState()
        {
            Console.WriteLine($"I was {_state.GetTypeState()}");
            _state = _state.SetState();
            Console.WriteLine($"And now I {_state.GetTypeState()}");
        }
        public void GitAdd()
        {
            if (this._state is Draft)
            {
                this.ChangeState();
            }
        }
        public void GitCommit()
        {
            if (this._state is Staged)
            {
                this.ChangeState();
            }
        }
        public void GitPush()
        {
            if (this._state is Commited)
            {
                this.ChangeState();
            }
        }
        public void GitMerge()
        {
            if (this._state is ReadyToMarge)
            {
                this.ChangeState();
            }
        }
        public void GitReview()
        {
            if (this._state is UnderReview)
            {
                this.ChangeState();
            }
        }
        #endregion

        #region MEMENTO 

        internal Stack<IMemento> Mementos = new Stack<IMemento>();



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

        #region COMPOSITE
        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }
        public virtual Folder AddFolder(string name)
        {
            throw new NotImplementedException();
        }

        public virtual MyFile AddFile(string name ,string contancs)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }
        public virtual bool IsFolder()
        {
            return true;
        }
        #endregion

        public virtual string DoSomething()
        {
            return "";
        }

        public Component()
        {
            
        }
        
    }
}
