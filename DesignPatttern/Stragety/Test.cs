using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern.Stragety
{
     
    public class Test
    {
        [TestMethod]
        public void TestCharacter()
        {
            Character king = new King();
            king.setWeapon(new AxeBehavior());
            king.fight();

            Character queen = new Queen();
            queen.setWeapon(new BowAndArrowBehavior());
            queen.fight();

            Character knight = new Knight();
            knight.setWeapon(new SwordBehavior());
            knight.fight();

            Character troll = new Troll();
            troll.setWeapon(new KnifeBehavior());
            troll.fight();
        
        
        
        
        
        }



    }
}
