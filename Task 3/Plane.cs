using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__3___Inheritance_and_Polymophism_.Task_3
{
    class Plane : Vehicle
    {
        int hight;
        int quantityOfOccupants;
        //------------------------------------------------------------------

        public Plane(int xCoord, int yCoord,
            double price, int speed, int greade,
            int hight, int quantityOfOccupants) 
            : base(xCoord, yCoord, price, speed, greade)
        {
            this.hight = hight;
            this.quantityOfOccupants = quantityOfOccupants;
        }
        //------------------------------------------------------------------

        public override void ShowDate()
        {
            Console.WriteLine($"X:\t{XCoord}");
            Console.WriteLine($"Y:\t{YCoord}");
            Console.WriteLine($"Price:\t{price}");
            Console.WriteLine($"Speed:\t{speed}");
            Console.WriteLine($"Greade:\t{greade}");
            Console.WriteLine($"Hight:\t{hight}");
            Console.WriteLine($"Occupants:\t{quantityOfOccupants}");
        }
        //------------------------------------------------------------------
    }
}
