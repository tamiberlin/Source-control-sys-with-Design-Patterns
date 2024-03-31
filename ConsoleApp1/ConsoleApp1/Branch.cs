using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.State;

namespace ConsoleApp1
{
    public class Branch : Component
    {
        private List<Component> _children { get; set; }

        public Branch(string name) : base(name)
        {
            _children = new List<Component>();
        }

        public override string DoSomething()
        {
            int i = 0;
            string result = "Branch(";

            foreach (Component component in this._children)
            {
                result += component.DoSomething();
                if (i != this._children.Count - 1)
                {
                    result += "+";
                }
                i++;
            }

            return result + ")";
        }


        #region override MEMENTO
        public override void Undo()
        {
            base.Undo();
            if (base.Mementos.Count > 0)
            {
                var memento = this.Mementos.Pop().GetLastInitialState();
                this._children = ((Branch)memento)._children;
            }
        }
        #endregion

        #region override & add COMPOSITE
        public override void Add(Component component)
        {
            this._children.Add(component);
        }
       
        public override Folder AddFolder(string name)
        {
            Folder folder1 = new Folder(name);
            _children.Add(folder1);
            return folder1;
        }
        public override MyFile AddFile(string name, string contancs)
        {
            MyFile file1 = new MyFile(name, contancs);
            _children.Add(file1);
            return file1;
        }
        public Branch AddBranch(string Name)
        {
            Branch branch1 = new Branch(Name);
            _children.Add(branch1);
            return branch1;
        }
        public override void Remove(Component component)
        {
            this._children.Remove(component);
        }
        #endregion
       
        #region Prototype 
        public override Component DeepCopy()
        {
            int i = 0;
            Branch result = new Branch(this.Name);
            result._state = this._state;
            foreach (Component component in this._children)
            {
                result.Add(component.DeepCopy());
            }
            return result;
        }
        public Branch BrachCopy()
        {
            Branch branch = (Branch)this.DeepCopy();
            return branch;
        }
        #endregion

    }


}

