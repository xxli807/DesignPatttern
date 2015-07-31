using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern.Stragety
{


    /*
     *When to use stregety:
     1: customer needs other way to do it or new function
     2: company needs different db product or different db data format
     3: if tech changes then we must update the new code or adjust new protocal
     4: new algorthem
      
      
     */







    public class Character
    {
        IWeaponBehavior weapon;
        public void fight()
        {
            weapon.userWeapon();
        }

        public void setWeapon(IWeaponBehavior weapon)
        {
            this.weapon = weapon;
        }

    }

    public class Queen : Character
    {

    }

    public class King : Character
    {
        public King() : base(){} 
    }

    public class Knight : Character
    {

    }

    public class Troll : Character
    {

    }






}
