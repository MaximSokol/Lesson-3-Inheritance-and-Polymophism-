using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__3___Inheritance_and_Polymophism_.Task_2
{
    class Printer
    {
        public void ShowParam(string str)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(str);
        }
    }
}
