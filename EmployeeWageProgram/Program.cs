using System;
namespace EmployeeWageProgram
{
    class Program
    {
        //Constant
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int MAX_WORKING_DAYS = 20;
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("Welocome to Employee Wage Computation Program");
            Random random = new Random();
            //Variable
            int empHrs = 0;
            int empWage = 0; 
            int day = 0;
            int totalEmpWage = 0;
            while (day < MAX_WORKING_DAYS)
            {
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                   case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage = totalEmpWage + empWage;
                day++;
            }
            Console.WriteLine("Employee Monthly Wage: " + totalEmpWage);
        }
    }
}
