using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageOops1
{
    internal class CompanyList : CompanyWageInterface
    {

        private readonly Dictionary<string, EmpWage> companies;

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyList"/> class.
        /// </summary>
        public CompanyList()
        {
            companies = new();
        }

        public void AddCompany(string companyName)
        {
            companies.Add(companyName, new EmpWage(companyName));
            ComputeWage(companyName);
        }


        public void AddCompany(string companyName, int ratePerHour, int maxWorkingDays, int maxHoursPerMonth)
        {
            companies.Add(companyName, new EmpWage(companyName, ratePerHour, maxWorkingDays, maxHoursPerMonth));
            ComputeWage(companyName);
        }

        public void ComputeWage(string companyName)
        {
            companies[companyName].MeetWageCondition();
        }


        public void Display()
        {
            foreach (var company in companies.Values)
                Console.WriteLine("\nCompany: " + company.Company + "\n" + company.ToString() + "\n");
        }
    }
}