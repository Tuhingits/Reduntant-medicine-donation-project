
using Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Categories
{
    public interface ICategoryRepository : IRepository<Category, int, FrameworkContext>
    {
    }
}
