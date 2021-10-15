using System;

namespace EventHandling
{
    class MailService
    {
        public void SendMail(object source, EventArgs eventArgs)
        {
            Console.WriteLine("Successfully sent a mail");
        }
    }
}
