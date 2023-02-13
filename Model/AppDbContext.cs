using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDB.Model
{
    public class AppDbContext: DbContext
    {
        public AppDbContext() : base("DefaultConnection") { }
        public DbSet<Device> Devices { get; set; }
        public DbSet<TypeDevice> TypeDevices { get; set; }
        public DbSet<Maker> Makers { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Operable> Operables { get; set; }

    }
}
