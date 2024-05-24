using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___lv6
{
    public class BankCareTaker
    {
        public List<BankMemento> mementos;

        public BankCareTaker()
        {
            mementos = new List<BankMemento>();
        }

        public void StoreMemento(BankMemento memento)
        {
            mementos.Add(memento);
        }

        public BankMemento RestoreMemento()
        {
            if (mementos.Count == 0)
            {
                return null;
            }
            else
            {
                BankMemento lastMemento = mementos.Last();
                mementos.Remove(lastMemento);
                return lastMemento;
            }
        }
    }
}
