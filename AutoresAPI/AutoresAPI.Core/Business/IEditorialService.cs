using AutoresAPI.Core.Business.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoresAPI.Core.Business
{
    public interface IEditorialService
    {
        Task<Editorial> ObtenerPorId(int Id);

        Task<IEnumerable<Editorial>> Listado();

        Task<Editorial> Guardar(Editorial editorial);

        Task Actualizar(Editorial original, Editorial fuente);

        Task<IEnumerable<Autor>> ObtenerAutoresPorEditorial(int Id);

    }
}
