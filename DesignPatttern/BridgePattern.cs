using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern
{
    /// <summary>
    /// the detail is not implemented in the abstract class but we put the implementation part on the other detail object.
    /// it can separate the interface abstract and  loose coupling implementation
    /// the client side knows exactly what happen
    /// 
    /// it can be used:
    /// 1: if a system needs more flexible between component and concrete role
    /// 2:  if a design needs any role change is not affect the client side
    /// 3: multple platform windows system.
    /// 
    /// </summary>
    public class BridgePattern
    {
        public void Run()
        {
            RemoteControl remoteControl = new ConcreteRemote();
            remoteControl.Tv = new AppleTV();
            remoteControl.On();
            remoteControl.Off();
            remoteControl.SetChannel();


            remoteControl.Tv = new HPTV();
            remoteControl.On();
            remoteControl.Off();
            remoteControl.SetChannel();

        }


    }


    public class RemoteControl
    {
        private TV tv;
        public TV Tv
        {
            get { return tv; }
            set { tv = value; }
        }

        //virtual allows subclasses to override it.
        public virtual void On()
        {
            tv.On();
        }

        public virtual void Off()
        {
            tv.Off();
        }

        public virtual void SetChannel()
        {
            tv.TurnChannel();
        }

    }

    //original 
    public class ConcreteRemote : RemoteControl
    {
        public override void SetChannel()
        {
            base.SetChannel();
        }

    }




    //TV abstrract class TV
    public abstract class TV
    {
        public abstract void On();
        public abstract void Off();
        public abstract void TurnChannel();
    }

    public class AppleTV : TV
    {
        public AppleTV()
            : base()
        {
        }

        public override void On()
        {
            Console.WriteLine("Apple TV is on");
        }

        public override void Off()
        {
            Console.WriteLine("Apple TV is off");
        }

        public override void TurnChannel()
        {
            Console.WriteLine("Apple TV can change channel");
        }

    }

    public class HPTV : TV
    {
        public HPTV()
            : base()
        {
        }

        public override void On()
        {
            Console.WriteLine("HP TV is on");
        }

        public override void Off()
        {
            Console.WriteLine("HP TV is off");
        }

        public override void TurnChannel()
        {
            Console.WriteLine("HP TV can change channel");
        }
    }





}
