using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment_1._4._1
{

    internal class Program
    {
        //Create a class named “Point” and 2 data members: X and Y coordinate. Declare 2 points: P1 and P2. Determine if P2 is to the right or left
        //of P1 or on same axis , by comparing the x xoordinates. ( if p1.x is more than p2.x , it is to the right )
        static void Main(string[] args)
        {
            //class members = P1,P2
            
                Point myObjectP1 = new Point(2.2, 9.3); //object created
                Point myObjectP2 = new Point(4.5, 3.6); //constructor = 'new Point()'


                Console.WriteLine($"P1: ({myObjectP1.x}, {myObjectP2.y}) ");
                Console.WriteLine($"P2: ({myObjectP2.x}, {myObjectP2.y}) ");

                if (myObjectP1.x < myObjectP2.x)
                {
                    Console.WriteLine("P2 is to the right of P1");
                }
                else if (myObjectP1.x > myObjectP2.x)
                {
                    Console.WriteLine("P2 is to the left of P1");
                }
                else
                {
                    Console.WriteLine("P2 is on the same axis as P1");
                }
                Console.WriteLine("Do you want to run the code again? (Y/N)");

        }
    }
    class Point
    {
       
        public Point(double xCoord, double yCoord) //constructor
            {
                x = xCoord;
                y = yCoord;
            }

       public double x; //'public' access modifier accesible to all classes
       public double y; //field created

    }
}
