using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.State
{
    internal class Commited : IState
    {
        public string GetTypeState()
        {
            return "Commited";
        }

        public IState SetState()
        {

            return new UnderReview();
        }
    }
}
