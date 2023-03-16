using Microsoft.EntityFrameworkCore;
using PokemanReviewApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemanReviewApp.Data
{
    public class DataContext :DbContext 
    {
        public DataContext(DbContextOptions<DataContext> Options): base(Options)
        {
              
        }

        public  DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Pokeman> Pokeman { get; set; }
        public DbSet<Owner>Owners { get; set; }
        public DbSet<PokemanCategory> PokemanCategories { get; set; }
        public DbSet<PokemanOwner>PokemanOwners { get; set; }
        public DbSet<Review>Reviews { get; set; }
        public DbSet<Reviewer>Reviewers  { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokemanCategory>()
                .HasKey(pc => new { pc.PokemanId, pc.CategoryId });
            modelBuilder.Entity<PokemanCategory>()
                .HasOne(p => p.Pokeman)
                .WithMany(pc => pc.PokemanCategories)
                .HasForeignKey(p => p.PokemanId);
            modelBuilder.Entity<PokemanCategory>()
                .HasOne(p => p.Category)
                .WithMany(pc => pc.PokemanCategories)
                .HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<PokemanOwner>()
                .HasKey(po => new { po.PokemanId, po.OwnerId });
            modelBuilder.Entity<PokemanOwner>()
                .HasOne(p => p.Pokeman)
                .WithMany(po => po.PokemanOwners)
                .HasForeignKey(p => p.PokemanId);
            modelBuilder.Entity<PokemanOwner>()
                .HasOne(p => p.Owner)
                .WithMany(po => po.PokemanOwners)
                .HasForeignKey(c => c.OwnerId);

        }
    }
}
