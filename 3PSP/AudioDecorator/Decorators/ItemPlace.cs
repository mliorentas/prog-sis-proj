using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPSP
{
    class ItemPlace : EventDecorator
    {
        public string Place { get; set; }

        public ItemPlace(CalendarEvent item) : base (item)
        {
            Info = "Place";
        }

        public override string GetItem()
        {
            return String.Format("{0}\nPlace: {1}", _item.GetItem(), Place);
        }
    }
}
