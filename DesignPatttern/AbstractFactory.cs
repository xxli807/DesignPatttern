using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern
{
    abstract class AbstractFactory
    {
        public abstract AbstractProduct1 CreateProduct1();
        public abstract AbstractProduct2 CreateProduct2();
    }

    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProduct1 CreateProduct1()
        {
            //throw new NotImplementedException();
            return new Product1();
        }

        public override AbstractProduct2 CreateProduct2()
        {
            //throw new NotImplementedException();
            return new Product2();
        }
    }


    abstract class AbstractProduct1
    {
    }

    abstract class AbstractProduct2
    {
        public abstract void Interact(AbstractProduct1 a);
    }

    class Product1 : AbstractProduct1
    {
    }

    class Product2 : AbstractProduct2
    {
        public override void Interact(AbstractProduct1 a)
        {
            Console.WriteLine(this.GetType().Name+" interact with "+a,GetType().Name);
        }
    }

    class AbstractFactoryClient
    {
        private AbstractProduct1 _abstract1;
        private AbstractProduct2 _abstract2;

        public AbstractFactoryClient(AbstractFactory factory)
        {
            _abstract1 = factory.CreateProduct1();
            _abstract2 = factory.CreateProduct2();
        }

        public void Run()
        {
            _abstract2.Interact(_abstract1);
        }
    }
}
