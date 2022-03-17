using System;
using System.Collections;
using System.Collections.Generic;
namespace GitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            try
            {
               int age= user1.AcceptAge(22);
                Console.WriteLine("This user is valid for vote"+age);
            }
            catch(AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
