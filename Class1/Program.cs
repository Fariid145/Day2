using System;

namespace Class1
{
    class Program
    {
       
        
        public class Area
        {


            int length, breadth;
            Area(int l, int b)
            {
                length = l;
                breadth = b;
            }
            public int setDimension()
            {
                int results = length * breadth;
                return results;
            }
            public void getArea()
            {
                Console.WriteLine("Area = " + setDimension());
            }
            static void Main(String[] args)
            {
                Area area = new Area(6, 5);

                area.getArea();

            }
           
        }
    }
}
