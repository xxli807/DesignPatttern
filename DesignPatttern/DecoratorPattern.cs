using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern
{
    /// <summary>
    /// dynamtically add additional function to the object instead of keep adding child object and then heritage it
    /// It is like a house decoration
    /// 1: compare to heritage, decoration more flexible
    /// 2: depend on the order, the design can create more combination of the behavior
    /// 3: more extendable
    /// </summary>
    public class DecoratorPattern
    {
        public void Run()
        {
            //I have a phone
            Phone phone = new Iphone();
 
            //i add a headSet
            Decorator iphoneHeadSet = new HeadSet(phone);
            iphoneHeadSet.Call();

            //i add a phone case
            Decorator iphoneCase = new PhoneCase(phone);
            iphoneCase.Call();

            //I add a headset and phone case same time
            HeadSet headSet = new HeadSet(phone);
            PhoneCase phoneCase = new PhoneCase(headSet);
            phoneCase.Call();
        }

    }

    /// <summary>
    /// the phone's abstract class
    /// </summary>
    public abstract class Phone
    {
        string brand { get; set; }
        string price { get; set; }

        public abstract void Call();
    }

    /// <summary>
    /// the detail component
    /// </summary>
    public class Iphone : Phone
    {
        public override void Call()
        {
            Console.WriteLine("Iphone can call");
        }
    }

    /// <summary>
    /// decorate abstract class to replace the abstract component, so it must heritage from the phone
    /// </summary>
    public abstract class Decorator : Phone
    {
        private Phone phone;
        public Decorator(Phone ph)
         : base()
        {
            this.phone = ph;
        }
        public override void Call()
        {
            if (phone != null)
            {
                phone.Call();
            }
        }
    }


    public class HeadSet : Decorator
    {
        public HeadSet(Phone ph)
            : base(ph)
        {
        }


        public override void Call()
        {
            base.Call();

            AddHeadSet();
        }

        public void AddHeadSet()
        {
            Console.WriteLine("add a headset");
        }

    }

    public class PhoneCase : Decorator
    {
        public PhoneCase(Phone ph)
            : base(ph)
        {
        }

        public override void Call()
        {
            base.Call();
            AddPhoneCase();
        }

        public void AddPhoneCase()
        {
            Console.WriteLine("Add a case");
        }

    }


    
}





