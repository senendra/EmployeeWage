using System;
namespace EmployeeWageProgram
{
    class Program
    {
        //Constant
        public const int IS_FULL_TIME = 1;
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("Welocome to Employee Wage Computation Program");
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
