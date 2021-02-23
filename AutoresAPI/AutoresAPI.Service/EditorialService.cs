using AutoresAPI.Core.Business;
using AutoresAPI.Core.Business.Models;
using AutoresAPI.Core.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoresAPI.Service
{
    public class EditorialService : IEditorialService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EditorialService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task Actualizar(Editorial original, Editorial fuente)
        {
            original.Nombre = fuente.Nombre;
            original.Sede = fuente.Sede;

            await _unitOfWork.CommitAsync();
        }

        public async Task<Editorial> Guardar(Editorial editorial)
        {
            await _unitOfWork.Editoriales.AddAsync(editorial);
            await _unitOfWork.CommitAsync();

            return editorial;
        }

        public async Task<IEnumerable<Editorial>> Listado()
         => await _unitOfWork.Editoriales.GetAllAsync();

        public async Task<Editorial> ObtenerPorId(int Id)
        {
            return await _unitOfWork.Editoriales.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<IEnumerable<Autor>> ObtenerAutoresPorEditorial(int Id)
        {
            var data = await _unitOfWork.LibroYAutor
                .FindAsync(x => x.Libro.EditorialID == Id, null, x => x.Autor);
                
            return data.Select(x => x.Autor).GroupBy(x => x.Id).Select(y => y.First());
        }

    }
}
