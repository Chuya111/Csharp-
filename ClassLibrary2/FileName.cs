﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    internal class FileName
    {
        //数组：矩形数组（一维数组，二维数组），交错数组。数组包括元素，维度（区分一维和二维），维度长度（几个1234这种），数组长度（区分矩形和交错）
        int[] myArray = new int[5];//一维数组，数组长度=5（0，1，2，3，4）维度长度=5
        int[,] myArray1 = new int[3,6];//二维数组，数组长度=18，矩阵3*6，维度长度=6/3





        //方法：
        
        
        public void method()
        {
            //方法的结构——方法头，方法体（本地变量，控制流结构（选择语句，迭代语句，跳转语句），方法调用，内嵌的块

            var total = 15;//可以显而易见的知道=右边的数据类型是用var关键字,不能用于字段，是推断的速记，var不能改变
                           //本地变量的生存期：声明他们的块和嵌套块，局部变量的有效期，出了声明的地方就是无效的
                           //调用方法：debugf11的道理
                           //返回值，有返回类型的方法必须带return，void时可以用return;提前退出方法
                           //(":{0}",x)用x替换0
        }
        //参数和局部变量起到的作用有相似之处，都是拿来储存数据

        //方法的参数——形参和实参，值参数和引用参数（？引用类型作为这两种？）输出参数
        //调用方法时初始化形参的参数称为实参，
        //值参数，为形参分配内存，在方法前面声明的值类型的实参当然不会受到方法的影响，方法开始他的值被复制为方法调用的形参，方法只改变形参的数据，结束后形参失效对于本身不影响
        //但是引用类型的实参会被方法的行为改变，因为将实参复制的形参任然是引用实参的数据，指向共同的数据，指向的数据改变了，本身也被改变
        //k+j也是值参数（实参复制到形参向方法传递数据），

        //引用参数：方法结束后值改变，在方法前面声明的值类型的实参，方法开始形参被设置为实参的别名，引用相同的内存，
        //方法改变了共同的数据，结束后实参值该百年
        //引用类型引用类型的实参会被方法的行为改变，因为将实参复制的形参任然是引用实参的数据，指向共同的数据，指向的数据改变了，本身也被改变
        public static void meth1(ref int y)
        {
            Console.WriteLine("引用参数");
        }
        public static void methodref()
        {
            int y = 0;
            meth1(ref y); // 在 Main 方法中调用 Meth1 方法
            Console.WriteLine(y); // 输出修改后的 y 值
        }
        //引用类型作为值参数和引用参数——不是都会改变吗？

        //输出参数传出的是改变过后的实参，和引用参数很相似，先在方法内部被赋值再被读取，

        //参数数组



        //结构——装箱和拆箱？
    }
}