using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPSP
{
    abstract class CalendarEvent
    {
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual string Info { get; set; }
        List<EventExtension> _extensions = new List<EventExtension>();

        public virtual string GetTypeInfo()
        {
            return Info + ", " + String.Join(", ", _extensions.Select(s => s.Info));
        }
        public abstract string GetItem();

        public T AddExtension<T>() where T : EventExtension, new()
        {
            var extension = EventExtension.Create<T>(this);
            _extensions.Add(extension);
            return extension as T;
        }

        public int RemoveExtension<T>() where T : EventExtension
        {
            foreach (var extension in _extensions.Where(item => item is T))
            {
                extension.RemoveExtension();
            }
            return _extensions.RemoveAll(item => item is T );
        }

        public T GetExtension<T>() where T : EventExtension
        {
            if (_extensions.Count == 0)
                return null;
            foreach(var extension in _extensions)
            {
                if (extension is T)
                    return extension as T;
            }
            return null;
        }

        public string GetExtensions()
        {
            return String.Join("\n", _extensions.Select(ex => ex.GetExtension()));
        }


    }
}
