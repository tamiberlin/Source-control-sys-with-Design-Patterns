using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.State
{
    internal class Marged : IState
    {
        public string GetTypeState()
        {
            return "Marged";
        }

        public IState SetState()
        {
           throw new NotImplementedException();
        }

       
    }
}
