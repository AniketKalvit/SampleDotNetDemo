using System;
using System.Collections.Generic;
using System.Text;

namespace GitDemo
{
    public delegate int MyDelegate(int n1, int n2);
    public delegate string MyStrDel(string name);
    public class Calculation
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int multiply(int a, int b)
        {
            return a * b;
        }
    }
    public class Test
    {
        public string AcceptName(string name)
        {
            return name.ToUpper();
                 
        }
    }

}
