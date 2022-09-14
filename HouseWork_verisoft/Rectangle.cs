using System;
using System.Collections.Generic;
using System.Text;

namespace HouseWork_Verisoft
{
    //paragraph3
    public class Rectangle:Shape,GeometricObject
    {
        //3.6+3.8
        protected double Width { get; set; }
        protected double Height { get; set; }
     
        //3.7
        public Rectangle() 
        { 
            Width = 1.0;
            Height = 1.0;   
        }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public Rectangle(double width, double height,string color, bool filled) : base(color, filled)
        {
            Width = width;
            Height = height;
        }

        //3.9
        public double getArea()
        {
            return Width* Height;
        }

        public double getPerimeter()
        {
            return Width*2+Height*2;   
        }

        //3.10
        public override string ToString()
        {
            return "A Rectangle with width ="+Width+"and length ="
                + Height+", which is a subclass of "+ base.ToString();
        }
    }
}
