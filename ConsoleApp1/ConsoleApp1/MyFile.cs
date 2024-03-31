using ConsoleApp1.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyFile : Component
    {
        public string Contants { private get; set; }
        public MyFile(string name,string contants) : base(name) 
        {
            Contants = contants;
        }
        public override string DoSomething()
        {
            return this.Contants;
        }
        public override bool IsFolder()
        {
            return false;
        }

        #region override & add COMPOSITE
        public override Component DeepCopy()
        {
            MyFile file = (MyFile)this.MemberwiseClone();
            file._state = this._state;
            return file;
        }
        #endregion
       

    }
}
