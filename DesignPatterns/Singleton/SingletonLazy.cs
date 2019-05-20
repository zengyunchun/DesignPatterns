using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /// <summary>
    /// Lazy模式，更少的代码，更优的性能
    /// </summary>
    public sealed class SingletonLazy
    {
        private SingletonLazy()
        {

        }

        // 用lazy的方式惰性实例化单例，代码最小，性能最好
        public static SingletonLazy Instance = new Lazy<SingletonLazy>(() => new SingletonLazy()).Value; 
    }
}
