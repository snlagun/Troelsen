using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {

            var t = new TestClass();
            Console.WriteLine(t.SetProp1);
            t.SetProp1 = 2;
            Console.WriteLine(t.SetProp1);

           
            var t2 = new TestClass();
            Console.WriteLine(t2.mProp1);
            t2.mProp1 = 0;
            Console.WriteLine(t2.mProp1);
            Console.WriteLine(t.SetProp1);


            var t3 = new TestClass();
            Console.WriteLine(t3.SetProp1);
            t3.SetProp1 = 2;
            Console.WriteLine(t3.SetProp1);
            Console.WriteLine(t.SetProp1);
            Console.ReadLine();
        }
    }
}
