using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBonusCSharp
{
    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int Experience { get; set; }

        //public void CalculateBonus() {
        //    if (Experience < 2)
        //    {
        //        Console.WriteLine( " 10% bonus for " + Experience +
        //            " years");
        //    }
        //    else if (Experience < 5)
        //    {
        //        Console.WriteLine( "15% bonus for " + Experience +
        //          " years");       
        //    }
        //    else if (Experience < 10)
        //    {
        //        Console.WriteLine("20% bonus for " + Experience +
        //       " years");    
        //    }
        //    else
        //    {
        //        Console.WriteLine("25% bonus for " + Experience +
        //       " years");     
        //    }

        //}
          
        //have only one return statement it is a better way.
        //one return does all the calculations
        public decimal CalculateBonus() {
            decimal bonusRate;
            if (Experience < 2)
            {
                bonusRate = 0.1m;
            }
            else if (Experience < 5)
            {
                bonusRate =  0.15m;
            }
            else if (Experience < 10)
            {
                bonusRate = 0.2m;
            }
            else {
                bonusRate = Salary * 0.25m;
            }
            return 200 + (bonusRate * Salary);
        }
    }

}
