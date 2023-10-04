using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary2
{
    internal class 混淆概念
    {
    }
    //构造函数，构造函数带不带参数意味着new class()的()里带不带参数，（接受什么样的参数）构造函数的{}也就是创建新实例式的初始化{}初始化什么样

    //实例构造函数：创建对象的函数，创建语法
    class myconstruct1
    {
        public int ID;
        public string Name;
        public myconstruct1() { ID = 28; Name = "Nemo"; }
        public myconstruct1(int val) { ID = 28; Name = "Nemo"; }
        public myconstruct1(string Name) { ID = 28; Name = "Nemo"; }//实参传进方法之后被复制，形参被改变，结果和实参无关
        public void SoundOff()
        {
            Console.WriteLine("Name{0},ID{1}", Name, ID);
        }
        //构造函数特点，名字和类相同，没有返回值
    }
    class experiment
    {
        static void experiment1()
        {
            myconstruct1 a = new myconstruct1();
            myconstruct1 b = new myconstruct1(1);
            myconstruct1 c = new myconstruct1("irene");
            //一个类可以有多个构造函数，这是为了提供不同的初始化方式和灵活性。
            //多个构造函数允许在创建类的实例时提供不同的参数集或以不同的方式初始化对象，
            //以满足不同的需求和使用情况:可以使用默认值，可以接受不同类型的参数，采用不同的初始化方法，类似多态
            //不创建的话会有一个隐式构造函数类似于public myconstruct1() { }，但是一旦创造的话不能用隐式的，除非再创造一个和隐式一样的
            myconstruct1 d = new myconstruct1() { ID = 20, Name = "Momo" };
            //对象初始化语句，不是构造函数，直接你创建对象时跟上{}，注意{}里面的东西类里面要有，要可以访问，public，
            //初始化发生在构造函数之后，即构造函数里面的方法会被初始化语句替换掉
            a.SoundOff();
            b.SoundOff();
            c.SoundOff();
            d.SoundOff();

            MyClass obj = new MyClass();
            obj.MyProperty = 42; // 设置属性值
            int value = obj.MyProperty; // 获取属性值
        }
    }




    //静态构造函数，static关键字，不能带参数，只能有一个，不能有访问修饰符，不能用this





    //this关键字——实例，this是实例的占位符，调用实例方法当然要创建实例，this 关键字用于引用当前对象的实例
    //对当前实例的引用，所以不能用在静态中，可以用在类成员如！！实例构造函数，实例方法，属性和所引起的实例访问其中，
    //目的：区分类的本地成员和参数，作为调用方法的实参？举例子


    //访问修饰符：到底什么时候该用public和private感觉都可以public啊：类的外部需要访问这个设置为public


    //设置属性值和获取属性值
    public class MyClass
    {
        private int myValue; // 私有字段

        // 可写属性定义，用于设置和获取私有字段的值
        public int MyProperty
        {
            get
            {
                // 获取属性值
                return myValue;
            }
            set
            {
                // 设置属性值
                myValue = value;
            }
        }
    }
    


}
