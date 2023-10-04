using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventlearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Incrementer incrementer = new Incrementer();
            Dozens dozens =new Dozens(incrementer);//创建拥有者和响应者的对象
            incrementer.DoCount();//一定要加上()——对象触发事件
            Console.WriteLine("number of dozens={0}", dozens.DozensCount);
        }
    }
    //事件拥有者
    class Incrementer
    {
        
        public event EventHandler CountedADozen;//直接声明事件，跳过委托类型的声明，使用系统定义的委托类型

        public void DoCount() 
        {
         for (int i = 0;i <100;i++)
            {
                if (i % 12 == 0 && CountedADozen != null)//触发事件的代码
                {
                    CountedADozen(this, null);//事件调用事件处理器类似于委托调用方法
                }
            }   
        }
    }
    class Dozens//事件响应者
    {
        void IncrementDozensCount(object source,EventArgs e)//事件处理器
        {
            DozensCount++;
        }
        public int DozensCount { get; private set; }
        public Dozens(Incrementer incrementer) //为什么要把类的对象传进来，因为要用到，用什么传进来什么
        {
            DozensCount = 0;
            incrementer.CountedADozen += IncrementDozensCount;//订阅事件
        }

    }
}
//for语句是遍历（1初始；2条件；4下一个的值）{3语句}直到不满足2
// 属性public int DozensCount { get; private set; }get是读取，class.DozensCount,set是修改设置值DozensCount=5；
