using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern
{
    /// <summary>
    /// it is same as the tax, we have different types of taxs calcultation method
    ///  it is like the calculation itself exist, we just assign to different object
    ///  when to use stragety:
    ///  1: if the system needs to dynamically load a algorith from multiple algorithms
    ///  2: if an object has multiple actions, we can use the stregy to replace all the if-else
    /// </summary>
    public class StragetyPattern
    {
        public void Run()
        {
            InterestOperation operation = new InterestOperation(new PersonalTaxStrategy());
            operation.GetTax(700);


            operation = new InterestOperation(new EnterpriseTaxStrategy());
            operation.GetTax(800);
        }

    }

    public interface ITaxStragety
    {
        double CalculateTax(double income);
    }

    public class PersonalTaxStrategy : ITaxStragety
    {
        public double CalculateTax(double income)
        {
            return (income - 600) > 0 ? (income - 600) * 1.2 : 0;
        }
    }

    public class EnterpriseTaxStrategy : ITaxStragety
    {
        public double CalculateTax(double income)
        {
            return (income - 10000) > 0 ? (income - 10000) * 1.045 : 0.0;
        }
    }


    public class InterestOperation
    {
        private ITaxStragety taxStrategy;
        public InterestOperation(ITaxStragety tax)
        {
            this.taxStrategy = tax;
        }

        public double GetTax(double income)
        {
            return taxStrategy.CalculateTax(income);
        }

    }


}
