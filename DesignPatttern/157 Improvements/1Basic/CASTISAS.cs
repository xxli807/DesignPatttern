using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern._157_Improvements._1Basic
{
    class CASTISAS
    {

        [TestMethod]
        public void TestCast()
        {
            FirstType first = new FirstType();

            SecondType second =  (SecondType) first;

            ThirdType third = first as ThirdType;
            long a = 0;
            if (a is Int32)
            {
                Console.WriteLine("is");
            }
            else
            {
                Console.WriteLine("is not");
            }
        }

        [TestMethod]
        public void TestParse()
        {
            var watch = new Stopwatch();

            var s = "test";
            
            watch.Start();
            try
            {
                Console.WriteLine("int pasese {0}", int.Parse(s));
            }
            catch (Exception e)
            {
            }
            watch.Stop();
            Console.WriteLine("Time is {0}",watch.Elapsed);

            int ss;

            watch.Start();
            Console.WriteLine("int try pasese {0}", int.TryParse(s, out ss));
            watch.Stop();
            Console.WriteLine("Time is {0}", watch.Elapsed);
        }


    }


    class FirstType
    {
        public string Name { get; set; }
    }

    class SecondType
    {
        public string Name { get; set; }

        public static explicit operator SecondType(FirstType firstType)
        {
            SecondType secondType = new SecondType() { Name = "From:" + firstType.Name };
            return secondType;
        }
    }

    class ThirdType : FirstType
    {

    }


}
