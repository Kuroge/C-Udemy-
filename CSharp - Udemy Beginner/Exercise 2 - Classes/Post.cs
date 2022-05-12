using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2___Classes
{
    public class Post
    {
        public string Title { get; set; }

        public string Description { get; set; }

        private DateTime CreationDate { get; set; }

        public int VoteValue { get; private set; }

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.CreationDate = DateTime.Now;
        }

        public void UpVote()
        {
            VoteValue++;
        }

        public void DownVote()
        {
            VoteValue--;
        }


    }
}
