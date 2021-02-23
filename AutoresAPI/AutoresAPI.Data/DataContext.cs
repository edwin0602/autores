using AutoresAPI.Core.Business.Models;
using AutoresAPI.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoresAPI.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Editorial> Editoriales { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<LibroYAutor> LibrosYAutores { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder
                .ApplyConfiguration(new AutorConfiguration())
                .ApplyConfiguration(new EditorialConfiguration())
                .ApplyConfiguration(new LibroConfiguration())
                .ApplyConfiguration(new LibroYAutorConfigurator());
        }

    }
}
