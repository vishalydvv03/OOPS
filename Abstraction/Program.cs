using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    //abstract class Person
    //{
    //    public void Walk()
    //    {
    //        Console.WriteLine("I can walk");
    //    }

    //    public abstract void Greet();
    //}

    interface IPerson
    {
        void Greet();
    }
    
    class Student : IPerson
    {
        public string Name;

        public void Greet()
        {
            
            Console.WriteLine("Hello " + Name);

        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            stud.Name = "Vishal";
            stud.Greet();
        }
    }
}
