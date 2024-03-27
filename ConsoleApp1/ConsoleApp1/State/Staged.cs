using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.State
{
    internal class Staged : IState
    {
        public string GetTypeState()
        {
            return "Staged";
        }

        public IState SetState()
        {
            return new Commited();
        }
    }
}
