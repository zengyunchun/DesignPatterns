using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class AmericanFactory : AbstractFactory
    {
        public override Bonus CreateBonus()
        {
            return new AmericanBonus();
        }

        public override Tax CreateTax()
        {
            return new AmericanTax();

        }
    }
}
