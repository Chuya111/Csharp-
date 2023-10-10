using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 多线程_任务
{
    internal class Program
    {
        static void test()
        {
            for (int i = 0; i <10000;i++)
            {
                Console.WriteLine("A");
            }
        }
        static void firsttask()
        { 
            Console.WriteLine("downloading");
            Thread.Sleep(5000);
        }

        static void secondtask(object o)
        {
            Console.WriteLine("download complete");
        }
        static void Main(string[] args)
        {
            //创建task-1
            TaskFactory tf = new TaskFactory();
            Task t = tf.StartNew(test);
            //创建task-2
            Task t1 = new Task(test);
            t1.Start();//task也是线程？

            //连续任务
            Task t2 = new Task(firsttask);
            Task t3= t2.ContinueWith(secondtask);
            t2.Start();//只有t2 start

            Thread.Sleep(5000);//task线程是后台线程,需要前台程序休息一下才能看到


        }
        //资源冲突：使用锁
    }
}
