using DesignPatttern.Observation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern.Observation.Interfaces
{
    public interface IObserver
    {
        void Update(WeatherData data);


    }
}
