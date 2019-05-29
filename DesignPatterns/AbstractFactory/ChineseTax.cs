using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class ChineseTax : Tax
    {
        public override double Caculate()
        {
            return (Constant.DB_BASE_SALARY + (Constant.DB_BASE_SALARY * 0.1)) * 0.4;
        }
    }
}
