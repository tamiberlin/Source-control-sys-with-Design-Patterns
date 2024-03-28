using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.State
{
    internal class ReadyToMarge : IState
    {
        public string GetTypeState()
        {
            return " Ready To Marge";
        }

        public IState SetState()
        {
            return new Marged();
        }
    }
}
