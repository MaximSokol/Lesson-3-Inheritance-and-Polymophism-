using Lesson__3___Inheritance_and_Polymophism_.Task_2;
using Lesson__3___Inheritance_and_Polymophism_.Task_3;
using Lesson__3___Inheritance_and_Polymophism_.Task_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__3___Inheritance_and_Polymophism_
{
    class Program
    {
        public static void DocWorker()
        {
            string version = " ";

            do
            {
                Console.WriteLine("Choose (exp) or (pro)");
                Console.WriteLine("Enter the version of a program ->\t");
                version = Console.ReadLine();

                switch (version)
                {
                    case "pro":
                        DocumentWorker work = new ProDocumentWorker();
                        work.Open();
                        work.Edit();
                        work.Save();
                        break;
                    case "exp":
                        work = new ExpertDocumentWorker();
                        work.Open();
                        work.Edit();
                        work.Save();
                        break;
                    default:
                        work = new DocumentWorker();
                        work.Open();
                        work.Edit();
                        work.Save();
                        break;
                }

            } while (version != "exit");
            

           
        }
        

        static void Main(string[] args)
        {
            // Additional Task

            //string strColor = @"Taste the color!";

            //DerrivedClass derClass = new DerrivedClass();
            //derClass.ShowParam(strColor);

            //if(derClass is Printer) // UpCast LONGER VERSION
            //{
            //    Printer print = (Printer)derClass;
            //    print.ShowParam(strColor);
            //}

            //Printer printer = derClass as Printer; // UpCast SHOTER VERSION
            //printer.ShowParam(strColor);

            //if(printer is DerrivedClass) // DownCast LONGER VERSION
            //{
            //    derClass = (DerrivedClass)printer;
            //    derClass.ShowParam(strColor);
            //}

            //derClass = printer as DerrivedClass; // DownCast SHOTER VERSION
            //derClass.ShowParam(strColor);

            // Task 2

            //var clas = new ClassRoom(new ExcellentPupil(), new GoodPupil(), new BadPupil());
            //clas.ExcellentPupil();
            //Console.WriteLine();

            //clas.GoodPupil();
            //Console.WriteLine();

            //clas.BadPupil();
            //Console.WriteLine();

            // Task 3

            //Vehicle vehicle = new Car(1, 2, 5000, 320, 2016);
            //vehicle.ShowDate();
            //Console.WriteLine();

            //vehicle = new Plane(3, 4, 120000, 646, 2019, 16500, 86);
            //vehicle.ShowDate();
            //Console.WriteLine();

            //vehicle = new Ship(5, 6, 486000, 88, 2022, 421, "MyHouse");
            //vehicle.ShowDate();
            //Console.WriteLine();

            // Task 4

            //DocWorker();
        }


    }
}
