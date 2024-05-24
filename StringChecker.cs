using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___lv6
{
    public abstract class StringChecker
    {
        private StringChecker next;
        public void SetNext(StringChecker next)
        {
            this.next = next;
        }
        public bool Check(string stringToCheck)
        {
            bool result = this.PerformCheck(stringToCheck);
            if (this.next != null && result == true)
            {
                return this.next.Check(stringToCheck);
            }
            return result;
        }
        protected abstract bool PerformCheck(string stringToCheck);
    }

}
