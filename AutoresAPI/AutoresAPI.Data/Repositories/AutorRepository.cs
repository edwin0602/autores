using AutoresAPI.Core.Business.Models;
using AutoresAPI.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoresAPI.Data.Repositories
{
    public class AutorRepository : Repository<Autor>, IAutorRepository
    {
        public AutorRepository(DataContext context)
            : base(context)
        { }
    }
}
