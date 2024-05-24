using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___lv6
{
    public interface IAbstractIterator
    {
        Note First();
        Note Next();
        bool IsDone { get; }
        Note Current { get; }
    }
}
