
using Blog.Framework.Comments;
using Data;
using Framework.Categories;
using Framework.Comments;
using System;
using System.Collections.Generic;
using System.Text;


namespace Framework.BlogCompose
{
    public class BlogComposes : IEntity<int>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Date { get; set; } 
        public int CategoryId { get; set; }
        public ICollection<Category> Category { get; set; }
        public IList<Comment> Comments { get; set; }
    }
}
