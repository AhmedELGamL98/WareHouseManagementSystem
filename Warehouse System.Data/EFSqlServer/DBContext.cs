using Microsoft.EntityFrameworkCore;
using SMSystem.Core;

namespace SMSystem.Data.EF
{
    public class DBContext : DbContext
    {

        // Constructores
        public DBContext()
        {
        }
        //Methods -- Override
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var DevelopmentConString = "Server=DESKTOP-CR1G9UU\\SQLEXPRESS;DataBase=DataBaseSMSystem;Integrated Security=True";
            optionsBuilder.UseSqlServer(DevelopmentConString);
        }
        // Tables
        public DbSet<Stores> Stores { get; set; }
        public DbSet<Materails> Materails { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Income> Income { get; set; }
        public DbSet<OutCome> OutCome { get; set; }
        public DbSet<OutComeMaterail> outComeMaterail { get; set; }
        public DbSet<Damage> Damage { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<ConscienceCard> ConscienceCard { get; set; }
        public DbSet<OutOfConscinesMaterials> OutOfConscinesMaterials { get; set; }
    }
}
