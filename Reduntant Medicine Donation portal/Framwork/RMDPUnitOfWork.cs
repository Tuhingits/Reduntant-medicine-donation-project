using Data;
using Framework.BlogCompose;
using Framework.Categories;
using Framework.Comments;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework
{
    public class RMDPUnitOfWork : UnitOfWork, IRMDPUnitOfWork
    {
        public ICategoryRepository CategoryRepository { get; set; }
        public IBlogComposeRepository BlogRepository { get; set; }
        public ICommentRepository CommentRepository { get; set; }

        public RMDPUnitOfWork( FrameworkContext frameworkContext ,ICategoryRepository categoryRepository, 
                                                                  ICommentRepository  commentRepository,
                                                                  IBlogComposeRepository composeRepository)
            :base(frameworkContext)
        {
            CategoryRepository = categoryRepository;
            BlogRepository = composeRepository;
            CommentRepository = commentRepository;
        }
    }
}
