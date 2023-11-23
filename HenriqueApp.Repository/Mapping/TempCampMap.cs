﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HenriqueApp.Domain.Entities;

namespace HenriqueApp.Repository.Mapping
{
    internal class TempCampMap : IEntityTypeConfiguration<TempCamp>
    {
        public void Configure(EntityTypeBuilder<TempCamp> builder)
        {
            builder.ToTable("TempCamp");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Premio)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Campeao)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.HasKey(prop => prop.Camp);

            builder.HasKey(prop => prop.Temp);
        }
    }
}
