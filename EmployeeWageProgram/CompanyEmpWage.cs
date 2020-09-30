using System;
using System.Collections.Generic;
using System.Text;
namespace EmployeeWageProgram
{
    class CompanyEmpWage
    {
        public string company;
        public int EMP_RATE_PER_HOUR;
        public int MAX_WORKING_DAYS;
        public int MAX_HOURS;
        public int totalEmpWage = 0;
        public CompanyEmpWage(String company, int EMP_RATE_PER_HOUR, int MAX_WORKING_DAYS, int MAX_HOURS)
        {
            this.company = company;
            this.EMP_RATE_PER_HOUR = EMP_RATE_PER_HOUR;
            this.MAX_WORKING_DAYS = MAX_WORKING_DAYS;
            this.MAX_HOURS = MAX_HOURS;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "The total Employee Wage of company " + company + " is " + totalEmpWage;
        }
    }
}
