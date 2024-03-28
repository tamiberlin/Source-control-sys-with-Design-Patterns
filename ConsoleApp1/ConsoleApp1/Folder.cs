using ConsoleApp1.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Folder : Item
    {
        public List<Item> Items { get; set; }
        public Folder() 
        {
            Items = new List<Item>();
        }

    }
}
