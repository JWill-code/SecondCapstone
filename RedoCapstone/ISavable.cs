using System.Xml.Linq;

namespace RedoCapstone
{
    internal interface ISaveable
    {
        XElement ToXElement();

    }
}
