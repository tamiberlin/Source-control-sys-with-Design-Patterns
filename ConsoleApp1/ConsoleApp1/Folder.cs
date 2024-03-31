using ConsoleApp1.Memento;
using ConsoleApp1.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Folder : Component
    {
        
        private List<Component> _children {  get;  set; }

        public Folder(string name):base(name) 
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

        #region ovveride MEMENTO
        public override void Undo()
        {
            base.Undo();
            if (base.Mementos.Count > 0)
            {
                var memento = this.Mementos.Pop().GetLastInitialState();
                this._children = ((Folder)memento)._children;
            }
        }
        #endregion

        #region override & add COMPOSITE
        public override void Add(Component component)
        {
            if (! (component is Branch) ) {
                this._children.Add(component);
            }
            else { 
            throw new Exception("Can't contain a Branch");
            }
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

        #endregion

        #region ovveride PROTOTYPE
        public override Component DeepCopy()
        {
           Folder result=new Folder(this.Name);
           result._state = this._state;
            foreach (Component component in this._children)
            {
                    result.Add(component.DeepCopy());
            }
            return result;
        }
        #endregion

    }
}
