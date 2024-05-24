using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___lv6
{
    public class StringLengthChecker : StringChecker
    {
        private int length;
        public StringLengthChecker(int length) 
        {
            this.length = length;
        }
        protected override bool PerformCheck(string stringToCheck)
        {
            // return stringToCheck.Length == length;

            if (stringToCheck.Length >= length)
            {
                return true;
            }

            return false;
        }
    }
}
