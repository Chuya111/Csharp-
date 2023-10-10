using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 多线程_自定义类传递数据
{
    //之前是只能访问方法里面的数据，现在可以访问类方法里面类的数据
    internal class Program
    {
        //初始化的时候指定给哪一个属性初始化
        static void Main(string[] args)
        {
            DownloadTool downloadtool = new DownloadTool("http;//www.comn/xx/xx.mp4","1234");
            Thread t = new Thread(downloadtool.Download);
            t.Start();
        }
    }
}
