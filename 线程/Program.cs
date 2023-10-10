using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 线程
{
    internal class Program
    {
        //进程和线程
        //进行中的程序
        //单线程：按照顺序

        //强制类型转换:
        public struct Data
        { 
            public int x;
            public int y;
        }
        public static void download(object o)
        {
            //string str =o as string;
            Data data = (Data)o ;//多个参数赋值给方法，结构体的理解是各种数据的集合？
        }
        static void test()
        {
            Console.WriteLine("started");

            Console.WriteLine("running");
            //Thread.Sleep(3000);
            Console.WriteLine("complete");
        }
        delegate void Testdelegate();//声明委托类型而不是委托对象委托又有点像类
        static void Main(string[] args)
        {
            ////异步委托执行线程
            //Testdelegate testdelegate = test;
            //testdelegate.BeginInvoke(null,null);

            //Thread创建线程
            Thread t = new Thread(() => Console.WriteLine("Child.Thread:"+Thread.CurrentThread.ManagedThreadId)) ;
            t.Start();//不理解为什么start可以传参数传一个或者两个参数

            //往线程里传递数据,传递只带一个方法的参数
            Thread t1 = new Thread(download);
            //t1.Start("http;//www.comn/xx/xx.mp4");
            //传递多个数据
            Data data = new Data();
            data.x = 12;
            data.y = 13;
            t1.Start(data);
            //线程是传进方法，同时进行方法这种
            //testdelegate();

            
            Console.WriteLine("main complete:"+Thread.CurrentThread.ManagedThreadId);

            //自定义类的方式传递数据
            //后台线程和前台线程，后服务前
        }
    }
}
//装箱和拆箱从object而来