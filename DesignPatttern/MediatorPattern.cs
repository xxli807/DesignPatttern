using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern
{
    /// <summary>
    /// like a platform, using mediator pattern can change the relationships between each objects
    /// </summary>
    public class MediatorPattern
    {
        public void Run()
        {
            AbstractCardPartner A = new ParterA();
            AbstractCardPartner B = new ParterB();

            A.MoneyCount = 10;
            B.MoneyCount = 10;
            AbstractMediator meditor = new MediatorParter(A, B);

            //A win
            A.ChangeCount(5, meditor);
            Console.WriteLine(A.MoneyCount);

            //B win
            B.ChangeCount(5, meditor);
            Console.WriteLine(B.MoneyCount);

        }
    }


    public abstract class AbstractCardPartner
    {
        public int MoneyCount { get; set; }
        public AbstractCardPartner()
        {
            MoneyCount = 0;
        }

        public abstract void ChangeCount(int count, AbstractMediator meditor);
    }


    public class ParterA : AbstractCardPartner
    {
        public override void ChangeCount(int count, AbstractMediator meditor)
        {
            meditor.ParterAWin(count);
        }

    }

    public class ParterB : AbstractCardPartner
    {
        public override void ChangeCount(int count, AbstractMediator meditor)
        {
            meditor.ParterBWin(count);
        }

    }
   
    public abstract class AbstractMediator
    {
        protected AbstractCardPartner ParterA;
        protected AbstractCardPartner ParterB;
        public AbstractMediator(AbstractCardPartner A, AbstractCardPartner B)
        {
            this.ParterA = A;
            this.ParterB = B;
        }

        public abstract void ParterAWin(int count);
        public abstract void ParterBWin(int count);

    }

    public class MediatorParter : AbstractMediator
    {
        public MediatorParter(AbstractCardPartner A, AbstractCardPartner B)
            : base(A, B)
        {
        }

        public override void ParterAWin(int count)
        {
            ParterA.MoneyCount += count;
            ParterB.MoneyCount -= count;
        }


        public override void ParterBWin(int count)
        {
            ParterA.MoneyCount -= count;
            ParterB.MoneyCount += count;
        }


    }




}
