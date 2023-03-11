using System;

namespace CompositePattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Component mainComponent = new Composite("main Component");
            Component leaf1 = new Leaf("main leaf");
            Component leaf2 = new Leaf("main leaf");
            Component compositeElement = new Composite("branch A");

            compositeElement.Add(new Leaf("A leaf"));
            mainComponent.Add(leaf1);
            mainComponent.Add(leaf2);
            mainComponent.Add(compositeElement);
            mainComponent.Add(new Leaf("main leaf"));

            Component compositeElement1 = new Composite("branch B");
            Component compositeElement2 = new Composite("branch C");

            compositeElement1.Add(new Leaf("B leaf"));
            compositeElement1.Add(new Leaf("B leaf"));
            compositeElement2.Add(new Leaf("C leaf"));
            compositeElement2.Add(new Leaf("C leaf"));
            compositeElement1.Add(compositeElement2);

            mainComponent.Add(compositeElement1);
            mainComponent.Add(new Leaf("main leaf"));


            mainComponent.Display();
        }
    }
}