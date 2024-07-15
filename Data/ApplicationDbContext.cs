using Microsoft.EntityFrameworkCore;
using BootstrapProto.Models.Entities;

namespace BootstrapProto.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<BodyPart> BodyParts { get; set; }
        public DbSet<Excercise> Excercises { get; set; }
        public DbSet<Provider> ServiceProviders { get; set; }
        public DbSet<ProviderType> Types { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<WorkOut_Excercise> Workout_Excercises { get; set; }
        public DbSet<Warm_Ups> Warm_Ups { get; set; }
    }
    
}
