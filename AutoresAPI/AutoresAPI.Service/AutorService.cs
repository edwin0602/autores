using AutoresAPI.Core.Business;
using AutoresAPI.Core.Business.Models;
using AutoresAPI.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoresAPI.Service
{
    public class AutorService : IAutorService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AutorService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<Autor> Guardar(Autor libro)
        {
            await _unitOfWork.Autores.AddAsync(libro);
            await _unitOfWork.CommitAsync();

            return libro;
        }

        public async Task<IEnumerable<Autor>> Listado()
            => await _unitOfWork.Autores.GetAllAsync();

        public async Task<Autor> ObtenerPorId(int Id)
            => await _unitOfWork.Autores.FirstOrDefaultAsync(x => x.Id == Id);
    }
}
