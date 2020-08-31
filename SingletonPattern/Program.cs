using SingletonPattern.SingletonPattern.V1_NotThreadSafe;
using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var SingletonObject1 = Singleton.Instance;
            var SingletonObject2 = Singleton.Instance;

            if (Object.Equals(SingletonObject1, SingletonObject2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.ReadLine();
        }
    }
}
