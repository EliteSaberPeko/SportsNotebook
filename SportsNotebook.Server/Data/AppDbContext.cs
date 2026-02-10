using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportsNotebook.Server.Models;

namespace SportsNotebook.Server.Data;

public class AppDbContext : IdentityDbContext<IdentityUser>
{
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Exercise> Exercises { get; set; } = null!;
    public DbSet<Plan> Plan { get; set; } = null!;
    public DbSet<Row> Rows { get; set; } = null!;

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder
            .Entity<Exercise>()
            .HasMany(ex => ex.Plan)
            .WithMany(plan => plan.Exercises)
            .UsingEntity<Plan_Exercise>(
                j => j
                    .HasOne<Plan>(pe => pe.Plan)
                    .WithMany(p => p.Plan_Exercises)
                    .HasForeignKey(pe => pe.PlanId),
                j => j
                    .HasOne<Exercise>(pe => pe.Exercise)
                    .WithMany(e => e.Plan_Exercises)
                    .HasForeignKey(pe => pe.ExerciseId),
                d =>
                {
                    d.HasKey(t => t.Id);
                    d.ToTable("Plan_Exercise");
                });
    }
}
