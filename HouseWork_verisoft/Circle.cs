using System;
using System.Collections.Generic;
using System.Text;

namespace HouseWork_Verisoft
{
    //paragraph3
    public class Circle:Shape ,GeometricObject
    {
        //3.1
        protected double radius;

        //3.3
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        //3.2
        public Circle()
        {
            radius = 1.0;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(double radius,string color,bool filled):base(color,filled)
        {
            this.radius = radius;
        }

        //3.4
        public double getArea()
        {
            return radius*2*3.14;  
        }

        public double getPerimeter()
        {
            return 2 * 3.14 *radius;
        }

        //3.5
        public override string ToString()
        {
            return "A Circle with radius =" + radius +
                ", which is a subclass of" + base.ToString();
        }

    }
}
