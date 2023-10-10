using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 线程池
{
    internal class Program
    {
        static void download(object o) 
        { 
        for (int i = 0; i < 3, i++)
            {
                Console.WriteLine("downloading"+Thread.CurrentThread.ManagedThreadId);
            }
        }
        static void Main(string[] args)
        {
            //线程池创建线程——后台线程，入池的线程放小任务
            for (int i = 0;i < 3, i++)
            {
                ThreadPool.QueueUserWorkItem(download);
            }
        }
    }
}
