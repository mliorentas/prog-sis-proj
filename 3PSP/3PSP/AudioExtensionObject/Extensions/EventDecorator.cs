using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDecorator
{
    class EventExtension
    {
        protected Event _owner;
        public virtual string Info { get; set; }

        public EventExtension()
        {
        }

        public static EventExtension Create<T>(Event owner) where T : EventExtension, new()
        {
            var result = new T
            {
                _owner = owner
            };
            return result;
        }
    }
}
