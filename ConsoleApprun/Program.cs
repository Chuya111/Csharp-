using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApprun
{

    //怎么调用委托的，声明委托（委托对应方法的返回值类型，方法的参数），委托=方法，调用委托invoke或者dele()

    //事件是先有一个为事件而生的委托EventHandler，事件信息EventArgs（委托的参数）
    //事件拥有者——类（委托类型字段（存储事件处理器），事件（通过add,remove把事件处理器传递到委托类型字段中），触发事件，调用自己）
    //事件响应者——类（事件处理器——参数和返回值类型注意和EventHandler委托一致）
    //主程序——创建事件拥有者和事件响应者的实例对象，然后事件拥有者.事件+=事件响应者.事件处理器

    //事件命名约定
    //事件委托类型：fooEventHandler,事件信息fooEventArgs，触发事件：Onfoo,事件：动词
    internal class Program
    {
        //事件:表层约束和底层实现都是依赖于委托的，字段的封装器，形成约束，不能随意调用，字段可以随意访问，事件不可以

        //声明事件：先把前面这段代码桥明白了

        //业务场景：顾客点菜，事件拥有者：顾客，事件：点菜；订阅事件，事件响应者：服务员，事件处理器：Action

        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Waiter waiter = new Waiter();
            customer.Order += waiter.Action;//订阅事件，事件的五要素
            customer.action();//只有customer才可以触发事件，如果事件消失成为委托字段的话，这里调用触发方法
            customer.PayTheBill();   
        }  
    }
    public delegate void OrderEventHandler(Customer customer,OrderEventArgs e);
                                             //这个委托是用来约束事件处理器的，实例储存事件处理器，eventargs传递事件信息
    //不用声明，直接使用提供好的EventHandler
    
    public class OrderEventArgs:EventArgs//传递事件信息事件的内容,保持访问级别一致
    {
        public string DishName { get; set; }
        public string Size { get; set; }
    }

    public class Customer//事件拥有者
    {
        private OrderEventHandler orderEventHandler;//委托类型的字段——怎么存储事件处理器？？？是什么
        public event OrderEventHandler Order//声明事件？为什么是add
        {
            add //添加器
            {
                this.orderEventHandler += value;//value就是事件处理器？
            } 
            remove 
            {
                this.orderEventHandler -= value;
            }
        }
        //简化类型：public event OrderEventHandler Order；
        public void walkin()
        { 
            Console.WriteLine("walkin");
        
        }
        public void sitdown()
        {
            Console.WriteLine("sit down");

        }
        public void Think()
        {
            for (int i = 0;i<5;i++)
            {
                Console.WriteLine("let me think");
                Thread.Sleep(1000);
            }
            this.OnOrder("kongbao chicken", "large"); //传参数，补充完善事件的菜品信息,触发事件onfoo
        }
        protected void OnOrder(string dishName,string size)//触发事件必须由事件拥有者来做,
        {
            if (this.orderEventHandler != null)//有人处理这个事件，注意一定要写
            {
                OrderEventArgs e = new OrderEventArgs();
                e.DishName = dishName;
                e.Size = size;
                this.orderEventHandler.Invoke(this, e);//调用这个委托
            }
            //！！！简化类型将字段改为事件
        }

        public void action()
        {
            Console.ReadLine(); 
            this.walkin();
            this.sitdown();
            this.Think();
        }

        public double Bill { get; set; }
        public void PayTheBill()
        {
            Console.WriteLine("I will pay${0}", this.Bill);
        }
    }
    public class Waiter//事件响应者
    {
        internal void Action(Customer customer, OrderEventArgs e)//事件处理器，就是委托的方法
                                                                 //(object sender, EventArgs e)
                                                                 //注意做类型转换Customer customer=sender as Customer;OrderEventArgs e=e as EventArgs

        {
            Console.WriteLine("i will serve you the dish-{0}", e.DishName);
                double price = 10;
            switch (e.Size) 
                { case "small":
                    price = price * 0.5;
                    break;
                case "large":
                    price =price * 1.5; 
                    break;
                default:
                    break;                 
            }//switch(里面的东西要和1的类型对应上){case1:;break;....default:break}
            customer.Bill +=price;
        }
    }

    //简化版（默写）


    //构造函数特点，名字和类相同，没有返回值
    class myconstruct1
    {
        int ID;
        string Name;
        public myconstruct1() { ID = 28; Name = "Nemo"; }
        public myconstruct1(int val) { ID = 28; Name = "Nemo"; }
        public myconstruct1(string Name) { ID = 28; Name = "Nemo"; }//实参传进方法之后被复制，形参被改变，结果和实参无关
        public void SoundOff()
        {
            Console.WriteLine("Name{0},ID{01}", Name, ID);
        }
        
    }




    //语句
    //switch语句——后面跟的是常量表达式//表达同一种情况可以连起来写，一般用的是switch表达式和lambda的结合体

    //循环语句：while(true){最后得用一种情况判断为false或者break}
    //for语句——遍历
    private class Yuju
    {
        static void Yuju1()
        {
            for (int i = 0/*初始值,i的前面总是需要类型*/; i < 3/*条件*/; i++/*执行完逻辑之后，i怎样，进行下一步的操作*/)
            //先判断i < 3这个条件——如果是true就执行语句——执行之后i++/i--，直到条件为false
            {/*语句体*/ }
            const int maxi = 5;
            for (int i = 0, j = 10; i < maxi; i++, j += 10)
            {

            }
        }
    }

    //for each语句
    //————元组和数组的区别：元组=（x,y）xy不需要是同一个类型的数据，访问的时候写元组.item1——（int ,int)名字
    //数组[a,b]ab需要是同一类型的数据，访问的时候写数组[0]——int[]名字

}
