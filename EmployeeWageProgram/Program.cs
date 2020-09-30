using System;
namespace EmployeeWageProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("Welocome to Employee Wage Computation Program");
            EmpWageBuilderObject DMart = new EmpWageBuilderObject("Dmart",20,20,100);
            EmpWageBuilderObject Reliance = new EmpWageBuilderObject("Reliance", 10, 22, 150);
            DMart.computeEmployeeWage();
            Console.WriteLine(DMart.toString());
            Reliance.computeEmployeeWage();
            Console.WriteLine(Reliance.toString());
        }
    }
}
