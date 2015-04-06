using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern
{
    public  abstract class Factory
    {
        public abstract Food CreateFoodFactory();
    }

    public abstract class Food
    {
        public abstract void Print();
    }

    public class Pork : Food
    {
        public override void Print()
        {
            Console.WriteLine("Pork");
            //throw new NotImplementedException();
        }
    }

    public class Beef : Food
    {
        public override void Print()
        {
            Console.WriteLine("Beef");
            //throw new NotImplementedException();
        }
    }

    public class PorkFactory : Factory
    {
        public override Food CreateFoodFactory()
        {
            return new Pork(); 
        }
    }

    public class BeefFactory : Factory
    {
        public override Food CreateFoodFactory()
        {
            return new Beef();
        }
    }

    public class FactroyClient
    {
        public void Run()
        {
            Factory pork = new PorkFactory();
            var prokPrint = pork.CreateFoodFactory();
            prokPrint.Print();

            Factory beef = new BeefFactory();
            beef.CreateFoodFactory().Print();
        }

    }

}
