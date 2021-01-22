
using Data;
using Framework;
using Framework.Comments;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Framework.Comments
{
    public class CommentRepository : Repository< Comment, int, FrameworkContext>, ICommentRepository
    {
        public CommentRepository(FrameworkContext frameworkContext) : base(frameworkContext)
        {

        }
    }
}
