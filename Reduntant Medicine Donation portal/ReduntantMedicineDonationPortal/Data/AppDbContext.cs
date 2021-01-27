using Microsoft.EntityFrameworkCore;
using Reduntant_Medicine_Donation_portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reduntant_Medicine_Donation_portal.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {

        }
        public DbSet<DonateMedicine> DonateMedicines { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Executive> Executives { get; set; }
        public DbSet<AllDonatedMedicine> AllDonatedMedicines { get; set; }




    }
}
