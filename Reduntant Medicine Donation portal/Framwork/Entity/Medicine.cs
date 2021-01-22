using Data;
using MemberShip.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framwork.Entity
{
    public class Medicine : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ExpireDate { get; set; }
        public int Quantity { get; set; }
        public Guid DonarId { get; set; }
        public IList<ApplicationUser> ApplicationUser { get; set; }
    }
}
