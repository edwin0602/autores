using AutoresAPI.Core.Business.Models;
using AutoresAPI.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoresAPI.Data.Repositories
{
    public class LibroYAutorRepository : Repository<LibroYAutor>, ILibroYAutorRepository
    {
        public LibroYAutorRepository(DataContext context)
            : base(context)
        { }
    }
}
