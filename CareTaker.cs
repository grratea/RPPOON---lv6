using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___lv6
{
    public class CareTaker
    {
        public List<Memento> mementos;

        public CareTaker() 
        {
            mementos = new List<Memento>();
        }

        public void StoreMemento(Memento memento)
        {
            mementos.Add(memento);
        }

        public Memento RestoreMemento()
        {
            if (mementos.Count == 0)
            {
                return null;
            }
            else
            {
                Memento lastMemento = mementos.Last();
                mementos.Remove(lastMemento);
                return lastMemento;
            }
        }

    }
}
