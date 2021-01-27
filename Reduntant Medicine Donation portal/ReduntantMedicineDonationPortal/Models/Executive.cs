using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reduntant_Medicine_Donation_portal.Models
{
    public class Executive
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int OrganizationId { get; set; }
        public IList<Organizer> Organizer { get; set; }
    }
}
