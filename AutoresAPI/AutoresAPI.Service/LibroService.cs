using AutoresAPI.Core.Business;
using AutoresAPI.Core.Business.Models;
using AutoresAPI.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoresAPI.Service
{
    public class LibroService : ILibroService
    {
        private readonly IUnitOfWork _unitOfWork;

        public LibroService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<Libro> ObtenerPorId(int Id)
            => await _unitOfWork.Libros.FirstOrDefaultAsync(x => x.ISBN == Id, i=> i.Autores);

        public async Task<Libro> Guardar(Libro libro)
        {
            await _unitOfWork.Libros.AddAsync(libro);
            await _unitOfWork.CommitAsync();

            return libro;
        }

        public async Task<IEnumerable<Libro>> Listado()
            => await _unitOfWork.Libros.GetAllWithAutoresAsync();

        public async Task Actualizar(Libro original, Libro fuente)
        {
            original.EditorialID = fuente.EditorialID;
            original.NPaginas = fuente.NPaginas;
            original.Sinopsis = fuente.Sinopsis;
            original.Titulo = fuente.Titulo;

            await _unitOfWork.CommitAsync();
        }
    }
}
