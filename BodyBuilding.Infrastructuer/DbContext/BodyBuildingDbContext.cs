using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyBuilding.Domain.Entities.Movement;
using BodyBuilding.Domain.Entities.Athlete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BodyBuilding.Infrastructuer.DbContext
{
    public class BodyBuildingDbContext : IdentityDbContext<IdentityUser>
    {
        public BodyBuildingDbContext(DbContextOptions<BodyBuildingDbContext> options) :base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =DESKTOP-K81JHQ4;Initial Catalog =BodyBuilding;Integrated Security=True;multipleActiveResultSets=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Athlete> Athletes { get; set; }

        public DbSet<Movement> Movements { get; set; }
    }
}
