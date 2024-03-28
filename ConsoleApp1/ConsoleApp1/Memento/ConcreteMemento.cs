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
        private Item _lastInitialState;
        public ConcreteMemento(string name, Item lastInitialState)
        {
            this._name = name;
            this._date = DateTime.Now;
            this._lastInitialState = lastInitialState;
        }

        public DateTime GetDate()
        {
            return this._date;
        }

        public Item GetLastInitialState()
        {
            return this._lastInitialState;
        }

        public string GetName()
        {
            return this._name;
        }
    }
}
