using Domain;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infra.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Voto> Votos { get; set; }
        public DbSet<Candidato> Candidatos { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}