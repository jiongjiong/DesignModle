using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    public class Operation
    {
        private double numA, numB;
        public double NUM_A
        {
            get { return numA; }
            set { numA = value; }
        }
        public double NUM_B
        {
            get { return numB; }
            set { numB = value; }
        }
        public virtual double getResult()
        {
            double result = 0;
            return result;
        }

    }

    class OperationAdd : Operation
    { 
        public override double getResult()
        {
            double result = 0;
            result = NUM_A + NUM_B;
            return result;
        }
    }
    class OperationSub : Operation
    {
        public override double getResult()
        {
            return NUM_A - NUM_B;
        }
    }

    class OperationMul : Operation
    {
        public override double getResult()
        {
            return NUM_A * NUM_B;
        }
    }

    class OperationDev : Operation
    {
        public override double getResult()
        {
            double result = 0;
            if (NUM_B == 0)
            {
                throw new Exception("除数不能够为 0");
            }
            else
            {
                result = NUM_A / NUM_B;
            }
            return result;
        }
    }

    public class OperitionFactory
    {
        public static Operation createOperiton(String operation)
        {
            Operation oper = null;

            switch(operation)
            {
                case "+":
                    {
                        oper = new OperationAdd(); 
                        break;
                    }
                case "-":
                    {
                        oper = new OperationSub();
                        break;
                    }
                case "*":
                    {
                        oper = new OperationMul();
                        break;
                    }
                case "/":
                    {
                        oper = new OperationDev();
                        break;
                    }
                default:
                    {
                        throw new Exception("输入操作符出错");
                    }
            }
            return oper;
        }
    }
}
