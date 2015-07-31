using DesignPatttern.Observation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern.Observation.Services
{
    public class WeatherData : ISubject
    {
        //user list to save the oberservs
        private List<DesignPatttern.Observation.Interfaces.IObserver> observers;

         

        //Initialize the list
        public WeatherData()
        {
            observers = new List<DesignPatttern.Observation.Interfaces.IObserver>();
        }

        

        public void RegisterObserver(Interfaces.IObserver o)
        {
            if (!this.observers.Exists(d => d == o))
            {
                this.observers.Add(o);
            }
        }

        public void RemoveObserver(Interfaces.IObserver o)
        {
            if (this.observers.Exists(d => d == o))
            {
                this.observers.Remove(o);
            }
        }


        public void NotifyObservers()
        {
            foreach (var o in observers)
            {
                o.Update(this); 
            }
        }
    }
}
