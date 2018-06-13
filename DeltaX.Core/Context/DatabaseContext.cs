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
            mb.Entity<Movie>().HasOne(a => a.Producers).WithMany(a => a.Movies).IsRequired();
            mb.Entity<MoviesActors>().HasKey(a => new { a.ActorId, a.MovieId });
            mb.Entity<MoviesActors>().HasOne(a => a.Movies).WithMany(a => a.MoviesActors).HasForeignKey(a => a.MovieId);
            mb.Entity<MoviesActors>().HasOne(a => a.Actors).WithMany(a => a.MoviesActors).HasForeignKey(a => a.ActorId);

        }
    }
}
