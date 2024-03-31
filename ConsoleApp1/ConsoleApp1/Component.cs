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
        
        public virtual string DoSomething()
        {
            return "";
        }


        #region STATE

        protected IState _state = new Draft();
        

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
            } else
            {
                Console.WriteLine($"You can't Add you state is: {this._state.GetTypeState()}");
            }
        }
        public void GitCommit()
        {
            if (this._state is Staged)
            {
                this.ChangeState();
            }
            else
            {
                Console.WriteLine($"You can't Commit you state is: {this._state.GetTypeState()}");
            }
        }
        public void GitPush()
        {
            if (this._state is Commited)
            {
                this.ChangeState();
            }
            else
            {
                Console.WriteLine($"You can't push you state is: {this._state.GetTypeState()}");
            }

        }
        public void GitMerge()
        {
            if (this._state is ReadyToMarge)
            {
                this.ChangeState();
            }
            else
            {
                Console.WriteLine($"You can't merge you state is: {this._state.GetTypeState()}");
            }
        }
        public event Action? Datachanged;

        public void GitReview()
        {

            if (this._state is UnderReview)
            {
                if (Datachanged != null)
                    Datachanged();
                this.ChangeState();
            }
            else
            {
                Console.WriteLine($"You can't review you state is: {this._state.GetTypeState}");
            }
        }
        #endregion

        #region MEMENTO 

        internal Stack<IMemento> Mementos = new Stack<IMemento>();



        #region BackUp
        public void Backup(string name)
        {
            Console.WriteLine("\nCaretaker: Saving Originator's state...");
            var temp = this.DeepCopy();
            this.Mementos.Push(new ConcreteMemento(name, temp));
        }
        #endregion

        #region Undo
        public virtual void Undo()
        {
            if (this.Mementos.Count > 0)
            {
                var memento = this.Mementos.Pop().GetLastInitialState();
          
                this._state = memento._state;
            }
            else {
                Console.WriteLine("no history");
            }
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

        #region PROTOTYPE
        public virtual Component DeepCopy()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
