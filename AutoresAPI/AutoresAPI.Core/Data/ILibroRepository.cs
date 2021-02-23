using AutoresAPI.Core.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutoresAPI.Core.Data
{
    public interface ILibroRepository : IRepository<Libro>
    {
        Task<IEnumerable<Libro>> GetAllWithAutoresAsync();
    }
}
