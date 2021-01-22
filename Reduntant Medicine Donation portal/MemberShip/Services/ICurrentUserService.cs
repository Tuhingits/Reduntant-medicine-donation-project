using System;
using System.Collections.Generic;
using System.Text;

namespace MemberShip.Services
{
    public interface ICurrentUserService
    {
        Guid UserId { get; }
        bool IsAuthenticated { get; }
    }
}
