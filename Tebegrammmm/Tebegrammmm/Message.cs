using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tebegrammmm
{
    public class Message
    {
        private string _Sender;
        private string _Text;
        private string _Time;

        public string Sender { get { return _Sender; } }
        public string Text { get { return _Text; } }
        public string Time { get { return _Time; } }

        public Message(string sender, string text, string time)
        {
            _Sender = sender;
            _Text = text;
            _Time = time;
        }
    }
}
