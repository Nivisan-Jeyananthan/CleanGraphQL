using Mediator.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Mediator.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public virtual DbSet<User> Users { get; set; } = default!;
    public ApplicationDbContext() { }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<User>()
            .HasIndex(user => user.UserName)
            .IsUnique();

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

}