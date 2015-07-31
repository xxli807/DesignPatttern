using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern.Observation.Services
{
    [TestClass]
    class Test  
    {
        [TestMethod]
        public void TestObserver()
        {
            WeatherData data = new WeatherData();
            data.RegisterObserver(new TempObserver());
            data.RegisterObserver(new FonecastObserver());


            data.NotifyObservers();
             
             

        }

    }
}
