﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDecorator
{
    abstract class Event
    {
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual string Info { get; set; }

        public virtual string GetTypeInfo()
        {
            return Info;
        }
        abstract public string GetItem();
    }
}
