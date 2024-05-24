using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___lv6
{
    public class PasswordValidator
    {
        private StringChecker firstChecker;
        private StringChecker lastChecker;
        public PasswordValidator(StringChecker firstChecker) 
        { 
            this.firstChecker = firstChecker;
            this.lastChecker = firstChecker;
        }

        public void AddChecker(StringChecker checker)
        {
            lastChecker.SetNext(checker);
            lastChecker = checker;
        }

        public bool CheckPassword(string password)
        {
            return firstChecker.Check(password);
        }
    }
}
