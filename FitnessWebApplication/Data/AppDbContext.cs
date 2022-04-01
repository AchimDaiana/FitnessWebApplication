using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessWebApplication.Models;

namespace FitnessWebApplication.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User_Subscription>().HasKey(am => new
            {
                am.SubscriptionId,
                am.UserId
            });

            modelBuilder.Entity<User_Subscription>().HasOne(m => m.Subscription).WithMany(am => am.User_Subscriptions).HasForeignKey(m => m.SubscriptionId);
            modelBuilder.Entity<User_Subscription>().HasOne(m => m.User).WithMany(am => am.User_Subscriptions).HasForeignKey(m => m.UserId);
            
            
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<User_Subscription> User_Subcriptions { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Classes> Classes { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
    }
}
