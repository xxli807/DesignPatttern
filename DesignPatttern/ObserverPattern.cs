using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern
{


    /// <summary>
    /// this pattern is similar with the RSS Feeder, we feed to a main address but we will feed for other sub systems
    /// we can use "delegate" to implement this 
    /// there are four objects: Subject, Observer, ConcreteSubject, ConcreteObserver
    /// </summary>
    public class ObserverPattern
    {
        public void Run()
        {
            Dota dota = new Dota2("dota2", "updates with a new hero");
            dota.AddObserver(new Subscriber("Tim"));
            dota.AddObserver(new Subscriber("john"));
            dota.Update();
        }
    }

    public abstract class Dota
    {
        private List<IObserver> observers = new List<IObserver>();

        public string Info { get; set; }
        public string Symbol { get; set; }
        public Dota(string symbol, string info)
        {
            this.Symbol = symbol;
            this.Info = info;
        }

        public void AddObserver(IObserver ob)
        {
            observers.Add(ob);
        }

        public void RemoveObserver(IObserver ob)
        {
            observers.Remove(ob);
        }

        public void Update()
        {
            foreach (var ob in observers)
            {
                if (ob != null)
                {
                    ob.ReceiverAndUpdate(this);
                }
            }
        }


    }

    public class Dota2 : Dota
    {
        public Dota2(string symbol, string info)
            : base(symbol, info)
        {
        }
    }


    public interface IObserver
    {
        void ReceiverAndUpdate(Dota dota);
    }

    public class Subscriber : IObserver
    {
        public string name { get; set; }
        public Subscriber(string name)
        {
            this.name = name;
        }

        public void ReceiverAndUpdate(Dota dota)
        {
            Console.WriteLine("notify {0} with symbol {1} aboout {2}", name, dota.Symbol, dota.Info);
        }

    }



}
