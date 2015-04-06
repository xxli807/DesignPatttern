using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern
{
    public class ProxyPattern
    {
        public void Run()
        {
            Student proxy = new Friend();
            proxy.EnrollClass();
        }
    }

    public abstract class Student
    {
        public abstract void EnrollClass();
    }


    public class RealEnrollStudent : Student
    {
        public override void EnrollClass()
        {
            Console.Write("self enroll a course");
        }

    }

    //the proxy friend

    public class Friend : Student
    {
        RealEnrollStudent self;
        public override void EnrollClass()
        {
            if (self == null)
            {
                self = new RealEnrollStudent();
            }

            PreEnroll();
            self.EnrollClass();
            PostEnroll();

        }

        public void PreEnroll()
        {
            Console.WriteLine("preenroll a course");
        }

        public void PostEnroll()
        {
            Console.WriteLine("buy me a coffee");
        }


    }






}
