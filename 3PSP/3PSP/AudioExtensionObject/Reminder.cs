using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPSP
{
    class Reminder : CalendarEvent
    {
        public Reminder()
        {
        Info = "Reminder";
        }

        public override string GetItem()
        {
            return String.Format("Title - {0}\nDescription - {1}\n", Title, Description) + GetExtensions();
        }
    }
}
