using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.SingletonPattern.V1_NotThreadSafe
{
    // Bad code! Do not use!
    public sealed class Singleton
    {
        private static Singleton instance = null;

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
