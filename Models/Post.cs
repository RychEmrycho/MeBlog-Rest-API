using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeBlog_Rest_API.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int? BlogId { get; set; }
        public Blog Blog { get; set; }

        public override string ToString()
        {
            return "PostId: " + PostId + "\n,"
                + "Title: " + Title + "\n,"
                + "Content: " + Content + "\n,"
                + "BlogId: " + BlogId + "\n,"
                + "Blog: " + Blog.ToString();
        }
    }
}
