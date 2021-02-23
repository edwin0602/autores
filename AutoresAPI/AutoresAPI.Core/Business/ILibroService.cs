using AutoresAPI.Core.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoresAPI.Core.Business
{
    public interface ILibroService
    {
        Task<Libro> Guardar(Libro libro);

        Task<Libro> ObtenerPorId(int Id);

        Task<IEnumerable<Libro>> Listado();

        Task Actualizar(Libro original, Libro libro);
    }
}
