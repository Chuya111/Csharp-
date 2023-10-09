#define isshowmessage//定义宏
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace 特性
{
    internal class Program
    {
        //特性：方法的使用和启用,作用于方法或者参数，消费者读取特性
        //什么是特性？弃用方法参数，注释信息，true不能用，默认false不推荐用
        //Obsolete特性
        [Obsolete("请使用新的newtest方法", true)]
        static void test() { }
        static void newtest() { }
        //[conditonal]定义宏，方法被调用
        [Conditional("isshowmessage")]
        [DebuggerStepThrough]//debug的时候不进入方法
        static void showmessage(string message,[CallerLineNumber]int linenumber=0,[CallerFilePath] string filepath="",[CallerMemberName] string membername="") 
        { 
            Console.WriteLine( message);
            Console.WriteLine(filepath); 
        
        }
        //调用者信息特性，谁调用了我

        
        //自定义特性和使用
        static void Main(string[] args)
        {

            showmessage("begin");
            Console.WriteLine("working");
            showmessage("begin");
        }
    }
}
