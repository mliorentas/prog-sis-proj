using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDecorator
{
    class Reminder : Event
    {
        public Reminder()
        {
        Info = "Reminder";
        }

        public override string GetItem()
        {
            return String.Format("Title - {0}\nDescription - {1}", Title, Description);
        }
    }
}
