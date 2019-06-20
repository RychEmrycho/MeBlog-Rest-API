using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeBlog_Rest_API.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Post> Posts { get; set; }

        public override string ToString()
        {
            return "BlogId: " + BlogId + "\n,"
                + "Name: " + Name + "\n,"
                + "Desc: " + Description + "\n";
        }
    }
}
