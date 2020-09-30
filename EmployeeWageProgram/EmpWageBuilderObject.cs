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
        CompanyEmpWage[] companyDataArray;
        private int noOFCompany = 0;
        public EmpWageBuilderObject()
        {
            this.companyDataArray = new CompanyEmpWage[5];
        }
        public void AddCompany(string company, int EMP_RATE_PER_HOUR, int MAX_WORKING_DAYS, int MAX_HOURS)
        {
            companyDataArray[this.noOFCompany]  = new CompanyEmpWage(company, EMP_RATE_PER_HOUR, MAX_WORKING_DAYS, MAX_HOURS);
            noOFCompany++;
        }
        public void computeEmployeeWage()
        {
            for (int index = 0; index < this.noOFCompany; index++)
            {
                companyDataArray[index].setTotalEmpWage(this.computeEmployeeWage(this.companyDataArray[index]));
                Console.WriteLine(this.companyDataArray[index].toString());
            }
        }
        public int computeEmployeeWage(CompanyEmpWage companyEmpWage)
        {
            Random random = new Random();
            //Variable
            int empHrs = 0;
            int empTotalHour = 0;
            int day = 0;
            while ((day < companyEmpWage.MAX_WORKING_DAYS) && (empTotalHour < companyEmpWage.MAX_HOURS))
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
            return companyEmpWage.totalEmpWage = empTotalHour * companyEmpWage.EMP_RATE_PER_HOUR;
            
        }
    }
}
