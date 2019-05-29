using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    /// <summary>
    /// 税收的抽象工厂, 规定计算接口
    /// </summary>
    public abstract class Tax
    {
        public abstract double Caculate();
    }
}
