using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPSP
{
    class ItemDate : EventDecorator
    {
        public DateTime Date { get; set; }

        public ItemDate(CalendarEvent item) : base(item)
        {
            Info = "Date";
        }

        public override string GetItem()
        {
            return String.Format("{0}\nTime: {1}", _item.GetItem(), Date);
        }

        public int CalculateDaysUntilEvent()
        {
            var now = DateTime.Now;
            var days = (Date - now).Days;
            return days >= 0 ? days : -1;
        }
    }
}
