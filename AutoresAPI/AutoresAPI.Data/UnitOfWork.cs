using AutoresAPI.Core.Data;
using AutoresAPI.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutoresAPI.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            this._context = context;
        }

        private AutorRepository _autorRepository;
        private EditorialRepository _editorialRepository;
        private LibroRepository _libroRepository;
        private LibroYAutorRepository _libroYAutorRepository;

        public IAutorRepository Autores => _autorRepository ??= new AutorRepository(_context);
        public IEditorialRepository Editoriales => _editorialRepository ??= new EditorialRepository(_context);
        public ILibroRepository Libros => _libroRepository ??= new LibroRepository(_context);
        public ILibroYAutorRepository LibroYAutor => _libroYAutorRepository ??= new LibroYAutorRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
            => _context.Dispose();

    }
}
