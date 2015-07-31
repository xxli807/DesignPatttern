using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatttern._157_Improvements._6._Async_and_Thread
{

    [TestClass]
    public class ThreadTest
    {
        AutoResetEvent autoResetEvent = new AutoResetEvent(false);

        //use to cancel the thread
        CancellationTokenSource cts = new CancellationTokenSource();


        [TestMethod]
        public void Test()
        {
            ThTest();
            SetSignal();
        }




        public void ThTest()
        {
            int timer = 0;
           
            //should use the threadPool or BackgroundWorker to replace Thread

           //Start a new thread
            Thread tWork = new Thread(() =>
            {
                Console.WriteLine("Thread one is starting;");

                //await the time

                Console.WriteLine("time add 1: "+timer++);

                autoResetEvent.WaitOne();
                Console.WriteLine("timer add 2: "+timer++);

            });

            tWork.IsBackground = true;
            tWork.Start();

            //instead of using the above code we should use the thread pool 
            ThreadPool.QueueUserWorkItem((objState) =>
            {
                Console.WriteLine("Thread one is starting;");

                //await the time

                Console.WriteLine("time add 1: " + timer++);

                autoResetEvent.WaitOne();
                Console.WriteLine("timer add 2: " + timer++);

            }, null);


            //use task to replace the ThreadPool
            Task t = new Task(() =>
            {
                //do sth
                Thread.Sleep(100);

            });

            t.Start();
            t.ContinueWith((objTask) =>
            {
                //objTask.IsCanceled

            });

            //we can use the Parallel to simplify the operation
            Parallel.For(0, 10, (i) =>
            {
                //using this method the outputs are not in order
            });




        }

        public void SetSignal()
        {
            //set the single
            autoResetEvent.Set();
        }




    }





}
