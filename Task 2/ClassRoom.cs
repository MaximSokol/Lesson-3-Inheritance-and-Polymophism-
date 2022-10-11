using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__3___Inheritance_and_Polymophism_.Task_2
{
    class ClassRoom
    {
        ExcellentPupil excellent;
        GoodPupil good;
        BadPupil bad;
        //---------------------------------------------

        public ClassRoom(ExcellentPupil excellent, GoodPupil good, BadPupil bad) 
        {
            this.excellent = excellent;
            this.good = good;
            this.bad = bad;
        }

        public void ExcellentPupil()
        {
            excellent.Study();
            excellent.Read();
            excellent.Write();
            excellent.Relax();
        }

        public void GoodPupil()
        {
            good.Study();
            good.Read();
            good.Write();
            good.Relax();
        }

        public void BadPupil()
        {
            bad.Study();
            bad.Read();
            bad.Write();
            bad.Relax();
        }


    }
}
