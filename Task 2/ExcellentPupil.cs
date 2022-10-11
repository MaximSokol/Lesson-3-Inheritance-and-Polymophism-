using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__3___Inheritance_and_Polymophism_.Task_2
{
    class ExcellentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("ElexcellentPupil Study();");
        }

        public override void Read()
        {
            Console.WriteLine("ElexcellentPupil Read();");
        }

        public override void Write()
        {
            Console.WriteLine("ElexcellentPupil Write();");
        }

        public override void Relax()
        {
            Console.WriteLine("ElexcellentPupil Relax();");
        }
    }
}
