using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public abstract class Component
    {
        protected string Name { get; set; }

        public Component(string name)
        {
            Name = name;
        }
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Display(int depth = 0);
    }

    public class Composite : Component
    {
        private List<Component> children = new List<Component>();
        public Composite(string name) : base(name) { }

        public override void Add(Component component)
        {
            children.Add(component);
        }
        public override void Remove(Component component)
        {
            children.Remove(component);
        }
        public override void Display(int depth = 0)
        {
            Console.WriteLine();
            Console.WriteLine(new string('-', depth) + "+" + Name);

            foreach (Component component in children)
            {
                component.Display(depth+2);
            }
            Console.WriteLine();
        }
    }

    public class Leaf : Component
    {
        public Leaf(string name) : base(name) { }
        public override void Add(Component component)
        {
            throw new Exception("Cannot add to Component::Leaf");
        }
        public override void Remove(Component component)
        {
            throw new Exception("Cannot remove anything from Component::Leaf");
        }
        public override void Display(int depth = 0)
        {
            Console.WriteLine(new string('-', depth) + "-" + Name);
        }
    }
}