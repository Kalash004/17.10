using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Event_image:IEvent
    {
        private Event_Type type;
        private Level level;
        private String description;

        public Event_image(Event_Type type, Level level, string description)
        {
            this.type = type;
            this.level = level;
            this.description = description;
        }

        public Level Level
        {
            get { return level; }
            set { level = value; } 
        }

        public Event_Type Type
        {
            get { return type; }
            set { type = value; }
        }

        public string getDesc()
        {
            return description;
        }

        public Level getLevel()
        {
            return level;
        }

        public Event_Type getType()
        {
            return type;
        }

        public override string ToString()
        {
            return String.Format("Type: {0} \nLevel: {1} \nDescription: {2}", type.ToString(),level.ToString(),description) ;
        }
    }
}
