using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("程序开始");

            var tmp = Singleton.LockSingleton.Instance;

            Console.ReadKey();
        }
    }
}
