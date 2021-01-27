using MemberShip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reduntant_Medicine_Donation_portal.Models
{
    public class DonateMedicine
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ExpireDate { get; set; }
        public int Quantity { get; set; }
        public string DonarId { get; set; }
        public int OrgId { get; set; }

        //public IList<Organizer> Organizer { get; set; }
        //public IList<ApplicationUser> ApplicationUser { get; set; }
    }
}
