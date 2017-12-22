using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPSP
{
    class ItemDate : EventExtension
    {
        public DateTime Date { get; set; }
        public override string Info { get { return "Date"; } }

        public string GetTime()
        {
            return String.Format("Time: {0}", Date);
        }


        public override string GetExtension()
        {
            return GetTime();
        }

        public int CalculateDaysUntilEvent()
        {
            var now = DateTime.Now;
            var days = (Date - now).Days;
            return days >= 0 ? days : -1;
        }
    }
}
