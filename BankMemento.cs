using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___lv6
{
    public class BankMemento
    {
        public string OwnerName { get; private set; }
        public string OwnerAddress { get; private set; }
        public decimal Balance { get; private set; }
        public BankMemento(string ownerName, string ownerAddress, decimal balance)
        {
            OwnerName = ownerName;
            OwnerAddress = ownerAddress;
            Balance = balance;
        }
    }
}
