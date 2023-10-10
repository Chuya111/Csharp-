using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 多线程_优先级
{
    internal class Program
    {
        static void A(){Console.WriteLine("A");}
        static void B() { Console.WriteLine("B"); }

        static void Main(string[] args)
        {
            Thread a = new Thread(A);
            a.Start();
            Thread b = new Thread(B);
            b.Start();
            a.Priority= ThreadPriority.Highest; 
            b.Priority= ThreadPriority.Highest;
            b.Join();//本来是多线程同时执行，现在变成合二为一（一个线程里面的顺序问题）子线程加入主线程
            //主线程优先于子线程？

        }
    }
}
