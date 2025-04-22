using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedoCapstone
{
    public interface IHasAttributes
    {
        int DexterityScore { get; set; }
        int ConstitutionScore { get; set; }
        int WillpowerScore { get; set; }
    }
}
