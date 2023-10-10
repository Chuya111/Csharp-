using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 多线程_资源冲突
{
    internal class StateObject
    {
        //锁和解决死锁
        private int state = 5;
        private int state1 = 5;
        private static object _lock1 = new object();
        private static object _lock2 = new object();
        public void changestate()
        {
            lock (_lock1)
            {
                lock (_lock2)
                {
                    if (state == 5)
                    {
                        state++;
                        Console.WriteLine("state==5:" + state + Thread.CurrentThread.ManagedThreadId);
                    }
                    state = 5;

                    if (state1 == 5)
                    {
                        state1++;
                        Console.WriteLine("state==5:" + state1 + Thread.CurrentThread.ManagedThreadId);
                    }
                    state1 = 5;
                }
                    
            }
        }

    }
}
