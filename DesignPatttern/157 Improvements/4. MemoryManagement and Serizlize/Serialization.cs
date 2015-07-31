
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern._157_Improvements._5._MemoryManagement_and_Serizlize
{
    [TestClass]
    public class Serializations
    {
        [TestMethod]
        public void Test()
        {
            Person mike = new Person() { Name = "mike", age = 1, ChineseName ="22" };
            mike.NameChanged += new EventHandler(mike_NameChanged);
            BinarySerializer.SerializeToFile(mike, @"C:\Users\xin\Desktop", "person.txt");

            Person person = BinarySerializer.DeserializeFromFile<Person>(@"C:\Users\xin\Desktop\person.txt");
            person.Name = "NAME HAS CHANGED";
            Console.WriteLine(person.Name);
            Console.WriteLine("none deserizlied: {0}", person.ChineseName);
         
        
        }

        public void mike_NameChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Name Changed.");
        }
        

    }


    [Serializable]
    class Person
    {
        [field: NonSerialized]
        public event EventHandler NameChanged;

        private string name;
        public int age { get; set; }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (NameChanged != null)
                {
                    NameChanged(this, null);
                }
                name = value;
            }


        }

        [NonSerialized]
        public Department department;

      
        public string noneSerizableField { get; set; }

        [NonSerialized]
        public string ChineseName;

        [OnDeserializedAttribute]
        void OnSerialzied(StreamingContext context)
        {
            this.ChineseName = name;
        }

    }

    [Serializable]
    class Department
    {
        public string DepName { get; set; }
    }


    public class Employee : ISerializable
    {
        public string FName;
        public string GName;
        public string ChName;

        public Employee() { }

        //deserialize the object
        protected Employee(SerializationInfo info, StreamingContext context)
        {
            FName = info.GetString("Fname");
            GName = info.GetString("GName");
            ChName = string.Format("{0}, {1}", FName, GName);
        
        }

        //serialize the object
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("FName", FName);
            info.AddValue("GName", GName);
        }
    }


}
