using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern
{
    class Program
    {
        static void Main(string[] args)
        {

            ////singleton pattern
            //Singleton singleton = Singleton.GetInstance();
            //Singleton singleton2 = Singleton.GetInstance();
            //if (singleton == singleton2)
            //{
            //    Console.WriteLine("same instance");
            //}

            ////abstract factory
            //AbstractFactory abstractFac1 = new ConcreteFactory1();
            //AbstractFactoryClient client1 = new AbstractFactoryClient(abstractFac1);
            //client1.Run();

            //AbstractFactory abstractFac2 = new ConcreteFactory1();
            //AbstractFactoryClient client2 = new AbstractFactoryClient(abstractFac2);
            //client2.Run();


            //factory module
            //FactroyClient factoryClient = new FactroyClient();
            //factoryClient.Run();

            DecoratorPattern decoratorPattern = new DecoratorPattern();
            decoratorPattern.Run();

            
            

        }
    }
}
