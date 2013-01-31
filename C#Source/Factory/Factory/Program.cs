using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {             
                try
                {

                    Console.WriteLine("请输入数字A");
                    String strA = Console.ReadLine();
                    Console.WriteLine("请输入数字B");
                    String strB = Console.ReadLine();
                    Console.WriteLine("请输入操作命令 如 + - * %");
                    String strCmd = Console.ReadLine();

                    Operation oper;
                    oper = OperitionFactory.createOperiton(strCmd);

                    oper.NUM_A = Convert.ToDouble(strA);
                    oper.NUM_B = Convert.ToDouble(strB);
                    Console.WriteLine(Convert.ToString(oper.getResult()));               
                }
                catch (Exception ex)
                {
                    Console.WriteLine("请检查输入是否有错" + ex.Message);
                }
            }
            Console.ReadLine();
        }
    }
}
