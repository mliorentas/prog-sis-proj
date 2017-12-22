using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPSP
{
    class ItemTag : EventDecorator
    {
        HashSet<string> _tags = new HashSet<string>();

        public ItemTag(CalendarEvent item) : base(item)
        {
            Info = "Tags";
        }

        public void AddTag(string tag)
        {
            if (_tags.Add(tag))
                GetEvent().Title = String.Format("{0} [{1}]", GetEvent().Title, tag);
        }

        public void RemoveTag(string tag)
        {
            if(_tags.Remove(tag))
                GetEvent().Title = GetEvent().Title.Replace(String.Format("[{0}]", tag), "");
        }
    }
}
