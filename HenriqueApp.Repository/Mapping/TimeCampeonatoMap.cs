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
    internal class TimeCampeonatoMap : IEntityTypeConfiguration<TimeCampeonato>
    {
        public void Configure(EntityTypeBuilder<TimeCampeonato> builder)
        {
            builder.ToTable("TimeCampeonato");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Posicao)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Pontos)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Golpro)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Golcon)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.HasOne(prop => prop.Time);

            builder.HasOne(prop => prop.Temp);

        }
    }
}
