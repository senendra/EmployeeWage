using System;
namespace EmployeeWageProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("Welocome to Employee Wage Computation Program");
            EmpWageBuilderObject DMart = new EmpWageBuilderObject();
            DMart.AddCompany("Dmart", 20, 20, 100);
            EmpWageBuilderObject Reliance = new EmpWageBuilderObject();
            Reliance.AddCompany("Reliance", 10, 22, 150);
            DMart.computeEmployeeWage();
            Reliance.computeEmployeeWage();
        }
    }
}
