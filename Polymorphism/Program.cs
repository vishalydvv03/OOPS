using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Operations 
    {
        public virtual int Add(int x, int y)
        {
            return x + y;
        }

        public virtual int Sub(int x, int y)
        {
            return x - y;
        }

    }

    public class Addition : Operations
    {
        public override int Add(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        //Method Overloading -> Compile Time Polymorphism
        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Addition op = new Addition();

            Console.WriteLine(op.Add(2,3));
            Console.WriteLine(op.Add(2,3,4));
        }
    }
}
