using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__3___Inheritance_and_Polymophism_.Task_4
{
    class ProDocumentWorker : DocumentWorker
    {
        public override void Open()
        {
            Console.WriteLine("The documnet is edited!");
        }

        public override void Edit()
        {
            Console.WriteLine("The document was saved in an old format!");
        }

        public override void Save()
        {
            Console.WriteLine("The saving in left format is available in a Expert Version!");
        }
    }
}
