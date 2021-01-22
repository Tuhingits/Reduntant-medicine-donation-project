
using Blog.Framework.BlogCompose;
using Data;
using Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.BlogCompose
{
    public class BlogComposeRepository : Repository<BlogComposes, int, FrameworkContext>, IBlogComposeRepository
    {
        public BlogComposeRepository(FrameworkContext frameworkContext) : base(frameworkContext)
        {

        }
    }
}