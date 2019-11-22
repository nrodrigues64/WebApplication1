using System.Data.Entity;

namespace WebApplication1.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Matela> Matelas { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Assignation> Assignation { get; set; }

    }
}
