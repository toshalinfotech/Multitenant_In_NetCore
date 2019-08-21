using Microsoft.EntityFrameworkCore;
using MultitenantInNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultitenantInNetCore
{
    public class TenantsDbContext: DbContext
    {
        public DbSet<Tenant> Tenants { get; set; }
        public TenantsDbContext(DbContextOptions<TenantsDbContext> options) : base(options)
        {
        }
    }
}
