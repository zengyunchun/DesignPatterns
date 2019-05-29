using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    /// <summary>
    /// 美国的个人所得税
    /// </summary>
    public class AmericanTax : Tax
    {
        public override double Caculate()
        {
            return (Constant.DB_BASE_SALARY + (Constant.DB_BASE_SALARY * 0.1)) * 0.4;
        }
    }
}
