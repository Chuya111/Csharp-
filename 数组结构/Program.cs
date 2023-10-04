using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace 数组结构
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        //线性表：计算长度，插入元素，删除元素，改元素，查找元素（遍历读取和取出），复制线性表，合并线性表
        //一维数组
        //打印1-max的质数,所有就是数组
        //static int primenumber(int n)
        //{
        //    List<int> list = new List<int>();
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (n % 2 == 0)
        //        {
        //            return;
        //        }
        //        list.Add(i);
        //    }
            
        //}
        //数组是竖着来的
        int[]array1=new int[4];//一维数组，元素数量为1
        int[,]array2=new int[1,2];//二维数组，元素数量为1，2
        int[,,]array3=new int[1,2,3];
        //写入元素的值，读取元素
        //给数组的元素设置值
        static void myarray1()//给数组的每一个元素设置值
        {
            int[] myarray = new int[4];
            for (int i = 0; i < 4; i++)
            {
                myarray[i] = i;
            }
        }
        //初始化数组
        int[] array11=new int[4] { 1,2,3,4};
        static int[,] array22=new int[,] { {1,2} , {3,4} , {7,8} };//new int可以省略
        static void myarray2()
        {
            for (int i = 0;i < 3; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    array22[i,j] = i+j;//索引到的这个值只是一个数
                }
            }
        }
        //矩阵
        int[,] matrixA = new int[3, 3] { {1,3,5},{7,9,11},{13,15,17} };
        int[,] matrixB = new int[3, 3] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
         void addmatrix(int[,] arrA, int[,]arrB, int[,] arrC)//把C传进来，就可以传出去
        {
            matrixA + matrixB;
        }


    }
}
