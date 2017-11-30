using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_test2
{
    class Program
    {
        class Li
        {
            public int Value = 0;
        }

        static void Main(string[] args)
        {
            int v1 = 0;
            int v2 = v1;
            v2 = 927;
            Li r1 = new Li();
            Li r2 = r1;
            r2.Value = 112;
            Console.WriteLine("Value:{0},{1}", v1, v2);
            Console.WriteLine("Refs:{0},{1}", r1.Value, r2.Value);
            Console.ReadLine();
        }
    }
}
