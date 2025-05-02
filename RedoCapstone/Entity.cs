using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RedoCapstone
{
    public abstract class Entity : ISaveable
    {
        protected string name;
        protected int weight = 0;

        //Method for generating an xml object from the characters info
        public abstract XElement ToXElement();

    }
}
