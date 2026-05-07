using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            CommandCentre center = new CommandCentre();

            Runway r1 = new Runway();
            center.AddRunway(r1);

            Aircraft plane1 = new Aircraft("Boeing-747", center);
            Aircraft plane2 = new Aircraft("Airbus-A320", center);

            plane1.Land();    
            plane2.Land();    

            plane1.TakeOff(); 

            plane2.Land();    

            Console.ReadLine();
        }
    }
}
