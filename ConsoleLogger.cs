using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___lv6
{
    public class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(MessageType messageType) : base(messageType) { }
        protected override void WriteMessage(string message, MessageType type)
        {
            Console.WriteLine(type + ": " + DateTime.Now);
            Console.WriteLine(new string('=', message.Length));
            Console.WriteLine(message);
            Console.WriteLine(new string('=', message.Length) + "\n");
        }
    }
}
