using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Memento
{
    public interface IMemento
    {
        string GetName();
        Item GetLastInitialState();
        DateTime GetDate();
    }
}
