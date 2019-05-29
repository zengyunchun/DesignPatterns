using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    /// <summary>
    /// 奖金的抽象工厂, 规定计算接口
    /// </summary>
    public abstract class Bonus
    {
        public abstract double Caculate();
    }
}
