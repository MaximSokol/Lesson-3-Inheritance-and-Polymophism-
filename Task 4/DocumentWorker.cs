using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__3___Inheritance_and_Polymophism_.Task_4
{
  public class DocumentWorker
    {
        public virtual void Open()
        {
            Console.WriteLine("The documnet is open!");
        }

        public virtual void Edit()
        {
            Console.WriteLine("The editing of the document is available in a Pro Version!");
        }

        public virtual void Save()
        {
            Console.WriteLine("The saving of the document is available in a Pro Version!");
        }
    }
}
