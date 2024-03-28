using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.State
{
    internal class UnderReview : IState
    {
        public string GetTypeState()
        {
            return "Under Review";
        }

        public IState SetState()
        {
            return new ReadyToMarge();
        }
    }
}
