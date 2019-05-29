using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    /// <summary>
    /// 抽象工厂
    /// </summary>
    public abstract class AbstractFactory
    {
        public static AbstractFactory GetInstance()
        {
            string factoryName = Constant.STR_FACTORY_NAME;
            AbstractFactory result;
            if (string.IsNullOrEmpty(factoryName))
            {
                result = null;
            }
            else
            {
                // 通过反射，用字符串创建实例
                result = (AbstractFactory)Assembly.Load(factoryName).CreateInstance(factoryName);
            }
            return result;
        }

        public abstract Tax CreateTax();

        public abstract Bonus CreateBonus();
    }
}
