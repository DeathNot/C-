using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Li;

namespace NamespaceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Qg oa = new Qg();
            oa.Myls();
        }
    }
}

namespace Li
{
    class Qg
    {
        public void Myls()
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
