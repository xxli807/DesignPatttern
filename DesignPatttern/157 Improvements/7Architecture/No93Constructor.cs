using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern._157_Improvements._7Architecture
{
    class No93Constructor
    {
    }


    //using construcor to init the company
    class Company
    {
        public Employee CEO { get; set; }
        Employee A = new Employee() { Name = "Tom" };


        public Company()
        {
            CEO = new Employee() { Name = "jack" };
        }



    }


}
