using System;
using System.Collections.Generic;
using System.Text;
namespace EmployeeWageProgram
{
    class EmpWageBuilderObject
    {
        //Constant
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        private string company;
        private int EMP_RATE_PER_HOUR;
        private int MAX_WORKING_DAYS;
        private int MAX_HOURS;
        private int totalEmpWage = 0;
        public EmpWageBuilderObject(String company, int EMP_RATE_PER_HOUR, int MAX_WORKING_DAYS, int MAX_HOURS)
        {
            this.company = company;
            this.EMP_RATE_PER_HOUR = EMP_RATE_PER_HOUR;
            this.MAX_WORKING_DAYS = MAX_WORKING_DAYS;
            this.MAX_HOURS = MAX_HOURS;
        }
        public void computeEmployeeWage()
        {
            Random random = new Random();
            //Variable
            int empHrs = 0;
            int empTotalHour = 0;
            int day = 0;
            while ((day < this.MAX_WORKING_DAYS) && (empTotalHour < this.MAX_HOURS))
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
            totalEmpWage = empTotalHour * this.EMP_RATE_PER_HOUR;
        }
        public String toString()
        {
           return "Total Employee Wage for company " + this.company + " is " + this.totalEmpWage;
        }
    }
}
