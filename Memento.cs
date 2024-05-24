using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___lv6
{
    public class Memento
    {
        public string Title { get; private set; }
        public string Text { get; private set; }
        public DateTime TimeDue { get; private set; }
        public DateTime CreationTime { get; private set; }
        public Memento(string title, string text, DateTime timeDue, DateTime creationTime)
        {
            this.Title = title;
            this.Text = text;
            this.TimeDue = timeDue;
            this.CreationTime = creationTime;
        }
    }
}
