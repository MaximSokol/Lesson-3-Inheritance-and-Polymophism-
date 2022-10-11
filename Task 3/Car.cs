using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__3___Inheritance_and_Polymophism_.Task_3
{
    class Car : Vehicle
    {
       public Car(int xCoord, int yCoord,
            double price, int speed, int greade)
            : base(xCoord, yCoord, price, speed, greade){ }
        //----------------------------------------------------------------

        public override void ShowDate()
        {
            Console.WriteLine($"X:\t{XCoord}");
            Console.WriteLine($"Y:\t{YCoord}");
            Console.WriteLine($"Price:\t{price}");
            Console.WriteLine($"Speed:\t{speed}");
            Console.WriteLine($"Greade:\t{greade}");
        }
    }
}
