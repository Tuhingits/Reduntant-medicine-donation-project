
using Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Comments
{
    public interface ICommentRepository : IRepository< Comment, int, FrameworkContext >
    {
    }
}
