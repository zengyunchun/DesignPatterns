using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class ChineseFactory : AbstractFactory
    {
        public override Bonus CreateBonus()
        {
            return new ChineseBonus();
        }

        public override Tax CreateTax()
        {
            return new ChineseTax();
        }
    }
}
