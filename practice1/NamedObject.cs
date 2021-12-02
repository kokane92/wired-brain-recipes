using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{
    class NamedObject : Object
    {
        public NamedObject(string name)
        {
            Name = name;
        }

        public string Name
        {
            set;get;
        }

    }
}
