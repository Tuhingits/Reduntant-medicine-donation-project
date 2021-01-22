
using Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.BlogCompose
{
    public interface IBlogComposeRepository : IRepository<BlogComposes, int, FrameworkContext>
    {
    }
}