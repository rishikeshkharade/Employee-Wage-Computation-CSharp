using System;

namespace Employee_Wage_Problem
{
    class Employee
    {
        const int Wage_per_Hour = 20;
        const int Full_Time_Working_Hours = 8;
        const int Part_Time_Working_Hours = 4;
        const int Working_Day_per_month = 20;

        const int maxHours = 100;
        const int maxDays = 20;

        static int totalHoursWorked = 0;
        static int totalDaysWorked = 0;
        static int dailwage = 0;
        static int Day = 0;

        /*public void Employee_Wage()
        {
            int Full_Time_Wage = Wage_per_Hour * Full_Time_Working_Hours;
            Console.WriteLine("Daily Employee Wage is: " + Full_Time_Wage+"Rs");

            int Part_Time_Wage = Wage_per_Hour * Part_Time_Working_Hours;
            Console.WriteLine("Part Time Employee Wage is: " + Part_Time_Wage + "Rs");

        }

        public void Employee_Wage_per_Month()
        {
            int Full_Time_Wage_per_Month = Wage_per_Hour*Full_Time_Working_Hours*Working_Day_per_month;
            Console.WriteLine("Full Time Employee Wage per month is: " + Full_Time_Wage_per_Month);

            int Part_Time_Wage_per_Month = Wage_per_Hour*Part_Time_Working_Hours *Working_Day_per_month;
            Console.WriteLine("Part Time Employee Wage per month is: " + Part_Time_Wage_per_Month);
        }*/

        public void Full_Time_Employee()
        {
            totalHoursWorked += Full_Time_Working_Hours;
            dailwage = Wage_per_Hour * Full_Time_Working_Hours;
            Console.WriteLine($"Day {Day}: Employee is Present. Daily Wage: ${dailwage}");

        }
        public void Part_Time_Employee()
        {
            totalHoursWorked += Part_Time_Working_Hours;
            dailwage = Part_Time_Working_Hours * Wage_per_Hour;
            Console.WriteLine($"Day {Day}: Employee is Present. Daily Wage: ${dailwage}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage");
            Employee e = new Employee();

            Console.WriteLine("Select Employee Type");
            Console.WriteLine("1. Full-Time Employee");
            Console.WriteLine("2. Part-Time Employee");
            Console.WriteLine("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            while (totalHoursWorked < maxHours && totalDaysWorked < maxDays)
            {
                Random random = new Random();
                int attendanceCheck = random.Next(0, 2);

                if (attendanceCheck == 1)
                {
                    Day++;
                    totalDaysWorked++;

                    switch (choice)
                    {
                        case 1:
                            e.Full_Time_Employee();
                            break;

                        case 2:
                            e.Part_Time_Employee();
                            break;

                        default:
                            Console.WriteLine("Invlid Option.");
                            return;

                    }
                }
                else
                {
                    Day++;
                    Console.WriteLine($"Day {Day}: Employee is Absent.");
                }
            }
                Console.WriteLine($"\nTotal Days Worked: {totalDaysWorked}");
                Console.WriteLine($"Total Hours Worked: {totalHoursWorked}");
                Console.WriteLine($"Total Wage fot the Month: ${dailwage * totalDaysWorked}");

            }
        }
    }
