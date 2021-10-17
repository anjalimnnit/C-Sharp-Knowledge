using System;

namespace EventHandling
{
    class Program
    {
        static void Main()
        {
            var encoding = new VideoEncoding(); //publisher
            var mail = new MailService(); //subscriber
            var message = new MessageService(); //subscriber

            encoding.VideoEncoded += mail.SendMail;
            encoding.VideoEncoded += message.SendMessage;
            encoding.EncodeVideo();
        }
    }
}
