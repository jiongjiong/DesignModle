using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace strategy
{
    abstract class cashSuper
    {
        public abstract double acceptCrash(double money);
        
    };

    class normalCrash : cashSuper
    { 
        public  override double acceptCrash(double money)
        {
            return money;
        }
    };

    class CashRebate : cashSuper
    {
        private double moneyRebate = 1d;

        public CashRebate(String strMoneyRebat)
        {
            this.moneyRebate = double.Parse(strMoneyRebat);
        }

        public override double acceptCrash(double money)
        {
            return money * moneyRebate;
        }
    };

    class CashReturn : cashSuper
    {
        private double moneyCondition = 0;
        private double moneyReturn = 0;

        public CashReturn(string mCondition, string mReturn)
        {
            this.moneyCondition = double.Parse(mCondition);
            this.moneyReturn = double.Parse(mReturn);
        }
        public override double acceptCrash(double money)
        {
            //)throw new NotImplementedException();
            if (money > moneyCondition)
            {
                return money - moneyReturn;
            }
            return money;
        }
    };


    class cashContext
    {
        private cashSuper cs;

        public cashContext(string strCmd)
        {
            switch (strCmd)
            {
                case "1":
                    {
                        cs = new normalCrash();
                        break;
                    }
                case "2":
                    {
                        cs = new CashRebate("0.8");
                        break;
                    }
                case "3":
                    {
                        cs = new CashReturn("300", "100");
                        break;
                    }
                default:
                    {
                        cs = null;
                        break;
                    }
            }
        }

        public double GetResult(double money)
        {
            if (cs != null)
            {
                return cs.acceptCrash(money);
            }
            else
            {
                return 0;
             }
        }
    };
}
