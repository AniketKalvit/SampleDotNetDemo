using System;
using System.Collections.Generic;
using System.Text;

namespace GitDemo
{
    //child class name : parent class name
   public class Manager:Employee
    {
        private double foodallow, ta;
        public Manager() :base()  // it will call base class constructor
        {
            foodallow = 0.0;
            ta = 0.0;
        }
        public Manager(string nm,double bs,double foodallow,double ta):base(nm,bs)
        {
            this.foodallow = foodallow;
            this.ta = ta;
        }
        public override void CalculateSalary()
        {
            hra = bascisalary * 0.40;
            da = bascisalary * 0.20;
            pf = bascisalary * 0.12;
            grosssalary = (bascisalary + hra + da + foodallow + ta) - pf;
        }
        public override string ToString()
        {
            return "Emp Id " + empid + " Emp name " + empname + "Gross Salary " + grosssalary;
        }
    }
}
