using AutoresAPI.Core.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoresAPI.Data.Configurations
{
    public class AutorConfiguration : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
               .Property(m => m.Id)
               .UseIdentityColumn();

            builder
               .Property(m => m.Nombres)
               .HasMaxLength(45);

            builder
                .Property(m => m.Apellidos)
                .HasMaxLength(45);

            builder
                .ToTable("autores");
        }
    }
}
