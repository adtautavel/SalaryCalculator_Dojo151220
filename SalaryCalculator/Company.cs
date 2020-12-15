using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryCalculator
{
    public class Company
    {
        public String Name { get; set; }
        public ICollection<Employee> Employees { get; set; }

        /// <summary>
        /// Total of employees salary per month
        /// </summary>
        public Double MonthlySalaryExpenditures 
        {
            get
            {
                return MonthlySum();
            }
        }

        private double MonthlySum()
        {
            double resultat = 0;
            foreach (Employee employee in Employees)
            {
                resultat += employee.MonthlySalary;
            }
             return resultat;
        }

        /// <summary>
        /// Total of employees salary per year
        /// </summary>
        public Double YearlySalaryExpenditures 
        {
            get
            {
                return YearlySum();
            }
        }

        private double YearlySum()
        {
            double resultat = 0;
            foreach (Employee employee in Employees)
            {
                resultat += employee.MonthlySalary*12;
            }
            return resultat;
        }
    }
}
