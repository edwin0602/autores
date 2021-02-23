using AutoresAPI.Core.Business.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoresAPI.Core.Business
{
    public interface IAutorService
    {
        Task<IEnumerable<Autor>> Listado();

        Task<Autor> ObtenerPorId(int Id);

        Task<Autor> Guardar(Autor libro);
    }
}
