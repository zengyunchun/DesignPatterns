using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    /// <summary>
    ///  定义常量
    /// </summary>
    public static class Constant
    {
        public static double DB_BASE_SALARY = 4000;

        public static string STR_FACTORY_NAME = ConfigurationSettings.AppSettings["FactoryName"];
    }
}
