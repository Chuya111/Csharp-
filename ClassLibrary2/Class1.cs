using System.ComponentModel;

namespace ClassLibrary2
{
    public class Class1
    {
        delegate void mydel();//委托在类外面使用？
        delegate int mydel1(int x,int y);
        delegate T dele3<T>(T x, T y);//后面的<T>是针对后面的圆括号参数而言
        //action和func不用声明
        static void Main()
        {
            //16章转换


            //委托——可以将方法作为参数传进去

            //基本委托的知识：声明委托：注意委托和方法返回值和传入参数的一致，实例化委托的时候（可以用new也可以用语法糖，把方法名称M1传进来而非参数
            //M1（）分为静态方法和实例方法，注意实例方法的写法，调用委托可以用.invoke（）或者不用直接写（）

            mydel dele1 = new mydel(M1);//()里面要写一个静态方法，或者语法糖直接写成 mydel dele1 = 方法，注意传进来的是M1而非M1（）
            Student student = new Student();
            dele1 = student.sayhello;//给委托一个实例方法
            dele1 += (new Student()).sayhello1;//简化写法
            dele1.Invoke();//语法糖是dele1();
            mydel1 dele2 = (new Student()).sayhello2;//实例化一个委托里面的方法
            int res=dele2(2,3);//调用委托，那如果委托里面很多呢？创建两个委托实例，分别使用两个方法
                               //委托等同于间接调用方法
                               //一个委托对应一个方法或者使用回调委托的形式，根据条件选择具体的方法
            //泛型委托，解决类膨胀的问题，但是前提在于形参的数量和类型有共同点，但是实际上调用委托还是要相互对应的。
            //自己定义泛型委托
            dele3 <int> delgoodbye = (new Student()).saygoodbye;//等同于dele3 <int> delgoodbye = new dele3 ((new Student()).saygoodbye);
            dele3<double> delbye = (new Student()).bye;
            //准备好的有action和fun，省略声明
            Action<int> action = (new Student()).sayhello3;//泛型委托只要带<>一定是有参数
            Action action0 = (new Student()).sayhello;
            action(5);

            //func 返回值类型
            Func<int, int, int> delgoodbye1 = (new Student()).saygoodbye;//对比dele3 delgoodbye ，等同于整合了声明和实例
            int reselgoodbye1= delgoodbye1(3,4); //调用的时候只写名称和参数


            //lambda表达式
            //1.匿名方法，不写名字的函数 2.inline方法
            Func<int,int,int>funclambda=((int a,int b) => {return a+b;});//委托实例方法用lambda表达式
                                                                         //lambda表达式用圆括号写成，（（参数）=>{方法体}）
            funclambda = (a, b) => { return a + b; };//常用的语法糖，lambda表达式作为实参传进去
            DoSomething(( a, b) => { return a + b; }, 100, 200);//100可以推断出T的类型，就不用写了


        }
        static void DoSomething<T>(Func<T, T, T> func, T x, T y)//这里也没有写委托=方法，如果方法和委托是匹配的可以不用实例赋值，推断类型即可
        {
             T res =  func(x, y);
            Console.WriteLine(res);

        }
        //泛型，5种泛型（泛型类，泛型结构？泛型接口。泛型委托，泛型方法）
        //构造类型和类型实参的意思就是在真正用的时候，需要用真实的类型如int等去替换占位符T
        //class mystack<T>
        //{
        //    T[] StackArray;//?
        //    int StackPointer = 0;
        //    public void Push(T value)
        //    { if( !IsStackFull)//?
        //            StackArray[StackPointer++] = value; 
        //    }
        //    public T Pop()
        //    { 
        //        return ( !IsStackEmpty)
        //            ? StackArray[StackPointer]; 
        //        :  StackArray[0];
        //    }
        //    const int MaxStack = 10;
        //    bool IsStackFull { get { return StackPointer >= MaxStack; } }
        //    bool IsStackEmpty{ get { return StackPointer <= 0; } }
        //}
        //声明泛型类

        //创造构造类型和类型实参
        //在C#中，使用"="操作符分配引用，使用"new"操作符创建实例。
        //类型参数的约束  where子句 ： 
        class myclass<T1, T2,T3>//T1没有约束
            where T2:CustomTypeDescriptor//没有分隔符
            where T3: IComparable//T3的约束，只有实现IComparable的接口的类才能用于类型实参
        {
            
        }
        //多个约束的规则：顺序
        public class Example<T> where T : class,IComparable, ICloneable, new()//有分隔符
        {
            // T 必须同时实现 IComparable 和 ICloneable 接口，并且具有无参数构造函数
        }
        //声明泛型方法
        public void DoStuff<T1,T2>(T1 t1, T2 t2)
        {
            T1 somevar = t1;
            T2 somevar2 = t2;
        }
        //调用泛型方法
        public void CallDoStuff()
        {
            int x = 1;
            int y = 2;
            DoStuff(x, y); // 在方法内部调用泛型方法，调用方法要有前后文
                           // 泛型方法 DoStuff 的调用应该位于方法、属性或类的构造函数等包含上下文的地方，而不能直接放在类的定义中。
        }


        class someclass<T1, T2>
        {
            public T1 SomeVar;
            public T2 OtherVar;
        }
        someclass<short,int> /*short 和int 就是类型参数实参*/ mysc1= new someclass<short,int>();
        //

        static void M1()
            {
                Console.Write("M1"); 
            }//写一个方法，返回类型和传入参数要和委托一致
            class Student
            {
                public void sayhello() { Console.Write("student"); }
                public void sayhello1() { Console.Write("student1"); }
                public void sayhello3(int a) { Console.Write("student3"); }
                public int sayhello2(int a,int b)
                {
                    //return a+b; //不用写c=a+b吗
                int c = a + b; return c;
                }
            public int saygoodbye(int a, int b) { return a+b; }
            public double bye(double a, double b) { return a + b; }
        }
        //

    }
}