using System;
using System.Collections.Generic;
using System.Text;

namespace GitDemo
{
    abstract public class Shape
    {
        abstract public void CalculateArea();
    }
    public class Circle : Shape,IPrintalbe
    {
        private int radius;
        private double result, PI=3.14;
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public int GetRadius { get => radius; }

        public override void CalculateArea()
        {
            result = PI * radius * radius;
        }

        public string Print()
        {
            return "Area of Circle is " + result;
        }

        public override string ToString()
        {
            return "Area of Circle is "+result;
        }
    }

    public class Rantangle
    {

    }
}
