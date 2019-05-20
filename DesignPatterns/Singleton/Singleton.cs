using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /// <summary>
    /// 普通单例模式
    /// </summary>
    public class Singleton
    {
        private Singleton()
        {

        }

        private static readonly object instancelock = new object();

        public static Singleton Instance
        {
            get
            {
                if (instance == null) // 不是每次加锁，解决性能问题
                {
                    lock (instancelock) // 加锁线程安全
                    {
                        if (instance == null) // 再次判断，确保当前线程中实例没有创建
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }
        private static Singleton instance;
    }
}
