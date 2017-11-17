using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBonusCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter your full name");
            string name = Console.ReadLine();
            Console.WriteLine("Please Enter your salary");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Years of Experience");
            int experience = int.Parse(Console.ReadLine());

            Employee myEmployees = new Employee()
            {
                Name = name,
                Salary = salary,
                Experience = experience
            };

            myEmployees.CalculateBonus();
                Console.ReadLine();
            

        }
    }
}
