using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacelearn
{
    internal class Program
    {
        static object Main(string[] args)
        {

            var driver1 = new driver(new car());
            driver1.drive();


            var vivoz5 = new vivo();
            vivoz5.call();//实现接口的类创建实例自己直接调用方法
            var oppox11 = new vivo();
            var me = new phoneuser(vivoz5);//vivoz5可以替换成oppox11，重复的东西复用
            me.usephone();//间接调用，更好，因为可以复用
        }

    }
    class phoneuser
    {
        private Iphone _phone;
        public phoneuser(Iphone phone)
        {
            _phone = phone;
        }
        public void usephone()//实现接口的类有接口共同的方法
        {
            _phone.call();
            //_phone.message();
            //_phone.photo();
            //_phone.browse();
        }
    }
    interface Iphone
    {
        void call();
        void message();
        void photo();
        void browse();
    }
    class vivo : Iphone
    {
        public void browse()
        {
            Console.WriteLine("browse news");
        }

        public void call()
        {
            Console.WriteLine("call mom");
        }

        public void message()
        {
            Console.WriteLine("send message");
        }

        public void photo()
        {
            Console.WriteLine("take photos");
        }
    }
    class oppo : Iphone
    {
        public void browse()
        {
            Console.WriteLine("tiktok");
        }

        public void call()
        {
            Console.WriteLine("call dad");
        }

        public void message()
        {
            Console.WriteLine("send 111");
        }

        public void photo()
        {
            Console.WriteLine("take pictures");
        }
    }






    //依赖反转/

    //接口隔离原则0：18

    class driver
    {
        private Ivehicle _vehicle;
        public driver(Ivehicle vehicle)//对Ivehicle和它的子类都适用
        {
            _vehicle = vehicle;
        }
        public void drive()
        {
            _vehicle.run();
        }
    }
    interface Ivehicle
    {
        void run();
    }

    class car : Ivehicle
    {
        public void run() { Console.WriteLine("car is running"); }

    }
    class truck : Ivehicle
    {
        public void run() { Console.WriteLine("truck is running"); }

    }
    interface Ifire
    {
        void fire();
    }
    interface Itank: Ivehicle, Ifire
    {
        void run();
        void fire();

    }


    //反射：不用new操作符


}
