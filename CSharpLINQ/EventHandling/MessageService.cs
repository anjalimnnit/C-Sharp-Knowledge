using System;

namespace EventHandling
{
    class MessageService
    {
        public void SendMessage(object source, EventArgs eventArgs)
        {
            Console.WriteLine("Successfully sent a messsage");
        }
    }
}
