using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
    class Post
    {
        private static int currentPostId;
        //properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        public string SentByUsername { get; set; }
        public bool IsPublic { get; set; }

        //Default constructor
        public Post()
        {
            ID = 0;
            Title = "My Fri";
            IsPublic = true;
            SentByUsername = "lo";
        }

        //Instance constructor that has three parameter;
        public  Post(string title, bool isPublic, string sendByUsername)
        {

            this.ID = GetNextId();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SentByUsername = sendByUsername;
        }

        protected int GetNextId()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }


        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SentByUsername);
        }
    }

    class ImagePost: Post
    {
        public string ImageURL { get; set; }
        public ImagePost() { }

        public ImagePost(string title, bool isPublic, string sendByUsername) : base(title, isPublic, sendByUsername)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SentByUsername = sendByUsername;
            this.IsPublic = isPublic;
            this.ImageURL = ImageURL;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SentByUsername);
        }
    }
}
