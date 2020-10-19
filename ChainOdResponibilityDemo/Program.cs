using System;

namespace ChainOfResponibilityDemo
{
    public interface IHandlaer
    {
        void SetNextHandler(IHandlaer ihandlaer);

        void HandleLink(Video video);
    }

    public class Video
    {
       public string Link { get; set; }
    }

    class YoutubeHnadler : IHandlaer
    {
        IHandlaer IHandlaer;
        public void HandleLink(Video video)
        {
            if (video.Link.Contains("youtube"))
            {
                Console.WriteLine("i can handle it");
            }
            else
            {
                Console.WriteLine("i can't handle it, i'll sent it to another Handler");
                IHandlaer.HandleLink(video);

            }
        }

        public void SetNextHandler(IHandlaer ihandlaer)
        {
            IHandlaer = ihandlaer;
        }
    }
    class FacebookHnadler : IHandlaer
    {
        IHandlaer IHandlaer;
        public void HandleLink(Video video)
        {
            if (video.Link.Contains("facebook"))
            {
                Console.WriteLine("i can handle it");
            }
            else
            {
                Console.WriteLine("i can't handle it, i'll sent it to another Handler");
                IHandlaer.HandleLink(video);

            }
        }

        public void SetNextHandler(IHandlaer ihandlaer)
        {
            IHandlaer = ihandlaer;
        }
    }
    class InstagramHnadler : IHandlaer
    {
        IHandlaer IHandlaer;
        public void HandleLink(Video video)
        {
            if (video.Link.Contains("Instagram"))
            {
                Console.WriteLine("i can handle it");
            }
            else
            {
                Console.WriteLine("i can't handle it, i'll sent it to another Handler");
                IHandlaer.HandleLink(video);
            }
        }

        public void SetNextHandler(IHandlaer ihandlaer)
        {
            IHandlaer=ihandlaer;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video
            {
                Link = "https://www.youtube.com/watch?v=IKRVX3c8HuU"
            };

            IHandlaer handlaer1 = new YoutubeHnadler();
            IHandlaer handlaer2 = new FacebookHnadler();
            IHandlaer handlaer3 = new InstagramHnadler();

            handlaer1.SetNextHandler(handlaer2);
            handlaer2.SetNextHandler(handlaer3);

            handlaer1.HandleLink(video);
        }
    }
}
