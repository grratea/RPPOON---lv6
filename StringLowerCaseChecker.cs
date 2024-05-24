using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___lv6
{
    public class StringLowerCaseChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            return stringToCheck.Any(char.IsLower);
        }
    }
}
