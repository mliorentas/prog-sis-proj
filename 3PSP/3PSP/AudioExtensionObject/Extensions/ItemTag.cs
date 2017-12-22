using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPSP
{
    class ItemTag : EventExtension
    {
        HashSet<string> _tags = new HashSet<string>();
        public override string Info { get{ return "Tags"; } }


        public override string GetExtension()
        {
            return "[" + String.Join("], [", _tags)+ "]";
        }

        public void AddTag(string tag)
        {
            _tags.Add(tag);
                //_owner.Title = String.Format("{0} [{1}]", _owner.Title, tag);
        }

        public void RemoveTag(string tag)
        {
            _tags.Remove(tag);
                //_owner.Title = _owner.Title.Replace(String.Format("[{0}]", tag), "");
        }
    }
}
