using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Student
    {
        private string _name;
        private int _marks;

        public string Name
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Name Cannot be Empty");
                }
                this._name = value;
            }

            get
            {
               
                return this._name;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            //stud._name = "Vishal";  throws compile time error because declared as private
            stud.Name = "Vishal";
            Console.WriteLine(stud.Name);

        }
    }
}
