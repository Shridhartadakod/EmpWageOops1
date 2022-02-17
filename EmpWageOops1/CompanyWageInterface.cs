using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageOops1

    {
        public interface ICompanyWage
        {
            void AddCompany(string companyName);

            void AddCompany(string companyName, int ratePerHour, int maxWorkingDays, int maxHoursPerMonth);

            
            void ComputeWage(string companyName);
        }
    }

