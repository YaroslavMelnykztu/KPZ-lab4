using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class LightElement : LightNode
    {
        public string TagName { get; set; }
        public class EventSubscription
        {
            public string EventType;
            public IEventListener Listener;
        }

        private List<EventSubscription> _subscriptions = new List<EventSubscription>();

        public LightElement(string tagName)
        {
            TagName = tagName;
        }
        public void AddEventListener(string eventType, IEventListener listener)
        {
            EventSubscription subscription = new EventSubscription();
            subscription.EventType = eventType;
            subscription.Listener = listener;

            _subscriptions.Add(subscription);
        }

        public void TriggerEvent(string eventType)
        {
            Console.WriteLine($"\n--- Симуляція події '{eventType}' для <{TagName}> ---");

            foreach (EventSubscription sub in _subscriptions)
            {
                if (sub.EventType == eventType)
                {
                    sub.Listener.HandleEvent(eventType, this);
                }
            }
        }

        public override string OuterHtml()
        {
            return $"<{TagName}></{TagName}>";
        }
    }
}
