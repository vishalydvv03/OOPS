using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine("Your Name is " + FirstName + " " + LastName);
        }


    }

    public class SoftwareDev : Employee
    {
        public string Project;

    }

    public class Analyst : Employee
    {
        public string Business;

    }

    class Program
    {
        static void Main(string[] args)
        {
            SoftwareDev dev = new SoftwareDev();
            dev.FirstName = "Vishal";
            dev.LastName = "Yadav";

            dev.PrintFullName();

            dev.Project = ".Net Application";
            Console.WriteLine(dev.Project);

            Analyst analyst = new Analyst();
            analyst.Business = "Generating Insights";
            Console.WriteLine(analyst.Business);
            
        }
    }
}
