using System;

namespace Employee_Wage_Problem
{
    class Employee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage");

            Random random = new Random();

            int attendanceCheck = random.Next(0, 2);

            if (attendanceCheck == 1)
            {
                Console.WriteLine("Employee is Present.");
            }
            else
            {
                Console.WriteLine("Employee is Absent.");
            }
        }

    }
}
