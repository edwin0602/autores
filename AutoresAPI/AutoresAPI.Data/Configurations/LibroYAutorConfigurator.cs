using AutoresAPI.Core.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoresAPI.Data.Configurations
{
    public class LibroYAutorConfigurator : IEntityTypeConfiguration<LibroYAutor>
    {
        public void Configure(EntityTypeBuilder<LibroYAutor> builder)
        {
            builder
                .HasKey(cv => new { cv.LibroId, cv.AutorId });

            builder
                 .HasOne(m => m.Autor)
                 .WithMany(a => a.Libros)
                 .HasForeignKey(m => m.AutorId);

            builder
                 .HasOne(m => m.Libro)
                 .WithMany(a => a.Autores)
                 .HasForeignKey(m => m.LibroId);

            builder
                .ToTable("autores_has_libros");
        }
    }
}
