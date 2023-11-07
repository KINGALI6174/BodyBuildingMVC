using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyBuilding.Domain.Entities.Movement;

;

namespace BodyBuilding.Infrastructuer.DbContext
{
    public class BodyBuildingDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =DESKTOP-K81JHQ4;Initial Catalog =BodyBuilding;Integrated Security=True;multipleActiveResultSets=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Athlete> Athletes { get; set; }

        public DbSet<Movement> Movements { get; set; }
    }
}
