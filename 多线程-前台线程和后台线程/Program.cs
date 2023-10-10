using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 多线程_前台线程和后台线程
{
    internal class Program
    {

        //前台线程优先执行，
        static void test()
        {
            Console.WriteLine("started");
            Console.WriteLine("running");
            //Thread.Sleep(3000);
            Console.WriteLine("complete");
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(test) { IsBackground = false };//默认是false是前台程序，true是后台程序，不一定执行
            t.Start();
            Console.WriteLine("main complete:" + Thread.CurrentThread.ManagedThreadId);
        }
    }
}
