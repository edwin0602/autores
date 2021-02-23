using System;
using System.Threading.Tasks;

namespace AutoresAPI.Core.Data
{
    public interface IUnitOfWork : IDisposable
    {
        public IAutorRepository Autores { get; }

        public IEditorialRepository Editoriales { get; }

        public ILibroRepository Libros { get; }

        public ILibroYAutorRepository LibroYAutor { get; }

        Task<int> CommitAsync();
    }
}
