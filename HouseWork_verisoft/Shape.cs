using System;
using System.Collections.Generic;
using System.Text;

namespace HouseWork_Verisoft
{
    //paragraph2
    public abstract class Shape
    {
        //2.1
        protected string color;
        protected bool filled;

        //2.3
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public bool Filled
        {
            get { return filled; }
            set { filled = value; }
        }


        //2.2
        public Shape()
        {
            color ="green";
            filled = true;
        }
        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }
        
        //2.4
        public override string ToString()
        {
            if (filled)
                return"A Shape with: " + color + ", of filled.";
            else
                return "A Shape with: " + color + ", of Not filled.";
            
            //return = ("A Shape with" + color + "of {0}", filled ? "filled" : "Not filled").ToString();
        }
    }
}
