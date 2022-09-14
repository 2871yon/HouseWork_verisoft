using System;

namespace HouseWork_Verisoft
{
    internal class Program
    {
        //test paragraph
        static void Main(string[] args)
        {
            //p1+2
            Circle c = new Circle(5, "pink", true);
            Circle c1 = new Circle(5);
            Shape sc = new Circle(5, "pink", true);
            Shape sc1 = new Circle(4);
           
            //p1+3
            Rectangle r = new Rectangle(10, 20, "yellow", false);
            Rectangle r1 = new Rectangle(10, 20);
            Shape sr = new Rectangle(10, 20, "yellow", false);
            Shape sr1 = new Rectangle(4,4);  
            
            //p1+2+3
            Shape[] ShapeArr=new Shape[8];
            ShapeArr[0]=c;
            ShapeArr[1]=c1; 
            ShapeArr[2]=sc;
            ShapeArr[3] = sc1;
            ShapeArr[4] = r;
            ShapeArr[5] = r1;
            ShapeArr[6] = sr;
            ShapeArr[7] = sr1;


            for (int i = 0; i < ShapeArr.Length; i++)
            {
                if(ShapeArr[i] != null) 
                Console.WriteLine("shape " + i +": "+ShapeArr[i].ToString());

                if (ShapeArr[i] is GeometricObject)
                {
                    Console.WriteLine("Perimeter: " +(ShapeArr[i] as GeometricObject).getPerimeter());
                    Console.WriteLine("Area: " + (ShapeArr[i] as GeometricObject).getArea()+ "\n\r");
                }
            }


        }
    }
}
