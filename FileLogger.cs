using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___lv6
{
    public class FileLogger : AbstractLogger
    {
        private string filePath;
        public FileLogger(MessageType messageType, string filePath) : base(messageType)
        {
            this.filePath = filePath;
        }
        protected override void WriteMessage(string message, MessageType type)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.Write(type + ": " + message + " " + DateTime.Now + Environment.NewLine);
            }
            
        }
    }
}
