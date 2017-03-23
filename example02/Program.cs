using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(MyBaseC.MyStruct.x);
        }

        public class MyBaseC
        {
            public struct MyStruct
            {
                public static int x = 100;
            }
        }
    }
}