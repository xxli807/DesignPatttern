using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern._157_Improvements._7Architecture
{
    [TestClass]
    class No94override
    {
        [TestMethod]
        public void Test()
        {
            Sharp circle = new Circle();
            circle.Method();

            Sharp triangle = new Triangle();
            //this will print the base method not the devired class
            triangle.Method();

            Triangle tr = new Triangle();
            tr.Method();
        }
    }



    abstract class Sharp
    {
        public virtual void Method()
        {
            Console.WriteLine("Sharp base method");
        }
    }


    class Circle : Sharp
    {
        public override void Method()
        {
            //base.Method();
            Console.WriteLine("Circle override method");
        }
    }

    class Triangle : Sharp
    {
        public new void Method()
        {
            Console.WriteLine("Triangle new method");
        }
    }






}
