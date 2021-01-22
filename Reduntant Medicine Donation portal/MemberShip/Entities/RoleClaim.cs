using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MemberShip.Entities
{
    public class RoleClaim
        : IdentityRoleClaim<Guid>
    {
        public RoleClaim()
            : base()
        {

        }
    }
}
