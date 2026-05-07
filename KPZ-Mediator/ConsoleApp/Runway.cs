using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        public Aircraft IsBusyWithAircraft;
        public void HighLightRed() => Console.WriteLine($"Смуга {Id} червона (зайнята).");
        public void HighLightGreen() => Console.WriteLine($"Смуга {Id} зелена (вільна).");
    }
}
