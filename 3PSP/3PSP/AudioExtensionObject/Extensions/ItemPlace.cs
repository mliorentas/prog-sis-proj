using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPSP
{
    class ItemPlace : EventExtension
    {
        public string Place { get; set; }
        public override string Info { get{ return "Place"; } }

        public override string GetExtension()
        {
            return GetPlace();
        }

        public string GetPlace()
        {
            return String.Format("Place: {0}", Place);
        }
    }
}
