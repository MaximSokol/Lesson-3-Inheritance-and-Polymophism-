using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__3___Inheritance_and_Polymophism_.Task_3
{
    class Vehicle
    {
        public int XCoord { get; set; }
        public int YCoord { get; set; }
        //------------------------------------------------------

        protected double price;
        protected int speed;
        protected int greade;
        //------------------------------------------------------

        public Vehicle(int xCoord, int yCoord,
            double price, int speed, int greade)
        {
            this.XCoord = xCoord;
            this.YCoord = yCoord;
            this.price = price;
            this.speed = speed;
            this.greade = greade;
        }
        //------------------------------------------------------

        public virtual void ShowDate() 
        { 
            Console.WriteLine("Show some information!");
        }
        //------------------------------------------------------
    }
}
