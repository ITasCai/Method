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
            #region 求两个数的最大值


            //  GetName("狗蛋");
            //Console.WriteLine("请输入第一个数：");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("请输入第二个数：");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int max= GrtMax(num1,num2);
            //Console.WriteLine("最大值为：{0}",max);
            //Console.ReadKey();
            #endregion

            #region 求圆的面积


            //Console.WriteLine("输入圆的半径：");
            //double r = Convert.ToDouble(Console.ReadLine());
            //double area = CircleArea(r);
            //Console.WriteLine("圆的面积为：{0}",area);
            //Console.ReadKey();

            #endregion

            #region  交换两个数字

            //int n1 = 10, n2 = 20;

            //Swap(ref n1, ref n2);

            //Console.WriteLine("n1={0},n2={1}", n1, n2);
            //Console.ReadKey();

            #endregion

            #region  输出参数


            //int n1, n2 ;

            //ChangeOut(out n1, out n2);

            //Console.WriteLine("n1={0},n2={1}", n1, n2);
            //Console.ReadKey();


            #endregion


            #region 求数组中的最大值

            int max = MaxArray(99,101,66,77,528,152,77);
            Console.WriteLine("最大值为：{0}",max);
            Console.ReadLine();


            #endregion
        }

        /// <summary>
        /// 求数组最大值
        /// </summary>
        /// <param name="arr">数组</param>
        /// <returns>返回最大值</returns>
        private static int MaxArray(params int[]arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
            }
            }
            return max;
        }


        /// <summary>
        /// 输出参数
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        private static void ChangeOut(out int n1, out int n2)
        {
            n1 = 20;
            n2 = 30;
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }




        /// <summary>
        /// 引用传递
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        private static void Swap(ref int n1, ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }

        /// <summary>
        /// 求圆的面积
        /// </summary>
        /// <param name="r">半径</param>
        /// <returns>返回圆的面积</returns>
        private static double CircleArea(double r)
        {
            const double PI = Math.PI;
            double area = PI * (r * r);
            return area;
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
