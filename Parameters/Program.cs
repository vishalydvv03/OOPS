using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static int Change(out int a)
        {
            a = 0;
            return a+30;  //when using out, it needs to be initialized inside the function
        }
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            // Before Ref
            //Swap(x, y);
            //Console.WriteLine("x= " + x + " y= " + y);
            Swap(ref x, ref y);
            Console.WriteLine("x= " +x + " y= " +y);

            x= Change(out x);
            Console.WriteLine(x);
        }
    }
}
