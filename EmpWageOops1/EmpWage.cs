using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageOops1
{
    internal class EmpWage
    {
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 0;
        const int IS_PRESENT = 1;
        const int IS_ABSENT = 0;
        private readonly int RATE_PER_Hour = 20;

        public int RATE_PER_HOUR { get; }

        private readonly int WORKING_DAYS_PER_MONTH = 20;
        private readonly int HOURS_PER_MONTH = 100;

        int totalDayWorked;
        int monthlyWage;
        int totalHourWorked;

        Random random = new Random();
        public EmpWage(int ratePerHour)
        {
            totalHourWorked = 0;
            totalDayWorked = 0;
            monthlyWage = 0;
        }
        public EmpWage(int ratePerHour, int maxWorkingDays, int maxHoursPerMonth)
        {
            RATE_PER_HOUR = ratePerHour;
            WORKING_DAYS_PER_MONTH = maxWorkingDays;
            HOURS_PER_MONTH = maxHoursPerMonth;
        }

        public EmpWage()
        {
        }

        public void Reset()
        {
            totalDayWorked = 0;
            totalHourWorked = 0;
            monthlyWage = 0;

        }



        private int GetAttendance()
        {

            int checkAttendance = random.Next(0, 2);
            if (checkAttendance == IS_PRESENT)
            {
                return IS_PRESENT;
            }
               
            else
            {
                return IS_ABSENT;
            } 
        }
        public void GetDailyWage()
        {
            int dailyWage = 0;
            int dailyHours = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                dailyHours = 8;
            else if (empCheck == IS_PART_TIME)
                dailyHours = 4;
            dailyWage = dailyHours * RATE_PER_Hour;
            Console.WriteLine("Daily Wage: " + dailyWage);
        }
        public void PartTimeEmpWage()
        {
            int EmpHrs = 0;
            int EmpWage = 0;

            int EmpCheck = random.Next(0, 2);

            if (EmpCheck == IS_FULL_TIME)
            {
                EmpHrs = 8;
            }
            else if (EmpCheck == IS_PART_TIME)
            {
                EmpHrs = 4;
            }
            else
            {
                EmpHrs = 0;
            }
            EmpWage = EmpHrs * RATE_PER_Hour;
            Console.WriteLine("Employeewage = " + EmpWage);
            Console.ReadLine();
        }
        private int SwitchCase()
        {
            int EmpHrs = 0;
            int EmpWage = 0;

            int EmpCheck = random.Next(0, 2);

            switch (EmpCheck)
            {
                case IS_PART_TIME:
                    EmpHrs = 4;
                    break;

                case IS_FULL_TIME:
                    EmpHrs = 8;
                    break;

                default:
                    EmpHrs = 0;
                    break;
            }
            EmpWage = EmpHrs * RATE_PER_Hour;
            return EmpWage;

        }
        public void MonthlyWage()
        {
            for (int i = 0; i < WORKING_DAYS_PER_MONTH; i++)
                totalDayWorked += GetAttendance();
            for (int j = 0; j < totalDayWorked; j++)
            {
                monthlyWage =monthlyWage+ SwitchCase();
            }
            Console.WriteLine("Monthly Wage: " + monthlyWage);
            Console.ReadLine();


        }
        public void Condition()
        {
            while (totalDayWorked != 20 && totalHourWorked < 100)
            {
                Reset();
                MonthlyWage();
            }
        }

        public void Display()
        {
            Console.WriteLine("Total Hours worked: " + totalHourWorked);
            Console.WriteLine("Total Days worked: " + totalDayWorked);
            Console.WriteLine("Monthly Wage: " + monthlyWage);
            Console.ReadLine();


        }

        public override string ToString()
        {
            return "Total Hours: " + totalHourWorked + "; Total Days: " + totalDayWorked + "; Total Wage: " + monthlyWage;
        }
    }    
}
