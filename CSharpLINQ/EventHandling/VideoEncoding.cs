
using System;

namespace EventHandling
{
    class VideoEncoding
    {
        public void EncodeVideo()
        {
           Console.WriteLine("Video is encoded successfully");
            OnVideoEncoded();
        }
       // public delegate void VideoEncodingEventHandler(object source, EventArgs eventArgs);

        public event EventHandler VideoEncoded;

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }
    }
}
