using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern.Stragety
{
    public interface IWeaponBehavior
    {
        void userWeapon();
    }

    public class KnifeBehavior : IWeaponBehavior
    {
        public void userWeapon()
        {
            Console.WriteLine("user Knife");
        }
    }

    public class BowAndArrowBehavior : IWeaponBehavior
    {
        public void userWeapon()
        {
            Console.WriteLine("user Bow And Arrow");
        }
    }

    public class AxeBehavior : IWeaponBehavior
    {
        public void userWeapon() 
        {
            Console.WriteLine("user Axe");
        }
    }

    public class SwordBehavior : IWeaponBehavior
    {
        public void userWeapon()
        {
            Console.WriteLine("user Sword");
        }
    }

    


}
