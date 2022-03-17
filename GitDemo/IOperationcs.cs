using System;
using System.Collections.Generic;
using System.Text;

namespace GitDemo
{
    interface IOperation
    {
        int Save();
        int Update();
        int Delete(int id);
    }
    public class Student : IOperation
    {
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public int Update()
        {
            throw new NotImplementedException();
        }
    }
}
