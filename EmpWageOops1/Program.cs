using System;
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

            CompanyList companyList = new CompanyList();

          
            companyList.AddCompany("Reliance");
            companyList.AddCompany("Tata");

            
            companyList.AddCompany("Facebook", 50, 22, 120);

            
            companyList.Display();

            Console.ReadKey();
        }
    }
}
