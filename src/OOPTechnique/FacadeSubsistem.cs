

using System;

namespace OOPTechnique.FacadeSubsystem
{
    public class Facade
    {
        private ElementA _elementA;
        private ElementB _elementB;

        public void HelloWorld()
        {
            _elementA =new ElementA();
            _elementB = new ElementB();

            _elementA.Hello();
            _elementB.World();
        }
    }

    public class ElementA
    {
        public void Hello()
        {
            Console.WriteLine("Hello");
        }
    }

    public class ElementB
    {
        public void World()
        {
            Console.WriteLine("World!");
        }
    }


    public class Client
    {
        public static void Main()
        {
            Facade facade = new Facade();
            facade.HelloWorld();
        }
    }
}
