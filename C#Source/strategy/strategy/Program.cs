using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("请输入金钱");
                string money = Console.ReadLine();
                Console.WriteLine("请输入方式");
                string strCmd = Console.ReadLine();
                cashContext cc = new cashContext(strCmd);
                double totalPrace = 0;

                totalPrace = cc.GetResult(Convert.ToDouble(money));
                Console.WriteLine("结果为 ："+ totalPrace.ToString());
            }

        }
    }
}
