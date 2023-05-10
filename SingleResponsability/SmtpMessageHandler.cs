using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability
{
    public class SmtpMessageHandler : ISendMessage
    {
        HtmlConverter HtmlConverter = new();

        public void SendMessage(Message m)
        {
            m.Body = HtmlConverter.Convert(m.Body);
        }

        public void SendMessageToAll(string[] to, Message m)
        {
            m.Body = HtmlConverter.Convert(m.Body);
        }
    }
}
