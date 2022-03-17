using System;
using System.Collections.Generic;
using System.Text;

namespace GitDemo
{
   public class AgeException:Exception
    {
        public AgeException(string msg):base(msg)
        {

        }
    }

    public class User
    {
        public int AcceptAge(int age)
        {
            if (age < 18)
            {
                throw new AgeException("This user not valid for vote");
            }

            return age;
        }
    }
}
