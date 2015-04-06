using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern
{
    public class Singleton
    {

        private static Singleton uniqueInstance;
        private static readonly object locker = new object();


        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            if (uniqueInstance == null)
            {
                lock (locker)
                {
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new Singleton();
                    }
                }
            }

            return uniqueInstance;
        }

    }
}
