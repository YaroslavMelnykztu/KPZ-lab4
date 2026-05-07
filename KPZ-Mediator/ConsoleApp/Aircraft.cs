using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Aircraft
    {
        public string Name { get; private set; }
        private ICommandCentre _mediator;

        public Aircraft(string name, ICommandCentre mediator)
        {
            Name = name;
            _mediator = mediator;
        }

        public void Land()
        {
            if (_mediator.RequestLanding(this))
            {
                Console.WriteLine($"{Name}: Я успішно приземлився.");
            }
        }

        public void TakeOff()
        {
            Console.WriteLine($"{Name}: Запитую зліт.");
            _mediator.RequestTakeOff(this);
        }
    }
}
