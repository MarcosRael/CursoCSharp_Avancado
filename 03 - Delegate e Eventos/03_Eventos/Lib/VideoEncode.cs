using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _03_Eventos.Lib
{
    public class VideoEncode
    {

        //public delegate void VideoEncodeHandler(Videos video);
        //public event VideoEncodeHandler Encoded;

        public event EventHandler<VideoEventArgs> Encoded;
        
        public void Encode(Videos video)
        {
            Console.WriteLine("Convertendo o  video....");
            Thread.Sleep(2000);
            Console.WriteLine("Video convertido!");

            Encoded(this, new VideoEventArgs() { Video = video });

        }
    }
    public class VideoEventArgs : EventArgs
    {
        public Videos Video { get; set; }
    }
}
