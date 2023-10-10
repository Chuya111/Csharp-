using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 多线程_资源冲突
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            
                StateObject state = new StateObject();
                for (int i = 0; i < 20; i++)
                {
                    Thread t = new Thread(state.changestate);
                }
            
            //lock的嵌套
            //死锁设计先后顺序
        }
    }
}
