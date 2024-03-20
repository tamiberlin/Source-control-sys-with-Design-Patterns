using ConsoleApp1.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Folder:Item
    {
       /* private IState _state = new Commited();
        public override void ChangeState()
        {
            Console.WriteLine($"I was {_state.GetTypeState()}");
            _state = _state.SetState();
            Console.WriteLine($"And now I {_state.GetTypeState()}");
        }*/
    }
}
