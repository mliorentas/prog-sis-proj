using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDecorator
{
    class EventDecorator : Event
    {
        protected Event _item;

        public EventDecorator(Event item)
        {
            _item = item;
        }

        public static Event RemoveRole<T>(Event item) where T : EventDecorator
        {
            if (item == null)
                return null;

            EventDecorator role = (item as EventDecorator);

            if (role == null)
                return item;

            if (role is T)
                return role._item;

            role._item = RemoveRole<T>(role._item);

            return role;
        }

        public static T GetRole<T>(Event item) where T : EventDecorator
        {
            if (item == null)
                return null;

            if (item is T)
                return item as T;

            EventDecorator role = item as EventDecorator;

            if (role == null)
                return null;

            if (role._item != null)
                return GetRole<T>(role._item);

            return null;
        }

        protected Event GetEvent()
        {
            var role = _item as EventDecorator;
            if (role == null)
                return _item;
            else
                return role.GetEvent();
        }

        public override string GetItem()
        {
            return _item.GetItem();
        }

        public override string GetTypeInfo()
        {
            return String.Format("{0}, {1}", _item.GetTypeInfo(), Info);
        }
    }
}
