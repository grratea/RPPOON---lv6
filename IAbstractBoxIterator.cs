using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___lv6
{
    public interface IAbstractBoxIterator
    {
        Product First();
        Product Next();
        bool IsDone { get; }
        Product Current { get; }
    }
}
