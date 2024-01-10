using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var log = Singleton.Log.Instance;
            log.Save("a");
            log.Save("b");

            var a = Singleton.Singleton.Instance;
            var b = Singleton.Singleton.Instance;

            Console.WriteLine(a == b);
        }
    }
}
