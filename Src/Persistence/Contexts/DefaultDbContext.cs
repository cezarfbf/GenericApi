using ApplicationCore.Domain.Common;
using ApplicationCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Persistence.Contexts
{
    public class DefaultDbContext : DbContext, IDefaultDbContext
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options)
            : base(options)
        {

        }

        public DbSet<Product> Products { get ; set ; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            ChangeTracker.DetectChanges();

            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                if (entry.State == EntityState.Added)
                {
                    //entry.Entity.CreatedBy = _currentUserService.GetUserId();
                    //entry.Entity.Created = _dateTime.Now;

                }
                else if (entry.State == EntityState.Modified)
                {
                    //entry.Entity.LastModifiedBy = _currentUserService.GetUserId();
                    //entry.Entity.LastModified = _dateTime.Now;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DefaultDbContext).Assembly);
        }
    }
}
