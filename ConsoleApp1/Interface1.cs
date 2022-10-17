using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum Event_Type
    {
        System,
        Hardware,
        Application
    }

    public enum Level
    {
        Information,
        Warning,
        Error
    }

    internal interface IEvent
    {
        public Event_Type getType();
        public Level getLevel();

        public String getDesc();
    }
}
