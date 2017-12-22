using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPSP
{
    class Meeting : CalendarEvent
    {
        public string People { get; set; }
        public Meeting()
        {
            Info = "Meeting";
        }
        public override string GetItem()
        {
            return String.Format("Title - {0}\nPeople - {2}\nDescription - {1}", Title, Description, People);
        }
    }
}
