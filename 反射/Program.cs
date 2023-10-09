using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 反射
{
    //反射，查看源码？反向映射
    internal class Program
    {
        //反射和特性，代码本身也是数据
        //程序集dll/.exe：储存元数据（程序）
        
        static void Main(string[] args)
        {
            Type t= typeof(MyClass);
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.Name);
            Console.WriteLine(t.Namespace); 
            Console.WriteLine(t.Assembly);
            //查看类的所有字段
            FieldInfo[] fis = t.GetFields();
            foreach (FieldInfo fi in fis)
            {
                Console.WriteLine(fi.Name);
            }
            //查看类的所有属性
            PropertyInfo[] pis= t.GetProperties();
            foreach (PropertyInfo pi in pis)
            {
                Console.WriteLine(pi.Name);
            }
            //查看类的所有方法
            MemberInfo[]mi= t.GetMembers();
            foreach(MemberInfo pi in mi) { Console.WriteLine(pi.Name); }
            //Type查看程序当中每一个类（元数据）的类型，比如获取类的名称，名称空间。程序的特性，私有的不能反射
            //查看这个类的属性
            //查看类的方法
            //查看类的对象的，和查看类的type是一样的
        }
    }
}
