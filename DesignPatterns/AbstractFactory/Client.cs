using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class Client
    {
        public static void Main(string[] args)
        {
            AbstractFactory instance = AbstractFactory.GetInstance();

            double bonus = instance.CreateBonus().Caculate();
            double tax = instance.CreateTax().Caculate();
            double salary = Constant.DB_BASE_SALARY + bonus - tax;
        }
    }
}
