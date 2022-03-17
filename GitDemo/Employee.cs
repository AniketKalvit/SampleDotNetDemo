using System;
using System.Collections.Generic;
using System.Text;

namespace GitDemo
{
    public class Employee //ref
    {
        static int count; // default value is zero (0)
        protected int empid;
        protected string empname;
        protected double bascisalary,hra,da,pf,grosssalary;
        public Employee()
        {
            count++;  // ++ increment value by one  
            empid = count;
            empname = "";
            bascisalary = 0.0;
        }
        public Employee(string empname,double bascisalary)
        {
            count++;  // ++ increment value by one  
            empid = count;
            this.empname = empname;
            this.bascisalary = bascisalary;
        }
        public virtual void CalculateSalary()
        {
            hra = bascisalary * 0.40;
            da = bascisalary * 0.20;
            pf = bascisalary * 0.12;
            grosssalary = (bascisalary + hra + da) - pf;

        }
        public static int GetCount()
        {
            return count;
        }
        public override string ToString()
        {
            return "Emp Id " + empid + " Emp name " + empname + "Gross Salary " + grosssalary;
        }
    }
}
