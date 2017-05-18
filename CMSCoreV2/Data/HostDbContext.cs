using CMSCoreV2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSCoreV2.Data
{
    public class HostDbContext : DbContext
    {


        public HostDbContext(DbContextOptions<HostDbContext> options)
        : base(options)
        {

        }

        public DbSet<AppTenant> AppTenants { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
