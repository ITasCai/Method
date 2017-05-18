using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //  GetName("狗蛋");
            Console.WriteLine("请输入第一个数：");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("请输入第二个数：");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int max= GrtMax(num1,num2);
            Console.WriteLine("最大值为：{0}",max);
            Console.ReadKey();
        }

        /// <summary>
        /// 判断两个数的最大值
        /// </summary>
        /// <param name="v1">值1</param>
        /// <param name="v2">值2</param>
        private static int GrtMax(int v1, int v2)
        {
            if (v1>v2)
            {
                return v1;
            }
            else
            {
                return v2;
            }
        }

        /// <summary>
        /// 有参数的方法
        /// </summary>
        /// <param name="name">姓名</param>

        private static void GetName(string name)
        {
            Console.WriteLine("欢迎您:{0}",name);
        }
    }
}
