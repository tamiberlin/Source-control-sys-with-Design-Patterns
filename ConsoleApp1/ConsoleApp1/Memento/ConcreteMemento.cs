using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Memento
{
    public class ConcreteMemento : IMemento
    {
        private string _name;
        private DateTime _date;
        private Component _lastInitialState;
        public ConcreteMemento(string name, Component lastInitialState)
        {
            this._name = name;
            this._date = DateTime.Now;
            this._lastInitialState = lastInitialState;
        }

        public DateTime GetDate()
        {
            return this._date;
        }

        public Component GetLastInitialState()
        {
            return this._lastInitialState;
        }

        public string GetName()
        {
            return this._name;
        }
    }
}
