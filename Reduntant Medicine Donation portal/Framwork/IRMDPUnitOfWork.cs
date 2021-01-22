using Blog.Framework.BlogCompose;
using Blog.Framework.Comments;
using Data;
using Framework.BlogCompose;
using Framework.Categories;
using Framework.Comments;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework
{
    public interface IRMDPUnitOfWork:IUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; set; }
        IBlogComposeRepository BlogRepository { get; set; }
        ICommentRepository CommentRepository { get; set; }
    }
}
