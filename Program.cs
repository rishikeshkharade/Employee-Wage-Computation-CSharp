using System;

namespace Employee_Wage_Problem
{
    class Employee
    {
        const int Wage_per_Hour = 20;
        const int Full_Time_Working_Hours = 8;

        public void Employee_Attendance()
        {
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
        public void Employee_Wage()
        {
            int Full_Time_Wage = Wage_per_Hour*Full_Time_Working_Hours;
            Console.WriteLine("Daily Employee Wage is: " + Full_Time_Wage+"Rs");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage");

            Employee e = new Employee();
            e.Employee_Attendance();
            e.Employee_Wage();
        }

    }
}
