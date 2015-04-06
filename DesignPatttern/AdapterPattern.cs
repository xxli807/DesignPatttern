using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern
{
    /// <summary>
    /// the purpose of the adapter pattern: using the existing implementation can be used in new environment
    /// it can make two interface different class can be user concurrency. There are two types: class adaptor and object adaptor
    /// it is used in client / service interface, abstract class not consistence issue
    /// because c# not support multiple heritage so we use interface
    /// 
    /// it can be used in:
    /// 1: the sytem needs to reuse existing class, but the existing class interface not fit in for new requreiment
    /// 2: wants to build a none-repeat class to be used multiple class where is not much relation between each other
    /// 
    /// </summary>
    public class AdapterPattern
    {
        public void Run()
        {
            // class adaptor
            IThreeHoleSocket threeHoleSocket = new SocketAdaptor();
            threeHoleSocket.Request();
        
        
           //object adaptor
            ThreeHoleSoc three = new PowerScoketAdaptpr();
            three.Request();
        }

    }

    public interface IThreeHoleSocket
    {
        void Request();
    }

    public abstract class TwoHoleSocket
    {
        public void SpecificRequest()
        {
            Console.WriteLine("I am a two hole Socket");
        }

    }

    /// <summary>
    /// the adaptor must heritage the TwoHoleSocket and implement the IThreeHoleScoket
    /// </summary>
    public class SocketAdaptor : TwoHoleSocket, IThreeHoleSocket
    {
        public void Request()
        {
            this.SpecificRequest();
        }

    }


    public class ThreeHoleSoc
    {
        public virtual void Request()
        {
            //normally we can put the implementation here
        }
    }

    public class TwoHoleSoc
    {
        public void SpecificRequest()
        {
            Console.WriteLine("TWO HOLE SCOKET");
        }
    }

    public class PowerScoketAdaptpr : ThreeHoleSoc
    {
        public TwoHoleSoc two = new TwoHoleSoc();
        public override void Request()
        {
            //base.Request();
            this.two.SpecificRequest();
        }

    }

}
