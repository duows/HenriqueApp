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
    internal class JogadoresMap : IEntityTypeConfiguration<Jogadores>
    {
        public void Configure(EntityTypeBuilder<Jogadores> builder)
        {
            builder.ToTable("Jogadores");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(prop => prop.Idade)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Gols)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Assist)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Capitao)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.HasOne(prop => prop.Time);

        }
    }
}
