using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageOops1
{
    internal class CompanyList : ICompanyWage
    {

        private readonly Dictionary<string, EmpWage> companies;

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


        public void GetTotalWage()
        {
            Console.Write("Enter name of Company: ");
            string companyName = Console.ReadLine();
            if (companies.ContainsKey(companyName))
                Console.WriteLine("Total Wage: " + companies[(companyName)].TotalWage);
            else
                Console.WriteLine("Company does not exist!");
        }
    }
}