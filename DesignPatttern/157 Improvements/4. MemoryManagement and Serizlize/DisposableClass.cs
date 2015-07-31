using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern._157_Improvements._5._MemoryManagement_and_Serizlize
{
    [TestClass]
    public class DisposableTest
    {
        [TestMethod]
        public void TestDisposable()
        {

        }
    }

    //https://msdn.microsoft.com/en-us/library/system.idisposable.dispose(v=vs.110).aspx
    class DisposableClass : IDisposable
    {
        //define an unmanaged resouce
        private IntPtr nativeResouece = Marshal.AllocHGlobal(100);

        //define a managed resouce
        private Component managedResource = new Component();

        private bool disposed = false;




        /// <summary>
        /// Implement the Dispose in IDisposeable
        /// </summary>
        public void Dispose()
        {
            //must true
            Dispose(true);

            //notify the GC, the code will dispose, no need to take dispose second action
            GC.SuppressFinalize(this);
        }

        //c# destructor syntax for finalization code.
        //this destructor will run only if the dispose method does not get called.
        ~DisposableClass()
        {
            Dispose(false);
        }


        //using protect to modify the dispose method
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }

            if(disposing)
            {
                if (managedResource != null)
                {
                    //dispose the obj
                    managedResource.Dispose();
                    managedResource = null;
                }
            }

            if (nativeResouece != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(nativeResouece);
                nativeResouece = IntPtr.Zero;
            }

            disposed = true;

        }













    }


    

}
