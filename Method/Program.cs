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
            GetName("狗蛋");
            Console.ReadKey();
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
