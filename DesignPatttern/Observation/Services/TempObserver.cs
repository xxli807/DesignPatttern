using DesignPatttern.Observation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern.Observation.Services
{


    /// <summary>
    /// Observation pattern is used to describe the : Subject and Observer like news paper subscriber
    /// Observer is the subscriber...Subject is the data part
    /// Observer can register self into the Subject and remove them if no need those data
    /// 
    /// Used: when many objects have dependecy (1:M), when one object changes notify other related objects.
    /// 
    /// </summary>

    public class TempObserver : Interfaces.IObserver, IDisplay
    {
          
        public void Update(WeatherData name)
        {
            Console.WriteLine("Temp: {0}", name);
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Temp Display");
        }
    }



    public class FonecastObserver : Interfaces.IObserver, IDisplay
    {
        
 
         public void Update(WeatherData name)
        {
            Console.WriteLine("FonecastObserver: {0}", name);
            Display();
        }


        public void Display()
        {
            Console.WriteLine("Fonecast Display");
        }
    }









}
