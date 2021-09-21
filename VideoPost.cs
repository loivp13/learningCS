using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
    class VideoPost : Post
    {
        //member
        protected bool isPlaying = false;
        protected int CurrDuration = 0;
        Timer timer;
        //properties
        protected string VideoUrl { get; set; }
        protected float Length { get; set; }
        public VideoPost()
        {

        }

        public VideoPost(string title, bool isPublic, string sendByUsername, string videoUrl, float length) : base(title, isPublic, sendByUsername)

        {
            //inherited
            this.Title = title;
            this.IsPublic = isPublic;
            this.SentByUsername = sendByUsername;
            this.ID = GetNextId();
            //unique
            this.VideoUrl = videoUrl;
            this.Length = length;


        }

        public override string ToString()
        {
            return String.Format($"{VideoUrl}:{Length}: {Title}");
        }

        public void Play()
        {
            Console.WriteLine("I'm playing your video");
            timer = new Timer(TimerCallback, null, 0, 1000);
        }
        private void TimerCallback(Object o)
        {
            if(CurrDuration < Length)
            {
                CurrDuration++;
                Console.WriteLine($"Video at {CurrDuration}s");
            }else
            {
                Stop();
            }
        }
        public void Stop()
        {
            if (isPlaying)
            {
                Console.WriteLine($"Stopped at {CurrDuration} ");
                CurrDuration = 0;
                timer.Dispose();
            }
       
        }
    }
}
