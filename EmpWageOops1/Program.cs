﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageOops1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to oops concept");

            EmpWage employee = new EmpWage();
            employee.Condition();
            employee.Display();
            Console.ReadLine();
        }
    }
}
