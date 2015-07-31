using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern._157_Improvements._2._Collection_and_LINQ
{

    [TestClass]
    public class LINQ_Test
    {

        [TestMethod]
        public void Test()
        {
            //arry to list
            var intArr = new int[] {1,2,3 };
            List<int> intArrList = intArr.ToList<int>();
            foreach (var item in intArrList)
            {
                //output the result
                Console.WriteLine(item);

            }
        }


    }







}
