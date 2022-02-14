using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageOops1
{
    internal class CompanyList
    {
        private Dictionary<string, EmpWage> companies;

        
        public CompanyList()
        {
            companies = new();
        }

        
        public void AddCompany(string companyName)
        {
            companies.Add(companyName, new EmpWage());
            companies[companyName].Condition();
        }

        
        public void AddCompany(string companyName, int ratePerHour, int maxWorkingDays, int maxHoursPerMonth)
        {
            companies.Add(companyName, new EmpWage(ratePerHour, maxWorkingDays, maxHoursPerMonth));
            companies[companyName].Condition();
        }
        public void Display()
        {
            foreach (var company in companies)
                Console.WriteLine("\nCompany: " + company.Key + "\n\tWage details:\n\t" + company.Value.ToString());
        }
    }
}
