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
    internal class PartidaMap : IEntityTypeConfiguration<Partida>
    {
        public void Configure(EntityTypeBuilder<Partida> builder)
        {
            builder.ToTable("Partida");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Data)
                .HasDefaultValue(DateTime.Now);

            builder.Property(prop => prop.Gol1);

            builder.Property(prop => prop.Gol2);

            builder.HasOne(prop => prop.TempCampId);

            builder.HasOne(prop => prop.Time1);

            builder.HasOne(prop => prop.Time2);
        }
    }
}
