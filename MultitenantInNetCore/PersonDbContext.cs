using System;
using Microsoft.EntityFrameworkCore;
using MultitenantInNetCore.Models;

namespace MultitenantInNetCore
{
    public class PersonDbContext : DbContext
    {
        private ITenantProvider _tenantProvider;

        public DbSet<Person> Person { get; set; }
        public PersonDbContext(DbContextOptions<PersonDbContext> options,
                                    ITenantProvider tenantProvider) : base(options)
        {
            _tenantProvider = tenantProvider;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>().HasQueryFilter(p => p.TenantId == _tenantProvider.GetTenantId());
        }
    }
}