using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GitDemo
{
   public class ThreadClsDemo
    {
        public void Test()
        {
            lock (this) // this refers to the current thread
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name);
                    //Thread.Sleep(200);
                }
            }
        }
        //public void Test2()
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine("Hello");
        //        Thread.Sleep(2000);
        //    }
        //}
    }
}
