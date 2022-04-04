using System;
using System.Collections.Generic;
using System.Text;

namespace GitDemo
{
    public delegate void ErrorDelegate();
   public class AgeException:Exception
    {
        public AgeException(string msg):base(msg)  {     }
    }
    public class User
    {
        // access specifier event keyword  name of delegate   event name
        public event ErrorDelegate AgeEvent;
        public int AcceptAge(int age)
        {
            if (age < 18)
            {
                AgeEvent(); // call to event
            }

            return age;
        }
    }
}
