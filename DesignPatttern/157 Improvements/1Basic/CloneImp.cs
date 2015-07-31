using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern._157_Improvements._1Basic
{
    [TestClass]
    public class CloneImp
    {
    
        [TestMethod]
        public void ShallowCopy()
        {
            var jack = new Employee()
            {
                IDCode="1",
                Age=20, 
                Department = new Departement()
                {
                    Name="IT"
                }

            };

            //shallow copy
            Employee rose = jack.Clone() as Employee;
            
            //write out the result for rose
            Console.WriteLine(rose.IDCode);
            Console.WriteLine(rose.Age);
            Console.WriteLine(rose.Department);

            Console.WriteLine("Now if change Jack's information.");
            jack.IDCode = "2";
            jack.Age = 30;
            jack.Department.Name = "Account";

            Console.WriteLine(rose.IDCode);
            Console.WriteLine(rose.Age);
            Console.WriteLine(rose.Department);

             
        }    
    
    }

    //Shallow copy of an object
    //public class Employee : ICloneable
    //{
    //    public string IDCode { get; set; }
    //    public int Age { get; set; }
    //    public Departement Department { get; set; }


    //    public object Clone()
    //    {
    //        return this.MemberwiseClone();
    //    }

    //}

    //DeepCopy
    [Serializable]
    public class Employee : ICloneable
    {
        public string IDCode { get; set; }
        public int Age { get; set; }
        public Departement Department { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();  
        }

        public Employee DeepClone()
        {
            //serialize the object and deserialize the object back
            using (var objectStream = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                //serialize the object
                formatter.Serialize(objectStream, this);
                objectStream.Seek(0, SeekOrigin.Begin);

                //deserize the object 
                return formatter.Deserialize(objectStream) as Employee;


            }
        }

        public Employee ShallowClone()
        {
            return this.Clone() as Employee;
        }



    }

     [Serializable]
    public class Departement
    {

        public string Name { get; set; }
        public override string ToString()
        {
            return this.Name;
        }

    }

    
}
