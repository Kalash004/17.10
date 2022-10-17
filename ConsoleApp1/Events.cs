using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Events
    {
        public List<IEvent> events_list = new List<IEvent>();

        public List<IEvent> Filter(String type, String level)
        {
            List<IEvent> events = new List<IEvent>();

            if (level.Equals("Any"))
            {
                foreach (var e in this.events_list)
                {
                    if (e.getType().ToString().Equals(type))
                    {
                        events.Add(e);
                    }
                }
            }
            else if (type.Equals("Any")) { 
                foreach (var e in this.events_list)
                {
                    if (e.getLevel().ToString().Equals(level))
                    {
                        events.Add(e);
                    }
                }
            }
            else
            {
                foreach (var e in this.events_list)
                {
                    if (e.getType().ToString().Equals(type) && e.getLevel().ToString().Equals(level))
                    {
                        events.Add(e);
                    }
                }
            }
            return events;
        }

    }
}
