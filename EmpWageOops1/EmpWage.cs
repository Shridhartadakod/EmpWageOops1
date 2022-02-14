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
        const int Emp_RATE_PER_Hour = 20;


        Random random = new Random();
        public void GetAttendance()
        {

            int checkAttendance = random.Next(0, 2);
            if (checkAttendance == IS_PRESENT)
                Console.WriteLine("Is Present");
            else if (checkAttendance == IS_ABSENT)
                Console.WriteLine("Is Absent");
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
            dailyWage = dailyHours * Emp_RATE_PER_Hour;
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
            EmpWage = EmpHrs * Emp_RATE_PER_Hour;
            Console.WriteLine("Employeewage = " + EmpWage);
            Console.ReadLine();
        }
        public void SwitchCase()
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
            EmpWage = EmpHrs * Emp_RATE_PER_Hour;
            Console.WriteLine("Employee Wage = " + EmpWage);
            Console.ReadLine();

        }

    }    
}
