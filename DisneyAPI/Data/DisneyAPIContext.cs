using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DisneyAPI.Model;

namespace DisneyAPI.Data
{
    public class DisneyAPIContext : DbContext
    {
        public DisneyAPIContext (DbContextOptions<DisneyAPIContext> options)
            : base(options)
        {
        }

        public DbSet<DisneyAPI.Model.Personaje> Personaje { get; set; } = default!;

        public DbSet<DisneyAPI.Model.Pelicula>? Pelicula { get; set; }

        public DbSet<DisneyAPI.Model.Genero>? Genero { get; set; }

        public DbSet<DisneyAPI.Model.UserInfo> UserInfo { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DisneyAPI.Model.UserInfo>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("UserInfo");
                entity.Property(e => e.UserId).HasColumnName("UserId");
                entity.Property(e => e.DisplayName).HasMaxLength(60).IsUnicode(false);
                entity.Property(e => e.UserName).HasMaxLength(30).IsUnicode(false);
                entity.Property(e => e.Email).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.Password).HasMaxLength(20).IsUnicode(false);
                entity.Property(e => e.CreatedDate).IsUnicode(false);
            });

 

        }

    }
}
