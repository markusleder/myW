using System.Data.Entity;

namespace MyW.Models
{
    public class MeasurementContext : DbContext
    {
        public DbSet<Individual> Individuals { get; set; }

        public DbSet<Measurement> Measurements { get; set; }
    }
}