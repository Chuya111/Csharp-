using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多线程_自定义类传递数据
{
    internal class DownloadTool
    {
        public string URL {  get; private set; }
        public string Message { get; private set; }
        public DownloadTool(string URL, string Message)
        {
            this.URL = URL;
            this.Message = Message;
        }
        public void Download()
        {
            Console.WriteLine("从" + URL + "下载中");
        }
    }
}
