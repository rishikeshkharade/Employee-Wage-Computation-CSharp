﻿using System;

namespace Employee_Wage_Problem
{
    class Employee
    {
        const int Wage_per_Hour = 20;
        const int Full_Time_Working_Hours = 8;
        const int Part_Time_Working_Hours = 4; 

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
            int Full_Time_Wage = Wage_per_Hour * Full_Time_Working_Hours;
            Console.WriteLine("Daily Employee Wage is: " + Full_Time_Wage+"Rs");

            int Part_Time_Wage = Wage_per_Hour * Part_Time_Working_Hours;
            Console.WriteLine("Part Time Employee Wage is: " + Part_Time_Wage + "Rs");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage");
            Employee e = new Employee();

            Console.WriteLine("1. Employee Attendance");
            Console.WriteLine("2. Employee Wage");
            Console.WriteLine("Enter your choice (1 or 2): ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    e.Employee_Attendance();
                    break;

                case 2:
                    e.Employee_Wage();
                    break;

                default:
                    Console.WriteLine("Invlid Option. Please Select 1 or 2.");
                    break;

            }
        }

    }
}
