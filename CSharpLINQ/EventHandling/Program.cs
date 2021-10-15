using System;

namespace EventHandling
{
    class Program
    {
        static void Main()
        {
            VideoEncoding encoding = new VideoEncoding(); //publisher
            MailService mail = new MailService(); //subscriber
            MessageService message = new MessageService(); //subscriber

            encoding.VideoEncoded += mail.SendMail;
            encoding.VideoEncoded += message.SendMessage;
            encoding.EncodeVideo();
        }
    }
}
