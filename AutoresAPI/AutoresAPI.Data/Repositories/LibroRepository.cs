using AutoresAPI.Core.Business.Models;
using AutoresAPI.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutoresAPI.Data.Repositories
{
    public class LibroRepository : Repository<Libro>, ILibroRepository
    {
        public LibroRepository(DataContext context)
            : base(context)
        { }

        public async Task<IEnumerable<Libro>> GetAllWithAutoresAsync()
        {
            return await DataContext.Libros
                          .Include(e=> e.Editorial)
                          .Include(m => m.Autores)
                            .ThenInclude(p => p.Autor)
                          .ToListAsync();
        }

        private DataContext DataContext
        {
            get { return Context as DataContext; }
        }
    }
}
