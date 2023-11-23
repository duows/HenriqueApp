using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HenriqueApp.Domain.Entities;

namespace HenriqueApp.Repository.Mapping
{
    internal class TemporadaMap : IEntityTypeConfiguration<Temporada>
    {
        public void Configure(EntityTypeBuilder<Temporada> builder)
        {
            builder.ToTable("Temporada");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Ano)
                .IsRequired()
                .HasColumnType("varchar(100)");

        }
    }
}
