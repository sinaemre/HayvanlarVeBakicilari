using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotation.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("server=(localdb)\\MSSQLLocalDB; database=Hayvanlar2; integrated security=true")
        {

        }
        public DbSet<Hayvan> Hayvanlar { get; set; }
        public DbSet<Yiyecek> Yiyecekler { get; set; }
        public DbSet<Bakici> Bakicilar { get; set; }

    }
}
