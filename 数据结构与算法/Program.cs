using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构与算法
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"5!={digui(5)}");//$"插值字符串{f(x)}"最后打印出：插值字符串f(x)
            Console.WriteLine($"5!={Fibonacci(5)}");
            Console.WriteLine($"5de jiechengshi{jiecheng(5)}");
            Console.WriteLine($"5!={meiju()}");
            Console.WriteLine($"5!={beishu5()}");
        }
        //分治法，一个方法拆成多个小方法
        //递归法：需要调用自己的子部分
        //动态规划法？咋储存
        static int digui(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * digui(n - 1);
            }
        }
        static int[] output = new int[1000];
        static int Fibonacci(int n)
        {
            int result;
            result = output[n];//先初始化
            if (result == 0)
            {
                if (n == 0)
                {
                    return 0;

                }
                else if (n == 1)
                {
                    return 1;
                }
                else
                {
                    return digui(n) + digui(n - 2);
                }
            }
            output[n] = result;
            return result;
        }
        //贪心法？？？不理解
        
        //迭代法
        static int jiecheng(int n)
        {
            int sum = 1;
            for (int i = 1; i < n; i++)
            {
                for(int j = i; j > 0; j--)
                {
                    sum = sum * j;
                }
                //sum = 1;
            }
            return sum;
        }
        //枚举法
        static int meiju()
        {
            var n = 1;
            int sum = 1000;
            while (sum >= 0)
            {
                sum -= n;
                n+=1;
            }
            return n;
        }
        static List<int> beishu5()
        {
            List<int> multiplesOf5 = new List<int>();
            for (int i = 0; i < 100; i++) 
            {
                if ((i % 5) == 0) { multiplesOf5.Add(i); }
            }
            return multiplesOf5;
        }
    }
}
