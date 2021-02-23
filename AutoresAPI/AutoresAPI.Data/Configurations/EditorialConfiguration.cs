﻿using AutoresAPI.Core.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoresAPI.Data.Configurations
{
    public class EditorialConfiguration : IEntityTypeConfiguration<Editorial>
    {
        public void Configure(EntityTypeBuilder<Editorial> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(m => m.Nombre)
                .HasMaxLength(45);

            builder
                .Property(m => m.Sede)
                .HasMaxLength(45);

            builder
               .ToTable("editoriales");
        }
    }
}