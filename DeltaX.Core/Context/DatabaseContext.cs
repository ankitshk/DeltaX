using DeltaX.Core.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeltaX.Core.Context
{
    public class DatabaseContext : IdentityDbContext<User>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {

        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Producer> Producers { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);
            mb.Entity<Actor>().ToTable("Actors");
            mb.Entity<Movie>().ToTable("Movies");
            mb.Entity<Producer>().ToTable("Producers");
            mb.Entity<Actor>().HasKey(ac => ac.Id);
            mb.Entity<Movie>().HasKey(ac => ac.Id);
            mb.Entity<Producer>().HasKey(ac => ac.Id);
            mb.Entity<Actor>().HasMany(a => a.Movie).WithOne().HasForeignKey(a => a.ActorId);
            //mb.Entity<Movie>().HasMany(a => a.Actors).WithOne().HasForeignKey(a => a.MovieId).OnDelete(Microsoft.EntityFrameworkCore.Metadata.DeleteBehavior.Restrict);
            mb.Entity<Movie>().HasOne(a => a.Producers).WithMany(a => a.Movies);

        }
    }
}
