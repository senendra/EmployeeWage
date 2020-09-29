using System;
namespace EmployeeWageProgram
{
    class Program
    {
        //Constant
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public static int computeEmployeeWage(String company, int EMP_RATE_PER_HOUR, int MAX_WORKING_DAYS, int MAX_HOURS)
        {
            Random random = new Random();
            //Variable
            int empHrs = 0;
            int empTotalHour = 0;
            int day = 0;
            int totalEmpWage = 0;
            while ((day < MAX_WORKING_DAYS) && (empTotalHour < MAX_HOURS))
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
                empTotalHour += empHrs;
                day++;
            }
            totalEmpWage = empTotalHour * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee Wage for company "+company+" is " + totalEmpWage);
            return totalEmpWage;
        } 
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("Welocome to Employee Wage Computation Program");
            computeEmployeeWage("Dmart",20,20,100);
            computeEmployeeWage("Reliance", 10, 22, 150);
        }
    }
}
