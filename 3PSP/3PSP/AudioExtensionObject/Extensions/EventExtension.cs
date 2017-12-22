using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPSP
{
    abstract class EventExtension
    {
        protected CalendarEvent _owner;
        public virtual string Info { get; set; }

        public abstract string GetExtension();

        public EventExtension()
        {
        }

        public static EventExtension Create<T>(CalendarEvent owner) where T : EventExtension, new()
        {
            var result = new T
            {
                _owner = owner
            };
            return result;
        }

        public void RemoveExtension()
        {
            _owner = null;
        }
    }
}
