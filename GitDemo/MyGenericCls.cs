using System;
using System.Collections.Generic;
using System.Text;

namespace GitDemo
{
   public class MyGenericCls<T> //placeholder   T - Type
    {
        private T data;
        public MyGenericCls(T data)
        {
            this.data = data;
        }
        public T GetData()
        {
            return data;
        }
    }

  
}
