using AutoresAPI.Core.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoresAPI.Data.Configurations
{
    public class LibroConfiguration : IEntityTypeConfiguration<Libro>
    {
        public void Configure(EntityTypeBuilder<Libro> builder)
        {
            builder
                .HasKey(m => m.ISBN);

            builder
                .Property(m => m.ISBN)
                .UseIdentityColumn();

            builder
               .Property(m => m.Titulo)
               .HasMaxLength(45);

            builder
               .Property(m => m.NPaginas)
               .HasMaxLength(45);

            builder
                 .HasOne(m => m.Editorial)
                 .WithMany(a => a.Libros)
                 .HasForeignKey(m => m.EditorialID);

            builder
               .ToTable("libros");
        }
    }
}
