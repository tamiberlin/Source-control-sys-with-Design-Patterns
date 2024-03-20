using ConsoleApp1.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Item
    {
        private IState _state=new Commited();
        public virtual void ChangeState()
        {
            Console.WriteLine($"I was {_state.GetTypeState()}");
            _state=_state.SetState();
            Console.WriteLine($"And now I {_state.GetTypeState()}");
        }

    }
}
