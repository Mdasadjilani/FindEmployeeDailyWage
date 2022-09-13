using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDailyWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC-2 Find Employee Daily Wage
            const int Emp_Present = 1;
            const int Emp_Rate_Per_HR = 20;
            int EmpHrs = 0, empWage = 0;
            Random random = new Random();
            //Generate random numbers within range either 0 or 1
            int empCheck = random.Next(0, 2);
            Console.WriteLine("Random value:"+empCheck);
            if (empCheck == Emp_Present)
            {
                EmpHrs = 8;
                Console.WriteLine("Employee is present");
            }
            else
            {
                EmpHrs = 0;
                Console.WriteLine("Employee is absent");
            }
            empWage = EmpHrs * Emp_Rate_Per_HR;
            Console.WriteLine("Employee Wage Per Day:"+empWage);
            Console.ReadLine();
        }
    }
}
