
using Blog.Framework.BlogCompose;
using Data;
using Framework.BlogCompose;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Categories
{
    public class Category:IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BlogComposes BlogComposes { get; set; }
    }
}
