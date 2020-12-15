using System;

namespace SalaryCalculator
{
    public class Employee
    {
        public String Name { get; set; }
        public Double HourlySalary { get; set; }
        /// <summary>
        /// Period of hours worked in one week
        /// </summary>
        public Int32 WeekTimePeriodWorked { get; set; }

        public Double WeeklySalary
        {
            get
            {               
                return HourlySalary*WeekTimePeriodWorked;
            }
        }

        public Double DailySalary
        {
            get 
            {
                return WeeklySalary/5;
            }
        }

        public double MonthlySalary 
        { 
            get
            {
                return WeeklySalary*4;
            }
        }
    }
}
