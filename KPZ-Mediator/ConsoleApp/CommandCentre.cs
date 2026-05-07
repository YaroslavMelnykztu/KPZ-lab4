using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class CommandCentre : ICommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();

        public void AddRunway(Runway runway) => _runways.Add(runway);
        public void AddAircraft(Aircraft aircraft) => _aircrafts.Add(aircraft);

        public bool RequestLanding(Aircraft aircraft)
        {
            Console.WriteLine($"[Центр] Літак {aircraft.Name} запитує посадку.");

            foreach (var runway in _runways)
            {
                if (runway.IsBusyWithAircraft == null)
                {
                    runway.IsBusyWithAircraft = aircraft;
                    runway.HighLightRed();
                    Console.WriteLine($"[Центр] Смуга {runway.Id} виділена для {aircraft.Name}.");
                    return true;
                }
            }

            Console.WriteLine($"[Центр] Вільних смуг немає для {aircraft.Name}.");
            return false;
        }

        public void RequestTakeOff(Aircraft aircraft)
        {
            foreach (var runway in _runways)
            {
                if (runway.IsBusyWithAircraft == aircraft)
                {
                    runway.IsBusyWithAircraft = null;
                    runway.HighLightGreen();
                    Console.WriteLine($"[Центр] Літак {aircraft.Name} злетів, смуга {runway.Id} вільна.");
                    return;
                }
            }
        }
    }
}
