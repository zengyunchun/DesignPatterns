using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class ChineseBonus : Bonus
    {
        public override double Caculate()
        {
            return Constant.DB_BASE_SALARY * 0.1;
        }
    }
}
