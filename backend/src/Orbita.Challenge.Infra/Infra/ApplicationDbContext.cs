using Microsoft.EntityFrameworkCore;
using Orbita.Challenge.Core.Entities;
using Orbita.Challenge.Infra.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orbita.Challenge.Infra.Infra
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentMapping());
            modelBuilder.Entity<Student>()
                .HasData(
                    new Student() { Name = "Vinicius Rocha", Cpf = "19857635408", Email = "vinicius.estudos@escola.com" },
                    new Student() { Name = "Isabelle", Cpf = "78965325872", Email = "isabelle.estudos@escola.com" },
                    new Student() { Name = "Guilherme", Cpf = "755634198635", Email = "guilherme.estudos@escola.com" }
                );
        }
    }
}
