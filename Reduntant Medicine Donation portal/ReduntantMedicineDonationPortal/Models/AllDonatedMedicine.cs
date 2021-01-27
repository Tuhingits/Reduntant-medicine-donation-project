using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reduntant_Medicine_Donation_portal.Models
{
    public class AllDonatedMedicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ExpireDate { get; set; }
        public int Quantity { get; set; }
        public Guid DonarId { get; set; }
    }
}
