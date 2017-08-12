using System.Collections.Generic;

namespace LMSModel.BlogPost
{
    public class Tag
    {

        public Tag()
        {
            this.Posts = new HashSet<Post>();
        }

        public int TagId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
