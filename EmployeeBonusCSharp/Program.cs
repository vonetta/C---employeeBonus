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
            Employee myEmployees = new Employee();

            Console.WriteLine("Please Enter your full name");
           string name = Console.ReadLine();
            bool success;
            decimal mySalary;

            do
            {
                Console.WriteLine("Please Enter your salary");
                string salary = Console.ReadLine();
                success = decimal.TryParse(salary, out mySalary);
            } while (!success);
          
            myEmployees.Salary = mySalary;


            Console.WriteLine("Please Enter Years of Experience");
            int experience = int.Parse(Console.ReadLine());  

           decimal bonus = myEmployees.CalculateBonus();
            Console.WriteLine(bonus);
                Console.ReadLine();
            }
    }
}
