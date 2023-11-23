using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HenriqueApp.Domain.Entities;
using HenriqueApp.Repository.Mapping;

namespace HenriqueApp.Repository.Context
{
    public sealed class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated();
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Campeonato>? Campeonato { get; set; }
        public DbSet<Jogadores>? Jogadores { get; set; }
        public DbSet<Partida>? Partida { get; set; }
        public DbSet<TempCamp>? TempCamp { get; set; }
        public DbSet<Temporada>? Temporada { get; set; }
        public DbSet<TimeCampeonato>? TimeCampeonato { get; set; }
        public DbSet<Times>? Times { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Campeonato>(new CampeonatoMap().Configure);
            modelBuilder.Entity<Jogadores>(new JogadoresMap().Configure);
            modelBuilder.Entity<Partida>(new PartidaMap().Configure);
            modelBuilder.Entity<TempCamp>(new TempCampMap().Configure);
            modelBuilder.Entity<Temporada>(new TemporadaMap().Configure);
            modelBuilder.Entity<TimeCampeonato>(new TimeCampeonatoMap().Configure);
            modelBuilder.Entity<Times>(new TimesMap().Configure);
        }
    }
}
