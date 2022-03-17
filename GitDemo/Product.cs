using System;
using System.Collections.Generic;
using System.Text;

namespace GitDemo
{
   public class Product
    {
        private int code;
        private string name;
        private double price;
        public Product(int code,string name,double price)
        {
            this.code = code;
            this.name = name;
            this.price = price;
        }

        //public string Print()
        //{
        //    return code + "  " + name + "  " + price;
        //}

        public override string ToString()
        {
            return code+"  "+name+"  "+price;
        }

    }
}
