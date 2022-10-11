using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__3___Inheritance_and_Polymophism_.Task_2
{
    class DerrivedClass : Printer
    {
        public DerrivedClass()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello from DerrivedClass!");
        }

        public void ShowParam(string str)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(str);
        }
    }
}
